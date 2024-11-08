using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;
using Newtonsoft.Json;

namespace JobFinder.Service.AutoMapper
{
    public class JobProfile : Profile
    {
        public JobProfile()
        {
            CreateMap<Job, JobModel>()
                .ForMember(des => des.Skills, opt => opt.MapFrom(src => JsonConvert.DeserializeObject<string[]>(src.Skills)));
            CreateMap<CreateJobModel, Job>()
                .ForPath(des => des.CommitmentType.Id, opt => opt.MapFrom(x => x.CommitmentTypeId))
                .ForPath(des => des.WorkArrangement.Id, opt => opt.MapFrom(x => x.WorkArrangementId))
                .ForPath(des => des.WorkExperienceRequirement.Id, opt => opt.MapFrom(x => x.WorkExperienceRequirementId))
                .ForPath(des => des.EducationLevelRequirement.Id, opt => opt.MapFrom(x => x.EducationLevelRequirementId))
                .ForPath(des => des.GenderRequirement.Id, opt => opt.MapFrom(x => x.GenderRequirementId));
            CreateMap<Job, CreateJobReponseModel>();
            CreateMap<UpdateJobModel, Job>();
            CreateMap<Job, UpdateJobReponseModel>();
            CreateMap<Metadata?, MetadataModel?>();
        }
    }
}

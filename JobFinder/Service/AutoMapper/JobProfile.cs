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
                .ForMember(des => des.Skills, opt => opt.MapFrom(src => JsonConvert.SerializeObject(src.Skills)));
            CreateMap<Job, CreateJobReponseModel>();
            CreateMap<UpdateJobModel, Job>()
                .ForMember(des => des.Skills, opt => opt.MapFrom(src => JsonConvert.SerializeObject(src.Skills)));
            CreateMap<Job, UpdateJobResponseModel>();
            CreateMap<Metadata?, MetadataModel?>();
        }
    }
}

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
                .ForMember(des => des.Skills,
                    opt => opt.MapFrom(src => JsonConvert.DeserializeObject<string[]>(src.Skills)));
            CreateMap<SeedJob, Job>()
                .ForMember(des => des.Skills, opt => opt.MapFrom(src => JsonConvert.SerializeObject(src.Skills)));
            CreateMap<CreateJobModel, Job>()
                .ForMember(des => des.Skills, opt => opt.MapFrom(src => JsonConvert.SerializeObject(src.Skills)));
            CreateMap<UpdateJobModel, Job>()
                .ForMember(des => des.Skills, opt => opt.MapFrom(src => JsonConvert.SerializeObject(src.Skills)));
            CreateMap<JobModel, SuggestibleJob>();
            CreateMap<Job, UserApplicationJob>()
                .ForMember(x => x.Company,
                    opt => opt.MapFrom(src => new UserApplicationCompany()
                    {
                        Id = src.Company.Id, Name = src.Company.Name, Slug = src.Company.Slug, Logo = src.Company.Logo
                    }));
            CreateMap<Job, CreateJobReponseModel>();
            CreateMap<Job, UpdateJobResponseModel>();
            CreateMap<Metadata?, MetadataModel?>();
        }
    }
}
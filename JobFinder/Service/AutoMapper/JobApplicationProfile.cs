using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service.AutoMapper
{
    public class JobApplicationProfile : Profile
    {
        public JobApplicationProfile()
        {
            CreateMap<JobApplication, JobApplicationModel>();
            CreateMap<JobApplication, CreateJobApplicationResponseModel>();
            CreateMap<JobApplication, UserApplication>();
            CreateMap<JobApplication, JobApplicationWithJobId>();
            CreateMap<CreateJobApplicationModel, JobApplication>()
                .ForMember(x => x.CVLink, opt => opt.Ignore());
            CreateMap<Job, JobModel>();
            CreateMap<User, UserModel>();
        }
    }
}

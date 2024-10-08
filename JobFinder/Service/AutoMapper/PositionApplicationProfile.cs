using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service.AutoMapper
{
    public class PositionApplicationProfile : Profile
    {
        public PositionApplicationProfile()
        {
            CreateMap<PositionApplication, PositionApplicationModel>();
            CreateMap<PositionApplication, CreatePositionApplicationReponseModel>();
            CreateMap<CreatePositionApplicationModel, PositionApplication>()
                .ForMember(x => x.CVLink, opt => opt.Ignore());
        }
    }
}

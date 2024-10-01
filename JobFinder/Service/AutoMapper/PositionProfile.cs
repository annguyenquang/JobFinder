using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Account;

namespace JobFinder.Service.AutoMapper
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<Position, PositionModel>();
        }
    }
}

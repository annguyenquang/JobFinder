using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service.AutoMapper
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<Position, PositionModel>();
            CreateMap<CreatePositionModel, Position>();
            CreateMap<Position, CreatePositionReponseModel>();
        }
    }
}

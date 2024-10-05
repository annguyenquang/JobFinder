using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service.AutoMapper
{
    public class FirmProfile : Profile
    {
        public FirmProfile()
        {
            CreateMap<Firm, FirmModel>();
            CreateMap<FirmModel, Firm>();
            CreateMap<CreateFirmModel, Firm>();
            CreateMap<Firm, CreateFirmResponseModel>();
            CreateMap<UpdateFirmModel, Firm>();
            CreateMap<Firm, UpdateFirmReponseModel>();
        }
    }
}

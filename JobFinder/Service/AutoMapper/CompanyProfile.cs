using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;
using BC = BCrypt.Net.BCrypt;
namespace JobFinder.Service.AutoMapper
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyModel>();
            CreateMap<CompanyModel, Company>();
            CreateMap<CreateCompanyModel, Company>()
                .ForMember(des => des.Password, opt => opt.MapFrom(src => BC.HashPassword(src.Password)));
            CreateMap<Company, CreateCompanyResponseModel>();
            CreateMap<UpdateCompanyModel, Company>();
            CreateMap<Company, UpdateCompanyReponseModel>();
        }
    }
}

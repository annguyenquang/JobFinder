using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service.AutoMapper
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyModel>();
            CreateMap<CompanyModel, Company>();
            CreateMap<CreateCompanyModel, Company>();
            CreateMap<Company, CreateCompanyResponseModel>();
            CreateMap<UpdateCompanyModel, Company>();
            CreateMap<Company, UpdateCompanyReponseModel>();
        }
    }
}

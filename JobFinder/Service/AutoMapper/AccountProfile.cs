using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service.AutoMapper
{
    public class AccountProfile : Profile
    {
       public AccountProfile()
        {
            CreateMap<Account, AccountModel>()
                .Include<Company, CompanyLoginResponseModel>()
                .Include<User, UserLoginResponseModel>();
            CreateMap<CreateAccountModel, Account>();
            CreateMap<Account, CreateAccountModelResponse>();
            CreateMap<Company, CompanyLoginResponseModel>();
            CreateMap<User, UserLoginResponseModel>();
        } 
    }
}

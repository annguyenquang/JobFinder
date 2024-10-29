using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Service.AutoMapper
{
    public class AccountProfile : Profile
    {
       public AccountProfile()
        {
            CreateMap<Account, AccountModel>();
            CreateMap<CreateAccountModel, Account>();
            CreateMap<Account, CreateAccountModelResponse>();
        } 
    }
}

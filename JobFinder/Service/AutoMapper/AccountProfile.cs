using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model.Account;

namespace JobFinder.Service.AutoMapper
{
    public class AccountProfile : Profile
    {
       public AccountProfile()
        {
            CreateMap<Account, AccountModel>();
        } 
    }
}

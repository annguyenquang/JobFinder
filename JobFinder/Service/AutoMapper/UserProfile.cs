using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Model.Account;

namespace JobFinder.Service.AutoMapper
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModel>();
        }
    }
}

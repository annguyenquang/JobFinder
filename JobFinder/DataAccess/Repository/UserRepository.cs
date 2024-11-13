using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace JobFinder.DataAccess.Repository
{
    public class UserRepository(DatabaseContext dbContext) : BaseRepository<User>(dbContext), IUserRepository
    {
        
    }
}
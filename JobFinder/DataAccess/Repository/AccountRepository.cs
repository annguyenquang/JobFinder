using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public class AccountRepository : BaseRepository<Account>,IAccountRepository
    {
        public AccountRepository(DatabaseContext _dbContext) : base(_dbContext)
        {

        }
    }
}

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

        public async Task<Account> GetAccountByUsername(string username)
        {
            var account = await DbSet.SingleOrDefaultAsync(x => x.Username == username);
            if(account == null)
            {
                throw new Exception("Account not found");
            }
            return account;
        }
    }
}

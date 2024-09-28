using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Repository.Persistent;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public class AccountRepository (DatabaseContext _dbContext) : IAccountRepository
    {
        public Account CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(Guid id)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(Guid id)
        {
            var entity = _dbContext.Accounts.FirstOrDefault(x => x.Id == id);
            return entity; 
        }

        public IEnumerable<Account> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public Account UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}

using JobFinder.Core.Entity;

namespace JobFinder.Core.Repository
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        public Task<Account> GetAccountByUsername(string username);
    }
}

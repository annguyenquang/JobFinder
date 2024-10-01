using JobFinder.Core.Entity;

namespace JobFinder.Core.Repository
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        Account GetAccount(Guid id);
        IEnumerable<Account> GetAccounts();
        Account CreateAccount(Account account);
        Account UpdateAccount(Account account);
        void DeleteAccount(Guid id);
    }
}

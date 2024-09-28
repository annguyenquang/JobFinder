using JobFinder.Core.Entity;
using JobFinder.Core.Repository;

namespace JobFinder.Service
{
    public class AccountService(IAccountRepository _accountRepository) : IAccountService
    {
        public Account GetAccount(Guid id)
        {
            return _accountRepository.GetAccount(id);
        }
    }
}

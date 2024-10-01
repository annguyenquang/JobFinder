using JobFinder.Core.Entity;
using JobFinder.Model.Account;

namespace JobFinder.Service
{
    public interface IAccountService
    {
        Task<AccountModel> GetAccount(Guid id);
    }
}

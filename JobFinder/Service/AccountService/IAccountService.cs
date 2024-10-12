using JobFinder.Model;

namespace JobFinder.Service
{
    public interface IAccountService
    {
        Task<AccountModel> GetAccount(Guid id);
    }
}

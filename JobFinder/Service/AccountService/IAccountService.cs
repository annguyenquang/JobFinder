using JobFinder.Model;

namespace JobFinder.Service
{
    public interface IAccountService
    {
        Task<AccountModel> GetAccount(Guid id);
        Task<AccountModel> GetAccountByUsername(string username);
        Task<AccountModel> Login(AuthAccountModel account);
        Task<CreateAccountModelResponse> CreateAccount(CreateAccountModel accountModel);
    }
}

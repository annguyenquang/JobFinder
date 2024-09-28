using JobFinder.Core.Entity;

namespace JobFinder.Service
{
    public interface IAccountService
    {
        Account GetAccount(Guid id);
    }
}

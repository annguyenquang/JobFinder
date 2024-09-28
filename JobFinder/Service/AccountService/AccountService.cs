using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model.Account;

namespace JobFinder.Service
{
    public class AccountService(IAccountRepository _accountRepository, IMapper _mapper) : IAccountService
    {
        public AccountModel GetAccount(Guid id)
        {

            var entity = _accountRepository.GetAccount(id);
            return _mapper.Map<AccountModel>(entity); 
        }
    }
}

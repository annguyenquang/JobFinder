using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;

namespace JobFinder.Service
{
    public class AccountService(IAccountRepository _accountRepository, IMapper _mapper) : IAccountService
    {
        public async Task<AccountModel> GetAccount(Guid id)
        {
            var entity = await _accountRepository.GetAsync(id);
            return _mapper.Map<AccountModel>(entity); 
        }
    }
}

using AutoMapper;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Core.Entity;
using BC = BCrypt.Net.BCrypt;

namespace JobFinder.Service
{
    public class AccountService(IAccountRepository _accountRepository, IMapper _mapper, IJwtService _jwtService) : IAccountService
    {
        public async Task<AccountModel> GetAccount(Guid id)
        {
            var entity = await _accountRepository.GetAsync(id);
            return _mapper.Map<AccountModel>(entity);
        }

        public async Task<AccountModel> GetAccountByUsername(string username)
        {
            var entity = await _accountRepository.GetAccountByUsername(username);
            return _mapper.Map<AccountModel>(entity);
        }

        public async Task<AccountModel> Login(AuthAccountModel account)
        {
            var accountEntity = await _accountRepository.GetAccountByUsername(account.Username);
            if (accountEntity != null)
            {
                bool isValidPassword = BC.Verify(account.Password, accountEntity.Password);
                if (isValidPassword)
                {
                    var res = _mapper.Map<AccountModel>(accountEntity);
                    res.AccessToken = _jwtService.GenerateTokenWithUsername(accountEntity.Username);
                    return res;
                }
                else
                {
                    throw new Exception("Invalid password");
                }
            }
            throw new Exception("Invalid Username");
        }

        public async Task<CreateAccountModelResponse> CreateAccount(CreateAccountModel accountModel)
        {
            bool isExistAccount = await _accountRepository.GetAccountByUsername(accountModel.Username) != null;
            if (isExistAccount)
            {
                throw new BadRequestException("Username already exist");
            }
           Account account = _mapper.Map<Account>(accountModel);
           account.Password = BC.HashPassword(accountModel.Password);
           var res =  await _accountRepository.AddAsync(account);
           return _mapper.Map<CreateAccountModelResponse>(res);
        }

    }
}

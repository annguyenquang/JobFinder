using System.Linq.Expressions;
using AutoMapper;
using JobFinder.Model;
using JobFinder.Core.Entity;
using JobFinder.DataAccess.Persistent;
using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;

namespace JobFinder.Service
{
    public class AccountService(DatabaseContext _dbContext, IMapper _mapper, IJwtService _jwtService) : IAccountService
    {
        DbSet<Account> _accountsDbSet = _dbContext.Accounts;
        public async Task<AccountModel> GetAccount(Guid id)
        {
            var entity = await _accountsDbSet.FindAsync(id);
            return _mapper.Map<AccountModel>(entity);
        }

        public async Task<AccountModel> GetAccountModelByUsername(string username)
        {
            var entity = await GetAccountByUsername(username);
            return _mapper.Map<AccountModel>(entity);
        }

        public async Task<AccountModel> Login(AuthAccountModel account)
        {
            var accountEntity = await GetAccountByUsername(account.Username);
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
            bool isExistAccount = await GetAccountByUsername(accountModel.Username) != null;
            if (isExistAccount)
            {
                throw new BadRequestException("Username already exist");
            }
           Account account = _mapper.Map<Account>(accountModel);
           account.Password = BC.HashPassword(accountModel.Password);
           var res =  await _accountsDbSet.AddAsync(account);
           return _mapper.Map<CreateAccountModelResponse>(res);
        }

        private async Task<Account?> GetAccountByUsername(string username)
        {
            var entity = await _accountsDbSet.SingleOrDefaultAsync(x => x.Username == username);
            return entity;
        }

    }
}

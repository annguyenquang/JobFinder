using AutoMapper;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BC = BCrypt.Net.BCrypt;

namespace JobFinder.Service
{
    public class AccountService(IAccountRepository _accountRepository, IMapper _mapper, IOptions<AppSettings> appSettings) : IAccountService
    {
        public async Task<AccountModel> GetAccount(Guid id)
        {
            var entity = await _accountRepository.GetAsync(id);
            return _mapper.Map<AccountModel>(entity);
        }
        public async Task<AccountModel> Login(AuthAccountModel account)
        {
            var accountEntity = await _accountRepository.GetAccountByUsername(account.Username);
            Console.WriteLine(BC.HashPassword(accountEntity.Password));
            if (accountEntity != null)
            {
                bool isValidPassword = BC.Verify(account.Password, accountEntity.Password);
                if (isValidPassword)
                {
                    var res = _mapper.Map<AccountModel>(accountEntity);
                    res.AccessToken = GenerateToken(res.Username);
                    return res;
                }
                else
                {
                    throw new Exception("Invalid password");
                }
            }
            throw new Exception("Invalid Username");
        }

        public string GenerateToken(string userName)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, userName)
            };
            var jwtToken = new JwtSecurityToken(
                claims: claims,
                notBefore: DateTime.UtcNow,
            expires: DateTime.UtcNow.AddDays(1),
            signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.Value.JwtSecretKey)),
                    SecurityAlgorithms.HmacSha256Signature
                )
                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}

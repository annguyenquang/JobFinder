using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils.Constants;
using JobFinder.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController (IAccountService _accountService) : ControllerBase
    {
        [HttpGet]
        [Authorize] 
        public async Task<ApiResult<AccountModel>> GetAccountByJwt()
        {
            var username = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(username))
            {
               throw new UnauthorizedAccessException("Missing JWT Token");
            }
            
            var account = await _accountService.GetAccountByUsername(username);
            return ApiResult<AccountModel>.Success(account);
        }
        
        [HttpGet]
        public async Task<ApiResult<AccountModel>> GetAccount(Guid id)
        {
            var account = await _accountService.GetAccount(id);
            return ApiResult<AccountModel>.Success(account);
        }
        [HttpPost]
        public async Task<ApiResult<AccountModel>> Login(AuthAccountModel account)
        {
            var res = await _accountService.Login(account);
            AddJwtHttpOnlyCookie(res.AccessToken);
            res.AccessToken = null;
            return ApiResult<AccountModel>.Success(res);
        }

        [HttpGet]
        [Authorize]
        public ApiResult<string> Logout()
        {
            var username = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(username))
            {
               throw new UnauthorizedAccessException("Missing JWT Token");
            }
            Response.Cookies.Delete(Authentication.JwtCookieKey);
            return ApiResult<string>.Success(username);
        }

        [HttpPost]
        public async Task<ApiResult<CreateAccountModelResponse>> CreateAccount([FromBody] CreateAccountModel accountModel)
        {
            var res = await _accountService.CreateAccount(accountModel);
            return ApiResult<CreateAccountModelResponse>.Success(res);
        }

        private void AddJwtHttpOnlyCookie(string accessToken)
        {
            
            var cookieOptions = new CookieOptions()
            {
                HttpOnly = true,
                Expires = DateTime.Now.AddDays(1),
                SameSite = SameSiteMode.None,
                Secure = true
            };
            Response.Cookies.Append(Authentication.JwtCookieKey, accessToken, cookieOptions);
        } 
    }
}

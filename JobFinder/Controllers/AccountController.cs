using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AccountController (IAccountService _accountService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<AccountModel>> GetAccount(Guid id)
        {
            var account = await _accountService.GetAccount(id);
            return ApiResult<AccountModel>.Success(account);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ApiResult<AccountModel>> Login(AuthAccountModel account)
        {
            var res = await _accountService.Login(account);
            return ApiResult<AccountModel>.Success(res);
        }
    }
}

using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController (IAccountService _accountService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<AccountModel>> GetAccount(Guid id)
        {
            var account = await _accountService.GetAccount(id);
            return ApiResult<AccountModel>.Success(account);
        }
    }
}

using JobFinder.Core.Entity;
using JobFinder.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController (IAccountService _accountService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAccount(Guid id)
        {
            var account = await _accountService.GetAccount(id);
            return Ok(account);
        }
    }
}

using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController (IUserService _userService) : ControllerBase
    {
        [HttpPost]
        [Authorize] 
        public async Task<ApiResult<UpdateUserResponseModel>> UpdateUser(Guid id, [FromBody] UpdateUserModel newUser)
        {
            var res = await _userService.UpdateUserById(id, newUser);
            return ApiResult<UpdateUserResponseModel>.Success(res);
        }
        
    }
}

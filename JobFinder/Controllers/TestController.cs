using JobFinder.Model;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class TestController : ControllerBase
{
    
    [HttpGet]
    public ApiResult<string> Test()
    {
        return ApiResult<string>.Success("Hello World");
    }
}
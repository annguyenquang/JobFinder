using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PositionApplicationController(IPositionApplicationService _positionApplicationService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<List<PositionApplication>>> GetAllPositionApplication()
        {
            var applications = await _positionApplicationService.GetAllPositionApplicationsAsync();
            return ApiResult<List<PositionApplication>>.Success(applications);
        }
    }
}

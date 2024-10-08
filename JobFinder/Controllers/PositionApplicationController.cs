using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

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
        [HttpPost]
        public async Task<ApiResult<CreatePositionApplicationReponseModel>> CreatePositionApplication([FromForm] CreatePositionApplicationModel newApplication)
        {
            var response = await _positionApplicationService.CreatePositionApplicationAsync(newApplication);
            return ApiResult<CreatePositionApplicationReponseModel>.Success(response);
        }
    }
}

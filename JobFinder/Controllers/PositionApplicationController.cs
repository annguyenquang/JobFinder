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
        public async Task<ApiResult<ListResponseModel<PositionApplicationModel>>> GetAllPositionApplication([FromQuery] GetAllPositionApplicationParams param)
        {
            var applications = await _positionApplicationService.GetAllPositionApplicationsAsync(param.Filter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<PositionApplicationModel>>.Success(applications);
        }
        [HttpPost]
        public async Task<ApiResult<CreatePositionApplicationReponseModel>> CreatePositionApplication([FromForm] CreatePositionApplicationModel newApplication)
        {
            var response = await _positionApplicationService.CreatePositionApplicationAsync(newApplication);
            return ApiResult<CreatePositionApplicationReponseModel>.Success(response);
        }
    }
}

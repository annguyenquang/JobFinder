
using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PositionController(IPositionService _positionService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<PositionModel>> GetPosition(Guid id)
        {
            var account = await _positionService.GetPositionAsync(id);
            return ApiResult<PositionModel>.Success(account);
        }
        [HttpGet]
        public async Task<ApiResult<ListResponseModel<PositionModel>>> GetPositionsByPagination([FromQuery] GetPositionsByPaginationParams param)
        {
            var positions = await _positionService.GetAllPositionAsync(param.PositionFilter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<PositionModel>>.Success(positions);
        } 
        [HttpPost]
        public async Task<ApiResult<CreatePositionReponseModel>> CreatePosition(CreatePositionModel position)
        {
            var response = await _positionService.CreatePositionAsync(position);
            return ApiResult<CreatePositionReponseModel>.Success(response);
        }
        [HttpPatch("{id}")]
        public async Task<ApiResult<UpdatePositionReponseModel>> UpdatePosition(Guid id, [FromBody] UpdatePositionModel newPositionModel)
        {
            var response = await _positionService.UpdatePositionAsync(id, newPositionModel);
            return ApiResult<UpdatePositionReponseModel>.Success(response);
        }

    }
}

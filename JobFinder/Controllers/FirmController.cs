
using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FirmController(IFirmService _firmService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<FirmModel>> GetFirm(Guid id)
        {
            var account = await _firmService.GetFirmAsync(id);
            return ApiResult<FirmModel>.Success(account);
        }
        [HttpGet]
        public async Task<ApiResult<ListResponseModel<FirmModel>>> GetFirmsByPagination([FromQuery] GetFirmsByPaginationParams param)
        {
            var firms = await _firmService.GetAllFirmAsync(param.Filter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<FirmModel>>.Success(firms);
        } 
        [HttpGet("{id}/positions")]
        public async Task<ApiResult<IEnumerable<PositionModel>>> GetFirmPositions(Guid id, [FromQuery] GetFirmPositionsParams param)
        {
            var positions = await _firmService.GetFirmPositions(id, param.Filter, param.Order, param.Pagination);
            return ApiResult<IEnumerable<PositionModel>>.Success(positions);
        } 
        [HttpPost]
        public async Task<ApiResult<CreateFirmResponseModel>> CreateFirm(CreateFirmModel Firm)
        {
            var response = await _firmService.CreateFirmAsync(Firm);
            return ApiResult<CreateFirmResponseModel>.Success(response);
        }
        [HttpPatch("{id}")]
        public async Task<ApiResult<UpdateFirmReponseModel>> UpdateFirm(Guid id, [FromBody] UpdateFirmModel newFirmModel)
        {
            var response = await _firmService.UpdateFirmAsync(id, newFirmModel);
            return ApiResult<UpdateFirmReponseModel>.Success(response);
        }
    }
}

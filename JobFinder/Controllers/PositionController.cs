
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching.Filters;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PositionController(IPositionService _positionService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPosition(Guid id)
        {
            var account = await _positionService.GetPositionAsync(id);
            return Ok(account);
        }
        [HttpGet]
        public async Task<IActionResult> GetPositionsByPagination([FromQuery] GetPositionsByPaginationParams param)
        {
            var positions = await _positionService.GetAllPositionAsync(param.PositionFilter, param.Order, param.Pagination);
            return Ok(positions);
        } 
        [HttpPost]
        public async Task<IActionResult> CreatePosition(CreatePositionModel position)
        {
            var response = await _positionService.CreatePositionAsync(position);
            return Ok(response);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdatePosition(Guid id, [FromBody] UpdatePositionModel newPositionModel)
        {
            var response = await _positionService.UpdatePositionAsync(id, newPositionModel);
            return Ok(response);
        }

    }
}

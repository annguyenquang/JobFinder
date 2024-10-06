
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
        public async Task<IActionResult> GetFirm(Guid id)
        {
            var account = await _firmService.GetFirmAsync(id);
            return Ok(account);
        }
        [HttpGet]
        public async Task<IActionResult> GetFirmsByPagination([FromQuery] GetFirmsByPaginationParams param)
        {
            var firms = await _firmService.GetAllFirmAsync(param.Filter, param.Order, param.Pagination);
            return Ok(firms);
        } 
        [HttpGet("{id}/positions")]
        public async Task<IActionResult> GetFirmPositions(Guid id, [FromQuery] GetFirmPositionsParams param)
        {
            var positions = await _firmService.GetPositions(id, param.Filter, param.Order, param.Pagination);
            return Ok(positions);
        } 
        [HttpPost]
        public async Task<IActionResult> CreateFirm(CreateFirmModel Firm)
        {
            var response = await _firmService.CreateFirmAsync(Firm);
            return Ok(response);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateFirm(Guid id, [FromBody] UpdateFirmModel newFirmModel)
        {
            var response = await _firmService.UpdateFirmAsync(id, newFirmModel);
            return Ok(response);
        }
    }
}

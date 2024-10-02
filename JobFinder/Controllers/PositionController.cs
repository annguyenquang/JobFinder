
using JobFinder.Model;
using JobFinder.Model.Position;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PositionController(IPositionService _positionService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAccount(Guid id)
        {
            var account = await _positionService.GetPositionAsync(id);
            return Ok(account);
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
            var response = await _positionService.UpdatePositionAsync1(id, newPositionModel);
            return Ok(response);
        }
    }
}

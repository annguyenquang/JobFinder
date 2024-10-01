
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController(IPositionService _positionService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAccount(Guid id)
        {
            var account = await _positionService.GetPosition(id);
            return Ok(account);
        }
    }
}

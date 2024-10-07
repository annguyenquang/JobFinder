using JobFinder.Service.StorageService;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StorageController(IStorageService _storageService): ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var response = await _storageService.UploadFile(file);
            return Ok(response);
        }
    }
}

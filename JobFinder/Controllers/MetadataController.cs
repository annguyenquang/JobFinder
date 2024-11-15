using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MetadataController(IMetadataService _metadataService, IJobSuggestionService _jobSuggestionService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<ListResponseModel<MetadataModel>>> GetMetadataByPagination([FromQuery] GetMetadataByPaginationParams param)
        {
            _jobSuggestionService.GetJobSuggestionWithExplanation(new UserModel(), new List<JobModel>());
            var metadataListResponseModel = await _metadataService.GetAllMetadataAsync(param.Filter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<MetadataModel>>.Success(metadataListResponseModel);
        }
    }
}

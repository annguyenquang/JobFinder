
using JobFinder.Model;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JobController(IJobService _jobService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<JobModel>> GetJob(Guid id)
        {
            var account = await _jobService.GetJobAsync(id);
            return ApiResult<JobModel>.Success(account);
        }
        [HttpGet]
        public async Task<ApiResult<ListResponseModel<JobModel>>> GetJobsByPagination([FromQuery] GetJobsByPaginationParams param)
        {
            var positions = await _jobService.GetAllJobAsync(param.JobFilter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<JobModel>>.Success(positions);
        } 
        [HttpPost]
        public async Task<ApiResult<CreateJobReponseModel>> CreateJob(CreateJobModel position)
        {
            var response = await _jobService.CreateJobAsync(position);
            return ApiResult<CreateJobReponseModel>.Success(response);
        }
        [HttpPatch("{id}")]
        public async Task<ApiResult<UpdateJobReponseModel>> UpdateJob(Guid id, [FromBody] UpdateJobModel newJobModel)
        {
            var response = await _jobService.UpdateJobAsync(id, newJobModel);
            return ApiResult<UpdateJobReponseModel>.Success(response);
        }

    }
}

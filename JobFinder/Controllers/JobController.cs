
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JobController(IJobService _jobService, IJobSuggestionService _jobSuggestionService) : ControllerBase
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
            var jobs = await _jobService.GetAllJobAsync(param.JobFilter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<JobModel>>.Success(jobs);
        }
        [HttpPost]
        public async Task<ApiResult<CreateJobReponseModel>> CreateJob(CreateJobModel position)
        {
            var response = await _jobService.CreateJobAsync(position);
            return ApiResult<CreateJobReponseModel>.Success(response);
        }
        [HttpPatch("{id}")]
        public async Task<ApiResult<UpdateJobResponseModel>> UpdateJob(Guid id, [FromBody] UpdateJobModel newJobModel)
        {
            var response = await _jobService.UpdateJobAsync(id, newJobModel);
            return ApiResult<UpdateJobResponseModel>.Success(response);
        }

        [HttpGet]
        public async Task<ApiResult<JobSuggestionList>> GetSuggestionByLatestSearchKeyword([FromQuery] SuggestibleUserModel user,
            [FromQuery] GetJobsByPaginationParams param)
        {
            var defaultPagination = new Pagination { Page = 1, PageSize = 999 };
            param.Pagination ??= defaultPagination;
            var response = await _jobSuggestionService.GenerateJobSuggestionListAsync(user, param);
            return ApiResult<JobSuggestionList>.Success(response);
        }
        [HttpGet]
        public async Task<ApiResult<JobSuggestionList>> GetRelativeJobByJobId([FromQuery] Guid jobId,
            [FromQuery] GetJobsByPaginationParams param)
        {
            var defaultPagination = new Pagination { Page = 1, PageSize = -1 };
            param.Pagination ??= defaultPagination;
            var response = await _jobSuggestionService.GenerateRelativeJobSuggestionListAsync(jobId, param);
            return ApiResult<JobSuggestionList>.Success(response);
        }
    }
}

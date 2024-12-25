using JobFinder.Model;
using JobFinder.Model.Enums;
using JobFinder.Model.Utils.Fetching.Filters;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobFinder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JobApplicationController(IJobApplicationService _jobApplicationService) : ControllerBase
    {
        [HttpGet]
        public async Task<ApiResult<ListResponseModel<JobApplicationModel>>> GetAllJobApplication([FromQuery] GetAllJobApplicationParams param)
        {
            var applications = await _jobApplicationService.GetAllJobApplicationsAsync(param.Filter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<JobApplicationModel>>.Success(applications);
        }

        [HttpGet]
        public async Task<ApiResult<ListResponseModel<UserApplication>>> GetJobApplicationByUserId([FromQuery] Guid userId, [FromQuery] GetJobApplicationByUserIdParam param)
        {
            param.Filter ??= new GetJobApplicationByUserIdFilter(); 
            param.Filter.UserId = userId;
            
            var applications = await _jobApplicationService.GetApplicationsByUserId(userId, param);
            return ApiResult<ListResponseModel<UserApplication>>.Success(applications);
        }

        [HttpGet]
        public async Task<ApiResult<ListResponseModel<JobApplicationModel>>> GetJobApplicationByJobId([FromQuery] Guid jobId, [FromQuery] GetJobApplicationByJobIdParam param)
        {
            param.Filter ??= new GetJobApplicationByJobIdFilter(); 
            param.Filter.JobId = jobId;
            
            var applications = await _jobApplicationService.GetAllJobApplicationsAsync(param.Filter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<JobApplicationModel>>.Success(applications);
        }
        
        [HttpPost]
        public async Task<ApiResult<CreateJobApplicationResponseModel>> CreateJobApplication([FromForm] CreateJobApplicationModel newApplication)
        {
            var response = await _jobApplicationService.CreateJobApplicationAsync(newApplication);
            return ApiResult<CreateJobApplicationResponseModel>.Success(response);
        }

        [HttpPatch]
        public async Task<ApiResult<Guid>> UpdateJobApplicationState(
            UpdateJobApplicationModelParam param)
        {
            if (!Enum.IsDefined(typeof(JobApplicationState), param.State))
            {
                throw new BadRequestException("Invalid job application state.");
            }
            var updatedStateJobApplication = new UpdateJobApplicationModel() { State = param.State };
            var res = await _jobApplicationService.UpdateJobApplicationAsync(param.JobApplicationId, updatedStateJobApplication);
            return ApiResult<Guid>.Success(res);
        }
        
    }
}

using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;
using JobFinder.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

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
        public async Task<ApiResult<ListResponseModel<JobApplicationModel>>> GetJobApplicationByUserId([FromQuery] Guid userId, [FromQuery] GetJobApplicationByUserIdParam param)
        {
            param.Filter ??= new GetJobApplicationByUserIdFilter(); 
            param.Filter.UserId = userId;
            
            var applications = await _jobApplicationService.GetAllJobApplicationsAsync(param.Filter, param.Order, param.Pagination);
            return ApiResult<ListResponseModel<JobApplicationModel>>.Success(applications);
        }
        
        [HttpPost]
        public async Task<ApiResult<CreateJobApplicationResponseModel>> CreateJobApplication([FromForm] CreateJobApplicationModel newApplication)
        {
            var response = await _jobApplicationService.CreateJobApplicationAsync(newApplication);
            return ApiResult<CreateJobApplicationResponseModel>.Success(response);
        }

    }
}

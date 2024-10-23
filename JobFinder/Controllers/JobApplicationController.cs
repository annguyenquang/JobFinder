using JobFinder.Model;
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
        [HttpPost]
        public async Task<ApiResult<CreateJobApplicationReponseModel>> CreateJobApplication([FromForm] CreateJobApplicationModel newApplication)
        {
            var response = await _jobApplicationService.CreateJobApplicationAsync(newApplication);
            return ApiResult<CreateJobApplicationReponseModel>.Success(response);
        }
    }
}

using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public interface IJobApplicationService
    {
        Task<ListResponseModel<JobApplicationModel>> GetAllJobApplicationsAsync(JobApplicationFilter filter, Order order, Pagination pagination);
        Task<ListResponseModel<UserApplication>> GetApplicationsByUserId(Guid userId, GetJobApplicationByUserIdParam param);
        Task<CreateJobApplicationResponseModel> CreateJobApplicationAsync(CreateJobApplicationModel newApplication);
        Task<Guid> UpdateJobApplicationAsync(Guid id, UpdateJobApplicationModel jobApplication);
    }
}

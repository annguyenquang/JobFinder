using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public interface IJobApplicationService
    {
        Task<ListResponseModel<JobApplicationModel>> GetAllJobApplicationsAsync(JobApplicationFilter fitler, Order order, Pagination pagination);
        Task<CreateJobApplicationResponseModel> CreateJobApplicationAsync(CreateJobApplicationModel newApplication);
    }
}

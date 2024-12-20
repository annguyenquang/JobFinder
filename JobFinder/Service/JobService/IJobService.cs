using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public interface IJobService
    {
        Task<JobModel> GetJobAsync(Guid id);
        Task<ListResponseModel<JobModel>> GetAllJobAsync(JobFilter filter, Order order, Pagination pagination);
        Task<CreateJobReponseModel> CreateJobAsync(CreateJobModel job);
        Task<UpdateJobResponseModel> UpdateJobAsync(Guid id, UpdateJobModel jobModel);
    }
}
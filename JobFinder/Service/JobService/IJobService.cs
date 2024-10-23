using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Service
{
    public interface IJobService
    {
        Task<JobModel> GetJobAsync(Guid id);
        Task<ListResponseModel<JobModel>> GetAllJobAsync(JobFilter filer, Order order, Pagination pagination);
        Task<CreateJobReponseModel> CreateJobAsync(CreateJobModel job);
        Task<UpdateJobReponseModel> UpdateJobAsync(Guid id, UpdateJobModel jobModel);
    }
}
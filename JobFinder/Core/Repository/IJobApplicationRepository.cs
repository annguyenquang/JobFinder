using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Core.Repository
{
    public interface IJobApplicationRepository : IBaseRepository<JobApplication>
    {
        public new Task<List<JobApplication>> GetAllAsync(IFilter<JobApplication> filter, Order order,
            Pagination pagination);
    }
}

using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Core.Repository
{
    public interface IJobRepository : IBaseRepository<Job>
    {
        new Task<ListModel<Job>> GetAllAsListModelAsync(IFilter<Job> filter, Order order, Pagination pagination);
        new Task<Job> GetAsync(Guid id);
        Task<Job> UpdateAsync(Guid id, Job newJob);
    }
}

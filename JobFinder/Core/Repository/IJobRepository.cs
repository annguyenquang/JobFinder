using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Core.Repository
{
    public interface IJobRepository : IBaseRepository<Job>
    {
        public new Task<ListModel<Job>> GetAllAsListModelAsync(IFilter<Job> filter, Order order, Pagination pagination);
        Task<Job> UpdateAsync(Guid id, Job newJob);
    }
}

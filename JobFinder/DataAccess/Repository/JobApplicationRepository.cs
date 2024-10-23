using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public class JobApplicationRepository : BaseRepository<JobApplication>, IJobApplicationRepository
    {
        public JobApplicationRepository(DatabaseContext context) : base(context)
        {
        }
        public new Task<List<JobApplication>> GetAllAsync(IFilter<JobApplication> filter, Order order, Pagination pagination)
        {
            var queryable = DbSet
                    .Include(x => x.User)
                    .Include(x => x.Job)
                    .AsQueryable();
            if(filter != null)
            {
                queryable = filter.filters(queryable);
            }
            if (order != null)
            {
                queryable = Order.ApplyOrdering(queryable, order.By, order.IsDesc);
            }
            if(pagination != null)
            {
                queryable = queryable.Skip(pagination.PageSize * (pagination.Page - 1)).Take(pagination.PageSize);
            }
            return queryable.ToListAsync();
        }
    }
}

using Azure.Storage.Blobs.Models;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public class PositionApplicationRepository : BaseRepository<PositionApplication>, IPositionApplicationRepository
    {
        public PositionApplicationRepository(DatabaseContext context) : base(context)
        {
        }
        public new Task<List<PositionApplication>> GetAllAsync(IFilter<PositionApplication> filter, Order order, Pagination pagination)
        {
            var queryable = DbSet
                    .Include(x => x.User)
                    .Include(x => x.Position)
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

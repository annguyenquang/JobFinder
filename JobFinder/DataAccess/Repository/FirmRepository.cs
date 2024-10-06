
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Linq;
using System.Reflection;

namespace JobFinder.DataAccess.Repository
{
    public class FirmRepository : BaseRepository<Firm>, IFirmRepository
    {
        public FirmRepository(DatabaseContext _dbContext) : base(_dbContext)
        {
        }
        public async Task<List<Position>> GetFirmPositions(Guid firmId, PositionFilter filter, Order order, Pagination pagination)
        {
            IQueryable<Firm> queryableFirm = DbSet
                .Include(x => x.Positions)
                .AsQueryable();
            queryableFirm = queryableFirm.Where(x => x.Id == firmId);

            var queryablePosition = queryableFirm.SelectMany(x => x.Positions);
            
            if (filter != null)
            {
                queryablePosition = filter.filters(queryablePosition);
            }
            if (order != null)
            {
                queryablePosition = Order.ApplyOrdering(queryablePosition, order.By, order.IsDesc);
            }
            if (pagination != null)
            {
                int skip = pagination.PageSize * (pagination.Page - 1);
                int take = pagination.PageSize;
                queryablePosition = queryablePosition.Skip(skip).Take(take);
            }


            return await queryablePosition.ToListAsync();
        }
    }
}

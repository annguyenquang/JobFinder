using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace JobFinder.DataAccess.Repository
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(DatabaseContext _dbContext) : base(_dbContext)
        {
        }
        public async Task<ListModel<Position>> GetCompanyPositions(Guid companyId, PositionFilter filter, Order order, Pagination pagination)
        {
            IQueryable<Company> queryableCompany = DbSet
                .Include(x => x.Positions)
                .AsQueryable();
            queryableCompany = queryableCompany.Where(x => x.Id == companyId);

            var queryablePosition = queryableCompany.SelectMany(x => x.Positions);
            
            if (filter != null)
            {
                queryablePosition = filter.filters(queryablePosition);
            }
            if (order != null)
            {
                queryablePosition = Order.ApplyOrdering(queryablePosition, order.By, order.IsDesc);
            }
            int total = await queryablePosition.CountAsync();
            if (pagination != null)
            {
                int skip = pagination.PageSize * (pagination.Page - 1);
                int take = pagination.PageSize;
                queryablePosition = queryablePosition.Skip(skip).Take(take);
            }

            var result = new ListModel<Position>
            {
                Data = await queryablePosition.ToListAsync(),
                Total = total,
            };

            return result;
        }
    }
}

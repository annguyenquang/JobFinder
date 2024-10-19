using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace JobFinder.DataAccess.Repository
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository(DatabaseContext _dbContext) : base(_dbContext)
        {
        }
        
        public new async Task<ListModel<Position>> GetAllAsListModelAsync(IFilter<Position> filter, Order order, Pagination pagination)
        {
            var queryable = DbSet
                .Include(x => x.WorkArrangement) 
                .Include(x => x.CommitmentType) 
                .Include(x => x.WorkExperienceRequirement) 
                .Include(x => x.EducationLevelRequirement) 
                .Include(x => x.GenderRequirement) 
                .AsQueryable();
            if (filter != null)
            {
                queryable = filter.filters(queryable);
            }
            if(order != null)
            {
                queryable = Order.ApplyOrdering(queryable, order.By, order.IsDesc);                
            }
            int total = queryable.Count();
            if (pagination != null)
            {
                int skip = pagination.PageSize * (pagination.Page - 1);
                int take = pagination.PageSize;
                queryable = queryable.Skip(skip).Take(take);
            }
            var entityList = await queryable.ToListAsync();
            return new ListModel<Position>() { Data = entityList, Total = total };

        }

        public async Task<Position> UpdateAsync(Guid id, Position newPosition)
        {
            var currentPosition = await GetAsync(id);
            if (currentPosition == null)
            {
                throw new Exception("The id does not match any");
            }
            List<PropertyInfo> properties = [.. typeof(Position).GetProperties()];
            // Filter out the unchangeable properties
            properties = properties.Where(p =>
                    p.Name != nameof(Position.Id)
                    && p.Name != nameof(Position.CompanyId)
                    && p.Name != nameof(Position.Company)
                    ).ToList();
            foreach (PropertyInfo property in properties)
            {
                var newValue = property.GetValue(newPosition);
                var currentValue = property.GetValue(currentPosition);
                if (property.Name == nameof(Position.Title))
                {
                }
                if (newValue != null && newValue != currentValue)
                {
                    property.SetValue(currentPosition, newValue);
                }
            }
            int result = await Context.SaveChangesAsync();
            return currentPosition;
        }
    }
}

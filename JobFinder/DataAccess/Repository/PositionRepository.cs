
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection;

namespace JobFinder.DataAccess.Repository
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository(DatabaseContext _dbContext) : base(_dbContext)
        {
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
                    && p.Name != nameof(Position.FirmId)
                    && p.Name != nameof(Position.Firm)
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

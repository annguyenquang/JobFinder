using JobFinder.Core.Entity;
using JobFinder.Model.Utils.Fetching.Filter;

namespace JobFinder.Core.Repository
{
    public interface IPositionRepository : IBaseRepository<Position>
    {
        Task<Position> UpdateAsync(Guid id, Position newPosition);
    }
}

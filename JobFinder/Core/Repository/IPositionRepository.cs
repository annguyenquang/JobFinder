using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Core.Repository
{
    public interface IPositionRepository : IBaseRepository<Position>
    {
        public new Task<ListModel<Position>> GetAllAsListModelAsync(IFilter<Position> filter, Order order, Pagination pagination);
        Task<Position> UpdateAsync(Guid id, Position newPosition);
    }
}

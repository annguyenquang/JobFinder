using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Core.Repository
{
    public interface IFirmRepository : IBaseRepository<Firm>
    {
        Task<List<Position>> GetFirmPositions(Guid firmId, PositionFilter filter, Order order, Pagination pagination);
    }
}

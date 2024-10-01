using JobFinder.Core.Entity;

namespace JobFinder.Core.Repository
{
    public interface IPositionRepository
    {
        Task<Position> GetPosition(Guid id);
        Task<IEnumerable<Position>> GetPositions();
        Task<Position> CreatePosition(Position position);
        Task<Position> UpdatePosition(Position position);
        void DeletePosition(Guid id);
    }
}

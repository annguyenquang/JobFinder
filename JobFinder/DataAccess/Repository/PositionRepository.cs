
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public class PositionRepository(DatabaseContext _dbContext) : IPositionRepository
    {
        public Task<Position> CreatePosition(Position position)
        {
            throw new NotImplementedException();
        }

        public void DeletePosition(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Position> GetPosition(Guid id)
        {
            var entity = _dbContext.Positions.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public Task<IEnumerable<Position>> GetPositions()
        {
            throw new NotImplementedException();
        }

        public Task<Position> UpdatePosition(Position position)
        {
            throw new NotImplementedException();
        }
    }
}

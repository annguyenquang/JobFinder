
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public class PositionRepository: BaseRepository<Position> ,IPositionRepository
    {
        public PositionRepository(DatabaseContext _dbContext) : base(_dbContext)
        {
        }
    }
}

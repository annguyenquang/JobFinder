using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;

namespace JobFinder.DataAccess.Repository
{
    public class PositionApplicationRepository : BaseRepository<PositionApplication>, IPositionApplicationRepository
    {
        public PositionApplicationRepository(DatabaseContext context) : base(context)
        {
        }


    }
}

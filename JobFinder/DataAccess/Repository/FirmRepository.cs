
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using System.Reflection;

namespace JobFinder.DataAccess.Repository
{
    public class FirmRepository : BaseRepository<Firm>, IFirmRepository
    {
        public FirmRepository(DatabaseContext _dbContext) : base(_dbContext)
        {
        }
    }
}

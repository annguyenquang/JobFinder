using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository
{
    public class MetadataRepository : BaseRepository<Metadata>, IMetadataRepository
    {
        public MetadataRepository(DatabaseContext context) : base(context)
        {
        }


        public async Task<List<Metadata>> GetMetadatasByType(MetadataType type)
        {
            return await DbSet.Where(x => x.Type == type).ToListAsync();
        }
    }
}

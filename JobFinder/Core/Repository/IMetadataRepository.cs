using JobFinder.Core.Entity;
using JobFinder.Model;

namespace JobFinder.Core.Repository
{
    public interface IMetadataRepository: IBaseRepository<Metadata>
    {
        public Task<List<Metadata>> GetMetadatasByType(MetadataType type);
    }
}

using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;

namespace JobFinder.Service;

public interface IMetadataService
{
    public Task<Metadata> GetMetadataAsync(Guid id);
}
public class MetadataService (IMetadataRepository _metadataRepo, IMapper _mapper): IMetadataService
{
    public async Task<Metadata> GetMetadataAsync(Guid id)
    {
        var metadata = await _metadataRepo.GetAsync(id);
        return metadata;
    }
}

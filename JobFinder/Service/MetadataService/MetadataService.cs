using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Service;

public interface IMetadataService
{
    public Task<Metadata> GetMetadataAsync(Guid id);
    public Task<ListResponseModel<MetadataModel>> GetAllMetadataAsync(IFilter<Metadata> filter, Order order, Pagination pagination);
}
public class MetadataService(IMetadataRepository _metadataRepo, IMapper _mapper) : IMetadataService
{
    public async Task<ListResponseModel<MetadataModel>> GetAllMetadataAsync(IFilter<Metadata> filter, Order order, Pagination pagination)
    {
        var metadataListResponseModel = await _metadataRepo.GetAllAsListModelAsync(filter, order, pagination);
        var metadataModels = _mapper.Map<List<MetadataModel>>(metadataListResponseModel.Data);
        return new ListResponseModel<MetadataModel>()
        {
            Data = metadataModels,
            Total = metadataListResponseModel.Total,
            Pagination = pagination
        };
    }

    public async Task<Metadata> GetMetadataAsync(Guid id)
    {
        var metadata = await _metadataRepo.GetAsync(id);
        return metadata;
    }
}

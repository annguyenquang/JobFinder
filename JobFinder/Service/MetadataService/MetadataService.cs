using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.DataAccess.Persistent;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Service;

public interface IMetadataService
{
    public Task<Metadata> GetMetadataAsync(Guid id);
    public Task<ListResponseModel<MetadataModel>> GetAllMetadataAsync(IFilter<Metadata> filter, Order order, Pagination pagination);
}
public class MetadataService(DatabaseContext databaseContext, IMapper mapper) : IMetadataService
{
    private readonly DbSet<Metadata> _metadataDbSet = databaseContext.Metadatas;
    public async Task<ListResponseModel<MetadataModel>> GetAllMetadataAsync(IFilter<Metadata> filter, Order order, Pagination pagination)
    {
        var entities = await filter.filters(_metadataDbSet
            .AsQueryable())
            .Skip(pagination.Page * pagination.PageSize - 1)
            .Take(pagination.PageSize)
            .ToListAsync();
        var total = await filter.filters(_metadataDbSet
            .AsQueryable()).CountAsync(); 
        return new ListResponseModel<MetadataModel>()
        {
            Data = mapper.Map<List<MetadataModel>>(entities),
            Total = total,
            Pagination = pagination
        };
    }

    public async Task<Metadata> GetMetadataAsync(Guid id)
    {
        var metadata = await _metadataDbSet.FindAsync(id);
        return metadata;
    }
}

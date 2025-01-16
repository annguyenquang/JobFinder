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

    public Task<ListResponseModel<MetadataModel>> GetAllMetadataAsync(IFilter<Metadata> filter, Order order,
        Pagination pagination);
}

public class MetadataService(IDbContextFactory<DatabaseContext> _dbContextFactory, IMapper mapper) : IMetadataService
{
    public async Task<ListResponseModel<MetadataModel>> GetAllMetadataAsync(IFilter<Metadata> filter, Order order,
        Pagination pagination)
    {
        Task<int> getCountTask;
        Task<List<Metadata>> fetchMetadataTask;

        await using (var countContext = await _dbContextFactory.CreateDbContextAsync())
        await using (var fetchContext = await _dbContextFactory.CreateDbContextAsync())
        {
            getCountTask = filter != null ? 
                filter.filters(countContext.Metadatas).CountAsync()
                : countContext.Metadatas.CountAsync();
            var fetchQuery = fetchContext.Metadatas.AsQueryable();
            if (filter != null)
            {
                fetchQuery = filter.filters(fetchQuery);
            }

            if (order != null)
            {
                fetchQuery = Order.ApplyOrdering(fetchQuery, order.By, order.IsDesc);
            }

            if (pagination != null)
            {
                fetchQuery = fetchQuery.Skip(pagination.PageSize * (pagination.Page - 1))
                    .Take(pagination.PageSize);
            }
            
            fetchMetadataTask = fetchQuery.ToListAsync();
            await Task.WhenAll(getCountTask, fetchMetadataTask);
        }

        return new ListResponseModel<MetadataModel>()
        {
            Data = mapper.Map<List<MetadataModel>>(fetchMetadataTask.Result),
            Total = getCountTask.Result,
            Pagination = pagination
        };
    }

    public async Task<Metadata> GetMetadataAsync(Guid id)
    {
        using (var dbContext = await _dbContextFactory.CreateDbContextAsync())
        {
            
            var metadata = await dbContext.Metadatas.FindAsync(id);
            return metadata;
        }
             
    }
}
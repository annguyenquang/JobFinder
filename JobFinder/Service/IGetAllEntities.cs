using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Service;

public interface IGetAllEntities<T> where T : IBaseEntity
{
    public Task<ListModel<T>> GetAllEntities(IFilter<T> filter, Order order, Pagination pagination);
}
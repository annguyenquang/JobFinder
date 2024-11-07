using JobFinder.Core.Entity;
using JobFinder.Model;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using System.Linq.Expressions;

namespace JobFinder.Core.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
    {
        Task<TEntity> GetAsync(Guid id);

        Task<int> AddRangeAsync(IEnumerable<TEntity> entities);
        Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> predicate);

        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        Task<ListModel<TEntity>> GetAllAsListModelAsync(IFilter<TEntity> filer, Order order, Pagination pagination);
        Task<List<TEntity>> GetAllAsync(IFilter<TEntity> filer, Order order, Pagination pagination); 
        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> UpdateOnlyChangedProperties(Guid id, TEntity entity);

        Task<TEntity> DeleteAsync(TEntity entity);

        Task<List<TEntity>> GetByPagination(int skip, int limit, Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null);
    }
}
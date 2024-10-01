using JobFinder.Core.Entity;
using JobFinder.Core.Repository;
using JobFinder.DataAccess.Persistent;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JobFinder.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DatabaseContext Context;
        protected readonly DbSet<TEntity> DbSet;
        const int LIMIT = 50;
        protected BaseRepository(DatabaseContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            var result = await DbSet.FindAsync(id);
            if (result == null) throw new Exception($"Resouce of type {typeof(TEntity)} is not folder");
            return result;
        }


        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var addedEntity = (await DbSet.AddAsync(entity)).Entity;
            await Context.SaveChangesAsync();

            return addedEntity;
        }

        public async Task<int> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await DbSet.AddRangeAsync(entities);
            var count = await Context.SaveChangesAsync();
            return count;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            var removedEntity = DbSet.Remove(entity).Entity;
            await Context.SaveChangesAsync();

            return removedEntity;
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
        {
            var queryable = DbSet.AsQueryable();
            if (predicate != null)
            {
                queryable = queryable.Where(predicate);
            }

            orderBy?.Invoke(queryable);

            return await queryable.ToListAsync();
        }

        public async Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = await DbSet.Where(predicate).FirstOrDefaultAsync();

            if (entity == null) throw new ResourceNotFoundException(typeof(TEntity));

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<List<TEntity>> GetByPagination(int skip, int limit, Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
        {
            var queryable = DbSet.AsQueryable();
            if (predicate != null)
            {
                queryable = queryable.Where(predicate);
            }
            if (orderBy != null)
            {
                queryable = orderBy?.Invoke(queryable);
            }
            if (queryable != null)
            {
                queryable = queryable.Skip(skip).Take(limit);
            }

            return await queryable.ToListAsync();
        }
    }
}

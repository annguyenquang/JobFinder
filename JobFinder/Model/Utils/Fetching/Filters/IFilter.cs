using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils
{
    public interface IFilter<T> where T : BaseEntity
    {
        public abstract IQueryable<T> filters(IQueryable<T> queryable);
    }
}

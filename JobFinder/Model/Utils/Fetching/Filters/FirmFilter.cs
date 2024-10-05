using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils
{
    public class FirmFilter : IFilter<Firm>
    {
        public IQueryable<Firm> filters(IQueryable<Firm> queryable)
        {
            throw new NotImplementedException();
        }
    }
}

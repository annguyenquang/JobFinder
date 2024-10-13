using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils
{
    public class CompanyFilter : IFilter<Company>
    {
        public IQueryable<Company> filters(IQueryable<Company> queryable)
        {
            throw new NotImplementedException();
        }
    }
}

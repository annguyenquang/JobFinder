using JobFinder.Core.Entity;
using JobFinder.Model.Utils.Fetching.Filter;

namespace JobFinder.Model.Utils.Fetching.Filters
{
    public class PositionFilter : IFilter<Position>
    {
        public double FromSalary { get; set; }
        public double ToSalary { get; set; }
        public IQueryable<Position> filters(IQueryable<Position> querable)
        {
            if (FromSalary != 0)
            {
                querable = querable.Where(x => x.Salary >= FromSalary);
            }
            if(ToSalary != 0)
            {
                querable = querable.Where(x => x.Salary <= ToSalary);
            }
            return querable;
        }
    }
}

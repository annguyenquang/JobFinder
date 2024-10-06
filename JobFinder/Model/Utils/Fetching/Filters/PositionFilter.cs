using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils.Fetching.Filters
{
    public class PositionFilter : IFilter<Position>
    {
        public double FromSalary { get; set; }
        public double ToSalary { get; set; }
        public PositionStatus? Status { get; set; }
        public bool IsNotEnded { get; set; } = true;
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
            if(Status != null)
            {
                querable = querable.Where(x => x.Status == Status);
            }
            if(IsNotEnded)
            {
                querable = querable.Where(x => x.CloseDate >= DateTime.Now);
            }
            return querable;
        }
    }
}

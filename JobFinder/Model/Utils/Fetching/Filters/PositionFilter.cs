using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils.Fetching.Filters
{
    public class PositionFilter : IFilter<Position>
    {
        public double? FromSalary { get; set; }
        public double? ToSalary { get; set; }
        public PositionStatus? Status { get; set; }
        public bool? IsNotEnded { get; set; }
        public IQueryable<Position> filters(IQueryable<Position> querable)
        {
            if (FromSalary.HasValue)
            {
                querable = querable.Where(x => x.Salary >= FromSalary);
            }
            if(ToSalary.HasValue)
            {
                querable = querable.Where(x => x.Salary <= ToSalary);
            }
            if(Status.HasValue)
            {
                querable = querable.Where(x => x.Status == Status);
            }
            if(IsNotEnded.HasValue && IsNotEnded.Value)
            {
                querable = querable.Where(x => x.CloseDate >= DateTime.Now);
            }
            return querable;
        }
    }
}

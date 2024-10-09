using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils.Fetching.Filters
{
    public class PositionApplicationFilter : IFilter<PositionApplication>
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public Guid? PositionId { get; set; }
        //public Education 
        //public Exprience
        //public Skill

        public IQueryable<PositionApplication> filters(IQueryable<PositionApplication> queryable)
        {
            if(PositionId.HasValue)
            {
                queryable = queryable.Where(x => x.PositionId == PositionId);
            }
            if (FromDate.HasValue)
            {
                queryable = queryable.Where(x => x.CreatedAt >= FromDate);
            }
            if (ToDate.HasValue)
            {
                queryable = queryable.Where(x => x.CreatedAt <= ToDate.Value.Date.AddDays(1).AddTicks(-1));
            }
            return queryable;
        }
    }
}

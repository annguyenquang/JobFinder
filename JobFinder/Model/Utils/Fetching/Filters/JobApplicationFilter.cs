using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils.Fetching.Filters
{
    public class JobApplicationFilter : IFilter<JobApplication>
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public Guid? JobId { get; set; }
        //public Education 
        //public Exprience
        //public Skill

        public IQueryable<JobApplication> filters(IQueryable<JobApplication> queryable)
        {
            if(JobId.HasValue)
            {
                queryable = queryable.Where(x => x.JobId == JobId);
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

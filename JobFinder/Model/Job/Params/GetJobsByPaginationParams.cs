using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Model
{
    public class GetJobsByPaginationParams
    {
        public Pagination? Pagination { get; set; } 
        public Order? Order { get; set; } 
        public JobFilter? JobFilter { get; set; } 
    }
}

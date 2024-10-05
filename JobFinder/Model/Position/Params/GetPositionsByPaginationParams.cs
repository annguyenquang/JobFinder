using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Model
{
    public class GetPositionsByPaginationParams
    {
        public Pagination? Pagination { get; set; } 
        public Order? Order { get; set; } 
        public PositionFilter? PositionFilter { get; set; } 
    }
}

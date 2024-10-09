using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Model
{
    public class GetAllPositionApplicationParams
    {
        public PositionApplicationFilter? Filter { get; set; }
        public Order? Order { get; set; }
        public Pagination? Pagination { get; set; }
    }
}

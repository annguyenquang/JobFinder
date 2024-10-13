using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Model
{
    public class GetCompaniesByPaginationParams
    {
        public Pagination? Pagination { get; set; }
        public Order? Order { get; set; }
        public CompanyFilter? Filter { get; set; }
    }
}

using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Fetching;
using Microsoft.AspNetCore.Authentication;

namespace JobFinder.Model
{
    public class GetFirmsByPaginationParams
    {
        public Pagination? Pagination { get; set; }
        public Order? Order { get; set; }
        public FirmFilter? Filter { get; set; }
    }
}

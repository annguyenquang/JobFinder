using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;
using System.ComponentModel.DataAnnotations;

namespace JobFinder.Model
{
    public class GetFirmPositionsParams
    {
        public PositionFilter? Filter { get; set; }
        public Order? Order { get; set; }
        public Pagination? Pagination { get; set; }

    }
}

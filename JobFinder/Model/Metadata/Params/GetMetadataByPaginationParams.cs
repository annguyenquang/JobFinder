using JobFinder.Model.Utils.Fetching.Filters;
using JobFinder.Model.Utils.Fetching;

namespace JobFinder.Model
{
    public record GetMetadataByPaginationParams
    {
        public MetadataFilter? Filter { get; set; }
        public Pagination? Pagination { get; set; }
        public Order? Order { get; set; }
    }
}

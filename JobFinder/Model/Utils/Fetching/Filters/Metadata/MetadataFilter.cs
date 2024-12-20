using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils.Fetching.Filters
{
    public class MetadataFilter : IFilter<Metadata>
    {
        public MetadataType? MetadataType { get; set; }

        public IQueryable<Metadata> filters(IQueryable<Metadata> queryable)
        {
            if(MetadataType.HasValue)
            {
                queryable = queryable.Where(x => x.Type == MetadataType);
            }
            return queryable;
        }
    }
}

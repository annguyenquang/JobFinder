using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils;

public class CompanyFilter : IFilter<Company>
{
    public string Keyword { get; set; } = string.Empty;
    public int? ProvinceId { get; set; }
    public int? DistrictId { get; set; }

    public IQueryable<Company> filters(IQueryable<Company> queryable)
    {
        if (!string.IsNullOrEmpty(Keyword))
            queryable = queryable.Where(c => c.Name.ToLower().Contains(Keyword.ToLower()));
        if (ProvinceId.HasValue)
            queryable = queryable.Where(c => c.ProvinceId == ProvinceId);
        if (DistrictId.HasValue && ProvinceId.HasValue)
            queryable = queryable.Where(c => c.DistrictId == DistrictId);
        return queryable;
    }
}
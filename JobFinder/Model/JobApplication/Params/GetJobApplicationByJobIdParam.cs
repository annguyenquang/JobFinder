using JobFinder.Model.Utils.Fetching;
using JobFinder.Model.Utils.Fetching.Filters;

namespace JobFinder.Model;

public class GetJobApplicationByJobIdParam
{
    public GetJobApplicationByJobIdFilter? Filter { get; set; }
    public Order? Order { get; set; }
    public Pagination? Pagination { get; set; }
}
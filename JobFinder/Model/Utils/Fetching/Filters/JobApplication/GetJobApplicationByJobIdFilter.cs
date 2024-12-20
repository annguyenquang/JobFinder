using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace JobFinder.Model.Utils.Fetching.Filters;

public class GetJobApplicationByJobIdFilter : JobApplicationFilter
{
    [BindNever] [JsonIgnore] public override Guid? JobId { get; set; }
}
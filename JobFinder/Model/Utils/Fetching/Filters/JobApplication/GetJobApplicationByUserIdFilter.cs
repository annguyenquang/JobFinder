using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace JobFinder.Model.Utils.Fetching.Filters;

public class GetJobApplicationByUserIdFilter : JobApplicationFilter
{
    [JsonIgnore] [BindNever] public override Guid? UserId { get; set; }
}
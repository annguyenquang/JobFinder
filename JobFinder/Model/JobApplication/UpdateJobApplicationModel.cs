using System.ComponentModel.DataAnnotations;
using JobFinder.Model.Enums;

namespace JobFinder.Model;

public class UpdateJobApplicationModel
{
    public string? CoverLetter { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; } = string.Empty;

    [EnumDataType(typeof(JobApplicationState))]
    public JobApplicationState? State { get; set; } = JobApplicationState.UnderReview;
}
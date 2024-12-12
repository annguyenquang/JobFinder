using JobFinder.Core.Entity;

namespace JobFinder.Model;

public class JobApplicationWithJobId : IBaseResponseModel, IAuditableEntity
{
    public Guid JobId { get; set; }
    public Guid UserId { get; set; }
    public string CVLink { get; set; } = string.Empty;
    public string? CoverLetter { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; } = string.Empty;
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }
    public Guid Id { get; set; }
}
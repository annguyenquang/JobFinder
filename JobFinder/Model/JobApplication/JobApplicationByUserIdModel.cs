using JobFinder.Core.Entity;
using JobFinder.Model.Enums;

namespace JobFinder.Model;

public class UserApplication : IBaseResponseModel, IAuditableEntity
{
    public UserApplicationJob Job { get; set; }
    public Guid UserId { get; set; }
    public string CVLink { get; set; } = string.Empty;
    public string CoverLetter { get; set; } = string.Empty;
    public JobApplicationState State { get; set; }
    public Guid Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }
}

public class UserApplicationJob : IBaseResponseModel
{
    public string Title { get; set; } = string.Empty;
    public UserApplicationCompany Company { get; set; } = null!;
    public Guid Id { get; set; }
}

public class UserApplicationCompany : IBaseResponseModel
{
    public string Name { get; set; } = string.Empty;
    public string? Slug { get; set; } = string.Empty;
    public string? Logo { get; set; } = string.Empty;
    
    public Guid Id { get; set; }
}
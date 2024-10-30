using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Core.Entity;

[Index(nameof(Slug), IsUnique = true)]
public class Company : BaseEntity, IAuditableEntity
{
    public Guid AccountId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string EmailContact { get; set; } = string.Empty;
    public string PhoneContact { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty; 
    public int? EmployeeCount { get; set; }
    public string? Slug { get; set; } = string.Empty;

    [Range(0, 100, ErrorMessage = "The field {0} must be a number between 0 and 96.")]
    public int ProvinceId { get; set; }

    [Range(0, 1000, ErrorMessage = "The field {0} must be a number between 0 and 1000.")]
    public int DistrictId { get; set; }

    public string? Address { get; set; } = string.Empty;
    public string? Website { get; set; } = string.Empty;
    public string? Logo { get; set; } = string.Empty;
    public string? Industry { get; set; } = string.Empty;
    public Account Account { get; set; } = null!;
    public IEnumerable<Job> Jobs { get; set; } = new List<Job>();
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }
}
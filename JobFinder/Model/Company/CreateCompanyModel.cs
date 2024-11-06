using System.ComponentModel.DataAnnotations;
using JobFinder.Core.Entity;

namespace JobFinder.Model;
public class CreateCompanyModel
{
    public Guid AccountId { get; set; }
    public string EmailContact { get; set; } = string.Empty;
    public string PhoneContact { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    [Range(0, 100, ErrorMessage = "The field {0} must be a number between 0 and 96.")]
    public int ProvinceId { get; set; }

    [Range(0, 1000, ErrorMessage = "The field {0} must be a number between 0 and 1000.")]
    public int DistrictId { get; set; }

    public string? Address { get; set; } = string.Empty;
    public string? Website { get; set; } = string.Empty;
    public string? Industry { get; set; } = string.Empty;
    public int? EmployeeCount { get; set; }
}

public class CreateCompanyResponseModel : IBaseResponseModel
{
    public Guid Id { get; set; }
}
namespace JobFinder.Model;

public class JobModel : IBaseResponseModel
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double? Salary { get; set; }
    public JobStatus Status { get; set; }
    public DateTime? CloseDate { get; set; }
    public int? ProvinceId { get; set; }
    public int? DistrictId { get; set; }
    public int? MinAgeRequirement { get; set; }
    public int? MaxAgeRequirement { get; set; }
    public MetadataModel? GenderRequirement { get; set; }
    public MetadataModel? EducationLevelRequirement { get; set; }
    public MetadataModel? WorkExperienceRequirement { get; set; }
    public MetadataModel? WorkArrangement { get; set; }
    public MetadataModel? CommitmentType { get; set; }
    public CompanyModel Company { get; set; } = null!;
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? UpdatedBy { get; set; }
    public Guid Id { get; set; }
}
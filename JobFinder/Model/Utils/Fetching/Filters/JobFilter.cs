using JobFinder.Core.Entity;

namespace JobFinder.Model.Utils.Fetching.Filters;

public class JobFilter : IFilter<Job>
{
    public double? FromSalary { get; set; }
    public double? ToSalary { get; set; }
    public JobStatus? Status { get; set; }
    public bool? IsNotEnded { get; set; }
    public Guid? WorkArrangementId { get; set; }
    public Guid? CommitmentTypeId { get; set; }
    public int? ProvinceId { get; set; }
    public int? DistrictId { get; set; }
    public int? MinAgeRequirement { get; set; }
    public int? MaxAgeRequirement { get; set; }
    public Guid? GenderRequirementId { get; set; }
    public Guid? EducationLevelRequirementId { get; set; }
    public Guid? WorkExperienceRequirementId { get; set; }
    public DateOnly? LastUpdate { get; set; }
    public IQueryable<Job> filters(IQueryable<Job> querable)
    {
        if (FromSalary.HasValue)
        {
            querable = querable.Where(x => x.Salary >= FromSalary);
        }
        if (ToSalary.HasValue)
        {
            querable = querable.Where(x => x.Salary <= ToSalary);
        }
        if (Status.HasValue)
        {
            querable = querable.Where(x => x.Status == Status);
        }
        if (IsNotEnded.HasValue && IsNotEnded.Value)
        {
            querable = querable.Where(x => x.CloseDate >= DateTime.Now);
        }
        if (WorkArrangementId.HasValue)
        {
            querable = querable.Where(x => x.WorkArrangement != null &&  x.WorkArrangement.Id == WorkArrangementId);
        }
        if (CommitmentTypeId.HasValue)
        {
            querable = querable.Where(x => x.CommitmentType != null && x.CommitmentType.Id == WorkArrangementId);
        }
        if (ProvinceId.HasValue)
        {
            querable = querable.Where(x => x.ProvinceId == ProvinceId);
            if (DistrictId.HasValue)
            {
                querable = querable.Where(x => x.DistrictId == DistrictId);
            }
        }
        if (WorkExperienceRequirementId.HasValue)
        {
            querable = querable.Where(x => x.WorkExperienceRequirement != null && x.WorkExperienceRequirement.Id == WorkExperienceRequirementId);
        }
        if (EducationLevelRequirementId.HasValue)
        {
            querable = querable.Where(x => x.EducationLevelRequirement != null && x.EducationLevelRequirement.Id == EducationLevelRequirementId);
        }
        if(LastUpdate.HasValue)
        {
            querable = querable.Where(x => x.UpdatedAt >= DateTime.Now.AddDays(-LastUpdate.Value.Day) );
        }
        if (GenderRequirementId.HasValue)
        {
            querable = querable.Where(x => x.GenderRequirement != null && x.GenderRequirement.Id == GenderRequirementId);
        }
        //
        if (MinAgeRequirement.HasValue)
        {
            querable = querable.Where(x => x.MinAgeRequirement >= MinAgeRequirement);
        }
        if (MaxAgeRequirement.HasValue)
        {
            querable = querable.Where(x => x.MaxAgeRequirement <= MaxAgeRequirement);
        }
        return querable;
    }
}

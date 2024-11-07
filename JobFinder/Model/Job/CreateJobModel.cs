using JobFinder.Core.Entity;

namespace JobFinder.Model
{
    public class CreateJobModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double? Salary { get; set; }
        public JobStatus? Status { get; set; } = JobStatus.Open;
        public DateTime? CloseDate { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public int? MinAgeRequirement { get; set; }
        public int? MaxAgeRequirement { get; set; }
        public Guid? WorkArrangementId { get; set; }
        public Guid? CommitmentTypeId { get; set; }
        public Guid? GenderRequirementId { get; set; }
        public Guid? EducationLevelRequirementId { get; set; }
        public Guid? WorkExperienceRequirementId { get; set; }
        public Guid CompanyId { get; set; }
    }
    public class CreateJobReponseModel : IBaseResponseModel
    {
        public Guid Id { get; set; }
    }
}

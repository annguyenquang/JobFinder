
namespace JobFinder.Model
{
    public class UpdateJobModel
    {
        public string? Title { get; set; }        
        public string? Description { get; set; }
        public double? Salary { get; set; }
        public JobStatus? Status { get; set; }
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
    }
    public class UpdateJobReponseModel : IBaseResponseModel
    {
        public Guid Id { get; set; }
    }
}

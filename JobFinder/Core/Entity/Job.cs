using JobFinder.Model;

namespace JobFinder.Core.Entity
{


    public class Job : IBaseEntity, IAuditableEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double? Salary { get; set; }
        public JobStatus Status { get; set; }
        public DateTime? CloseDate { get; set; }
        /// Location 
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        /// Requirements
        public int? MinAgeRequirement { get; set; }
        public int? MaxAgeRequirement { get; set; }
        public Guid? WorkArrangementId { get; set; }
        public Metadata? WorkArrangement { get; set; }
        public Guid? CommitmentTypeId { get; set; }
        public Metadata? CommitmentType { get; set; }
        public Guid? GenderRequirementId { get; set; }
        public Metadata? GenderRequirement { get; set; }
        public Guid? EducationLevelRequirementId { get; set; }
        public Metadata? EducationLevelRequirement { get; set; }
        public Guid? WorkExperienceRequirementId { get; set; }
        public Metadata? WorkExperienceRequirement { get; set; }
        public string? Skills { get; set; } 
        public Guid CompanyId { get; set; }
        public Company Company { get; set; } = null!;
        public IEnumerable<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
        /// Creditial props 
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid Id { get; set; }
    }
}

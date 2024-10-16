using JobFinder.Model;

namespace JobFinder.Core.Entity
{


    public class Position : BaseEntity, ICredentialEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double? Salary { get; set; }
        public PositionStatus Status { get; set; }
        public DateTime? CloseDate { get; set; }
        /// Location 
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        /// Requirements
        public int? MinAgeRequirement { get; set; }
        public int? MaxAgeRequirement { get; set; }
        /// Navigations 
        public Metadata? WorkArrangement { get; set; }
        public Metadata? CommitmentType { get; set; }
        public Metadata? GenderRequirement { get; set; }
        public Metadata? EducationLevelRequirement { get; set; }
        public Metadata? WorkExperienceRequirement { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; } = null!;
        public IEnumerable<PositionApplication> PositionApplications { get; set; } = new List<PositionApplication>();
        /// Creditial props 
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}

namespace JobFinder.Model;

public class SuggestibleJob
{
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double? Salary { get; set; }
        public int? MinAgeRequirement { get; set; }
        public int? MaxAgeRequirement { get; set; }
        public Guid? WorkArrangementId { get; set; }
        public Guid? CommitmentTypeId { get; set; }
        public Guid? GenderRequirementId { get; set; }
        public Guid? EducationLevelRequirementId { get; set; }
        public Guid? WorkExperienceRequirementId { get; set; }
        public string? Skills { get; set; } 
}
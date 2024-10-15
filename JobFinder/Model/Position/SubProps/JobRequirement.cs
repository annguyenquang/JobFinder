namespace JobFinder.Model
{
    public record JobRequirement
    {
        public GenderRequirement? Gender { get; set; }
        public AgeRequirement? Age { get; set; }
        public EducationLevelRequirement? EducationLevel { get; set; }
        public WorkExperienceRequirement? WorkExperience { get; set; }
        public string? Skills { get; set; }
    }
}

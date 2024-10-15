namespace JobFinder.Model
{
    public record AgeRequirement
    {
        public int? MinAgeRequirement { get; set; }
        public int? MaxAgeRequirement { get; set; }
        public AgeRequirement(int? minAge, int? maxAge)
        {
            MinAgeRequirement = minAge;
            MaxAgeRequirement = maxAge;
        }
    }
}

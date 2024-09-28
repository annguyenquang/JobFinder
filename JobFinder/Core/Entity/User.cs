namespace JobFinder.Core.Entity
{
    public class User : BaseEntity
    {
        public Guid AccountId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public Account Account { get; set; } = null!;
    }
}

namespace JobFinder.Core.Entity
{
    public class User : BaseEntity, ICredentialEntity
    {
        public Guid AccountId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public Account Account { get; set; } = null!;
        public IEnumerable<PositionApplication> PositionApplications { get; set; } = [];
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}

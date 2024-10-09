namespace JobFinder.Core.Entity
{
    public class Firm : BaseEntity, ICredentialEntity
    {
        public Guid AccountId { get; set; }
        public string EmailContact { get; set; } = string.Empty;
        public string PhoneContact { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public Account Account { get; set; } = null!;
        public IEnumerable<Position> Positions { get; set; } = new List<Position>();
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}

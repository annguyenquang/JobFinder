namespace JobFinder.Core.Entity
{
    public class Position : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Double { get; set; }
        public PositionStatus Status { get; set; }
        public DateTime CloseDate { get; set; }
        public Guid FirmId { get; set; }
        public Firm Firm { get; set; } = null!;
    }

    public enum PositionStatus
    {
        Closed = 0,
        Open = 1,
    }
}

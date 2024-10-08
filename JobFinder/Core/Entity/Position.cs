﻿namespace JobFinder.Core.Entity
{
    public class Position : BaseEntity, ICredentialEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Salary { get; set; }
        public PositionStatus Status { get; set; }
        public DateTime CloseDate { get; set; }
        public Guid FirmId { get; set; }
        public Firm Firm { get; set; } = null!;
        public IEnumerable<PositionApplication> PositionApplications { get; set; } = new List<PositionApplication>();
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }

    public enum PositionStatus
    {
        Closed = 0,
        Open = 1,
    }
}

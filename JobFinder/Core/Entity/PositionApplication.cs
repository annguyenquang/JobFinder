namespace JobFinder.Core.Entity
{
    public class PositionApplication : BaseEntity, IAuditableEntity
        {
        public Guid PositionId { get; set; }
        public Guid? UserId { get; set; }
        public Position Position { get; set; }
        public User User { get; set; }
        public string CVLink { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}

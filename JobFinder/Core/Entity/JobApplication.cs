namespace JobFinder.Core.Entity
{
    public class JobApplication : IBaseEntity, IAuditableEntity
        {
        public Guid JobId { get; set; }
        public Guid? UserId { get; set; }
        public Job Job { get; set; }
        public User User { get; set; }
        public string CVLink { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid Id { get; set; }
        }
}

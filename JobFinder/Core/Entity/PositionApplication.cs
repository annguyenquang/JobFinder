namespace JobFinder.Core.Entity
{
    public class PositionApplication : BaseEntity
    {
        public Guid PositionId { get; set; }
        public Guid? UserId { get; set; }
        public Position Position { get; set; }
        public User User { get; set; }
        public string CVLink { get; set; } = string.Empty;
    }
}

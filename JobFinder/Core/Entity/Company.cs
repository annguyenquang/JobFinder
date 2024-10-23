using Microsoft.EntityFrameworkCore;

namespace JobFinder.Core.Entity
{
    [Index(nameof(Slug), IsUnique = true)] 
    public class Company : BaseEntity, IAuditableEntity
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EmailContact { get; set; } = string.Empty;
        public string PhoneContact { get; set; } = string.Empty;
        public int? EmployeeCount { get; set; } 
        public string Slug { get;set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string? Website { get; set; } = string.Empty;
        public string? Industry { get; set; } = string.Empty;
        public string Nation { get; set; } = string.Empty;
        public Account Account { get; set; } = null!;
        public IEnumerable<Position> Positions { get; set; } = new List<Position>();
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}

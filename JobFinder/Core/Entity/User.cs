using JobFinder.Model;

namespace JobFinder.Core.Entity
{
    public class User : Account, IAuditableEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public IEnumerable<string> Skills { get; set; } = new List<string>();
        public string SelfDescription { get; set; } = string.Empty;
        public IEnumerable<Certification> Certifications { get; set; } = new List<Certification>();
        public IEnumerable<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}

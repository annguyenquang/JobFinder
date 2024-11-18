namespace JobFinder.Model
{
    public class UserModel : IBaseResponseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public IEnumerable<string> Skills { get; set; } = new List<string>();
        public string SelfDescription { get; set; } = string.Empty;
        public IEnumerable<Certification> Certifications { get; set; } = new List<Certification>();
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid Id { get; set; }
    }
}

namespace JobFinder.Model;

public class UserLoginResponseModel : AccountModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string SelfDescription { get; set; } = string.Empty;
    public IEnumerable<string> Skills { get; set; } = new List<string>();
    public IEnumerable<Certification> Certifications { get; set; } = new List<Certification>();
    public DateOnly DateOfBirth { get; set; }
    public Guid Id { get; set; }
}
namespace JobFinder.Model;
public class UpdateUserModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly? DateOfBirth { get; set; }
    public IEnumerable<string>? Skills { get; set; } = new List<string>();
    public string? SelfDescription { get; set; } = string.Empty;
    public IEnumerable<Certification>? Certifications { get; set; } = new List<Certification>();
}

public class UpdateUserResponseModel : IBaseResponseModel
{
    public Guid Id { get; set; }
}

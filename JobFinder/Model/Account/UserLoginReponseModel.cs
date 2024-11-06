namespace JobFinder.Model;

public class UserLoginReponseModel : AccountModel
{
    public Guid AccountId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public Guid Id { get; set; }
 
}
namespace JobFinder.Model;

public class AccountModel
{
    public string Username { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? AccessToken { get; set; }
}
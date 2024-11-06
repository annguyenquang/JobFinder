using System.Text.Json.Serialization;

namespace JobFinder.Model;
[JsonDerivedType(typeof(CompanyLoginResponseModel))]
[JsonDerivedType(typeof(UserLoginReponseModel))]
public abstract class AccountModel: IBaseResponseModel
{
    public string Username { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? AccessToken { get; set; }
    public Guid Id { get; set; }
}
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JobFinder.Model.Utils;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace JobFinder.Model.AuthenticationService;

public interface IJwtService
{
    string GenerateTokenWithUsername(string userName);
}

public class JwtService (IOptions<AppSettings> appSettings) : IJwtService
{
        public string GenerateTokenWithUsername(string userName)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, userName)
            };
            var jwtToken = new JwtSecurityToken(
                claims: claims,
                notBefore: DateTime.UtcNow,
            expires: DateTime.UtcNow.AddDays(1),
            signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.Value.JwtSecretKey)),
                    SecurityAlgorithms.HmacSha256Signature
                )
                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
}
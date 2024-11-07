using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Constants;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace JobFinder.Service;

public interface IJwtService
{
    string GenerateTokenWithUsername(string userName);
    Task<string> GetIdFromTokenAsync(string token);
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

        public async Task<string> GetIdFromTokenAsync(string token)
        {
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var res = await jwtSecurityTokenHandler.ValidateTokenAsync(token, new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.Value.JwtSecretKey)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            });
            return (string)res.Claims[Authentication.JwtCookieKey];
        }
}
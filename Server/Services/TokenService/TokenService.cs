using BlazorEComm.Shared.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BlazorEComm.Server.Services.TokenService;

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string CreateToken(User user) =>
        new JwtSecurityTokenHandler()
            .WriteToken(
                new JwtSecurityToken(
                    claims: new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Name, user.Email)
                    },
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                            _configuration.GetSection(AppSetting.TokenKey).Value)),
                                SecurityAlgorithms.HmacSha512Signature)));
}
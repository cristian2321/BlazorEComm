using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.TokenService;

public interface ITokenService
{
    string CreateToken(User user);
}

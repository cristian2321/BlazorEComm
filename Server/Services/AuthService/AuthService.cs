using BlazorEComm.Server.Services.TokenService;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IPasswordService _passwordService;
    private readonly ITokenService _tokenService;

    public AuthService(EcommDbContext ecommDbContext, ITokenService tokenService, IPasswordService passwordService)
    {
        _ecommDbContext = ecommDbContext;
        _tokenService = tokenService;
        _passwordService = passwordService;
    }

    private const bool IsSucces = true;

    private const string MessageRegisterSucces = "Registration successful !";
    private const string MessageUserExist = "User already exists !";
    private const string MessageUserNotFound = "User not found !";
    private const string MessageWrongPassword = "Wrong password !";
  
    public async Task<ServiceResponse<string>> Register(User user, string password, CancellationToken cancellationToken)
    {
        if (await UserExists(user.Email, cancellationToken))
        {
            return new ServiceResponse<string>
            {
                Succes = !IsSucces,
                Message = MessageUserExist
            };
        }

        _passwordService.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
        user.PasswordSalt = passwordSalt;
        user.PasswordHash = passwordHash;

        _ecommDbContext.Add(user);
        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<string>
        {
            Data = user.Id.ToString(),
            Message = MessageRegisterSucces
        };
    }
  
    public async Task<ServiceResponse<string>> Login(string email, string password, CancellationToken cancellationToken)
    {
        var response = new ServiceResponse<string>();

        var user = await _ecommDbContext.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower(), cancellationToken);
        if (user == null)
        {
            response.Succes = !IsSucces;
            response.Message = MessageUserNotFound;

            return response;
        }

        if (!_passwordService.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
        {
            response.Succes = !IsSucces;
            response.Message = MessageWrongPassword;

            return response;
        }

        response.Data = _tokenService.CreateToken(user);
        return response;
    }

    public async Task<bool> UserExists(string email, CancellationToken cancellationToken) =>
        await _ecommDbContext.Users.AnyAsync(user => user.Email.ToLower().Equals(email.ToLower()), cancellationToken);

    public async Task<User?> GetUserByEmail(string email) =>
        await _ecommDbContext.Users.FirstOrDefaultAsync(x => x.Email.Equals(email));
}
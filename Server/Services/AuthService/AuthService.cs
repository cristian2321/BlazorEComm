using BlazorEComm.Shared.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BlazorEComm.Server.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IConfiguration _configuration;

    public AuthService(EcommDbContext ecommDbContext, IConfiguration configuration)
    {
        _ecommDbContext = ecommDbContext;
        _configuration = configuration;
    }

    private const bool IsSucces = true;

    private const string KeyConfig = "AppSettings:Token";
    private const string MessageChangePassword = "Password was changed";
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

        CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
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

    public async Task<bool> UserExists(string email, CancellationToken cancellationToken) =>
        await _ecommDbContext.Users.AnyAsync(user => user.Email.ToLower().Equals(email.ToLower()), cancellationToken);

    private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512();

        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        hmac?.Dispose();
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

        if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
        {
            response.Succes = !IsSucces;
            response.Message = MessageWrongPassword;

            return response;
        }

        response.Data = CreateToken(user);
        return response;
    }

    private static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512(passwordSalt);

        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        hmac?.Dispose();

        return computedHash.SequenceEqual(passwordHash);
    }

    private string CreateToken(User user) =>
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
                        _configuration.GetSection(KeyConfig).Value)),
                            SecurityAlgorithms.HmacSha512Signature)));

    public async Task<ServiceResponse<bool>> ChangePassword(Guid userId, string newPassword, CancellationToken cancellationToken)
    {
        var user = await _ecommDbContext.Users.FindAsync(new object?[] { userId }, cancellationToken: cancellationToken);

        if (user == null)
        {
            return new()
            {
                Succes = !IsSucces,
                Message = MessageUserNotFound
            };
        };

        CreatePasswordHash(newPassword, out byte[] passwordHash, out byte[] passwordSalt);
        
        user.PasswordSalt = passwordSalt;
        user.PasswordHash = passwordHash;

        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new()
        {
            Data = IsSucces,
            Message = MessageChangePassword,
        };
    }
}
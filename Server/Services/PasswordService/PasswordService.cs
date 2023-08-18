using System.Security.Cryptography;
using System.Text;

namespace BlazorEComm.Server.Services.PasswordService;

public class PasswordService : IPasswordService
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IHttpContextService _httpContextService;

    public PasswordService(EcommDbContext ecommDbContext, IHttpContextService httpContextService)
    {
        _ecommDbContext = ecommDbContext;
        _httpContextService = httpContextService;
    }

    private const bool IsSucces = true;
    private const string MessageChangePassword = "Password changed successful !"; 
    private const string MessageUserNotFound = "User not found !";

    public async Task<ServiceResponse<bool>> ChangePassword(string newPassword, 
        CancellationToken cancellationToken)
    {
        var user = await _ecommDbContext.Users.FindAsync(new object?[] { _httpContextService.GetUserId() }, 
            cancellationToken: cancellationToken);

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

    public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512();

        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        hmac?.Dispose();
    }

    public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512(passwordSalt);

        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        hmac?.Dispose();

        return computedHash.SequenceEqual(passwordHash);
    }
}
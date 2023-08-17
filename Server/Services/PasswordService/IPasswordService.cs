using System.Security.Cryptography;
using System.Text;

namespace BlazorEComm.Server.Services.PasswordService;

public interface IPasswordService
{
    Task<ServiceResponse<bool>> ChangePassword(Guid userId, string newPassword, CancellationToken cancellationToken);

    void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);

    bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
}
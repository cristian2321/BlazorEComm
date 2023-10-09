using BlazorEComm.Shared.Messages;
using System.Security.Cryptography;
using System.Text;

namespace BlazorEComm.Server.Services.PasswordService;

public class PasswordService : IPasswordService
{
    private readonly IHttpContextService _httpContextService;
    private readonly IRepository _repository;
    private readonly IUserExtensionRepository _userExtensionRepository;

    public PasswordService(IHttpContextService httpContextService,
        IRepository repository, 
        IUserExtensionRepository userExtensionRepository)
    {
        _httpContextService = httpContextService;
        _repository = repository;
        _userExtensionRepository = userExtensionRepository;
    }

    public async Task<ServiceResponse<bool>> ChangePassword(string newPassword, 
        CancellationToken cancellationToken)
    {
        var user = await _userExtensionRepository.FindUser(_httpContextService.GetUserId(), cancellationToken);

        if (user == null)
        {
            return new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageUserNotFound
            };
        };

        CreatePasswordHash(newPassword, out byte[] passwordHash, out byte[] passwordSalt);

        user.PasswordSalt = passwordSalt;
        user.PasswordHash = passwordHash;

        await _repository.SaveChangesAsync(cancellationToken);

        return new()
        {
            Data = ConstantServerServices.IsSucces,
            Message = MessagesServerServices.MessageChangePassword,
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
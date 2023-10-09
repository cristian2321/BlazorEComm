using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface IUserExtensionRepository
{
    Task<User?> FindUser(Guid id, CancellationToken cancellationToken);

    Task<User?> GetUserByEmail(string email, CancellationToken cancellationToken);

    Task<bool> UserExists(string email, CancellationToken cancellationToken);
}
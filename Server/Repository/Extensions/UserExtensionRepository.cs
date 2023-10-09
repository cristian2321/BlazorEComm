using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions
{
    public class UserExtensionRepository : IUserExtensionRepository
    {
        private readonly EcommDbContext _ecommDbContext;

        public UserExtensionRepository(EcommDbContext ecommDbContext)
        {
            _ecommDbContext = ecommDbContext;
        }

        public async Task<User?> FindUser(Guid id, CancellationToken cancellationToken) => 
            await _ecommDbContext.Users.FindAsync(new object?[] { id }, cancellationToken: cancellationToken);

        public async Task<User?> GetUserByEmail(string email, CancellationToken cancellationToken) =>
            await _ecommDbContext.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower(), cancellationToken);

        public async Task<bool> UserExists(string email, CancellationToken cancellationToken) =>
            await _ecommDbContext.Users.AnyAsync(user => user.Email.ToLower().Equals(email.ToLower()), cancellationToken);
    }
}

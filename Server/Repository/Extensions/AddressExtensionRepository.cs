using BlazorEComm.Server.Repository.Extensions.Interfaces;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions;

public class AddressExtensionRepository : IAddressExtensionRepository
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IHttpContextService _httpContextService;
    
    public AddressExtensionRepository(EcommDbContext ecommDbContext, IHttpContextService httpContextService)
    {
        _ecommDbContext = ecommDbContext;
        _httpContextService = httpContextService;
    }

    public async Task<bool> AnyAddressPrincipal(Guid userId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Addresses
            .AnyAsync(x => x.UserId == userId &&
                    x.Principal,
                cancellationToken);

    public async Task<Address?> GetAddress(Guid addressId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Addresses
            .FirstOrDefaultAsync(x => x.Id == addressId, cancellationToken);

    public async Task<List<Address>> GetAddresses(CancellationToken cancellationToken) =>
        await _ecommDbContext.Addresses
                .Where(x => x.UserId == _httpContextService.GetUserId())
                .OrderByDescending(x => x.Principal)
                .ToListAsync(cancellationToken);

    public async Task<Address?> GetAddressPrincipal(Guid userId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Addresses
                .FirstOrDefaultAsync(x => x.UserId == userId && x.Principal,
                    cancellationToken);

    public async Task<Address?> GetAddressNotPrincipal(Guid userId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Addresses
            .FirstOrDefaultAsync(x => x.UserId == userId && !x.Principal, cancellationToken);
}
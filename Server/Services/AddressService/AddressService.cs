using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.AddressService;

public class AddressService : IAddressService
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IHttpContextService _httpContextService;

    public AddressService(EcommDbContext ecommDbContext, IHttpContextService httpContextService)
    {
        _ecommDbContext = ecommDbContext;
        _httpContextService = httpContextService;
    }

    private const bool Principal = true;

    public async Task<ServiceResponse<Address>> AddAddress(Address address, CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();
        address.UserId = userId;

        if (address.Principal)
        {
            var addressPrincipal = await GetAddressPrincipal(cancellationToken);
            if (addressPrincipal is not null)
            {
                addressPrincipal.Principal = !Principal;
            }
        }

        _ecommDbContext.Add(address);
        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<Address> { Data = address };
    }

    public async Task<ServiceResponse<List<Address>>> GetAddresses(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _ecommDbContext.Addresses
                .Where(x => x.UserId == _httpContextService.GetUserId())
                .OrderByDescending(x=>x.Principal)
                .ToListAsync(cancellationToken)
        };

    private async Task<Address?> GetAddressPrincipal(CancellationToken cancellationToken) =>
        await _ecommDbContext.Addresses
                    .FirstOrDefaultAsync(x => x.UserId == _httpContextService.GetUserId() &&
                            x.Principal,
                        cancellationToken);
}
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface IAddressExtensionRepository 
{
    Task<List<Address>> GetAddresses(CancellationToken cancellationToken);

    Task<Address?> GetAddress(Guid addressId, CancellationToken cancellationToken);

    Task<Address?> GetAddressPrincipal(Guid userId, CancellationToken cancellationToken);

    Task<Address?> GetAddressNotPrincipal(Guid userId, CancellationToken cancellationToken);

    Task<bool> AnyAddressPrincipal(Guid userId, CancellationToken cancellationToken);
}
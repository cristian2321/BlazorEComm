using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.AddressService;

public interface IAddressService
{
    Task<ServiceResponse<Address>> AddAddress(Address address, CancellationToken cancellationToken);

    Task<ServiceResponse<bool>> DeleteAddress(Guid addressId, CancellationToken cancellationToken);

    Task<ServiceResponse<Address?>> GetAddress(Guid addressId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<Address>>> GetAddresses(CancellationToken cancellationToken);

    Task<ServiceResponse<Address?>> UpdateAddress(Address address, CancellationToken cancellationToken);
}
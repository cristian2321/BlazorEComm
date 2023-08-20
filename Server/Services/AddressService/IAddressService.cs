using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.AddressService;

public interface IAddressService
{
    Task<ServiceResponse<List<Address>>> GetAddresses(CancellationToken cancellationToken);

    Task<ServiceResponse<Address>> AddAddress(Address address, CancellationToken cancellationToken);
}
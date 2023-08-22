using BlazorEComm.Shared;

namespace BlazorEComm.Client.Services.AddressService;

public interface IAddressService
{
    Task<List<Address>> GetAddresses();

    Task<Address> AddAddress(Address address);

    Task<bool> DeleteAddress(Guid addressId);

    Task<bool> UpdateAddress(Address address);

    Task<Address?> GetAddress(Guid addressId);
}
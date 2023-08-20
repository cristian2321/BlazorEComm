namespace BlazorEComm.Client.Services.AddressService;

public interface IAddressService
{
    Task<List<Address>> GetAddresses();

    Task<Address> AddAddress(Address address);
}
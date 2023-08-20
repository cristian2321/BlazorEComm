using BlazorEComm.Shared;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Client.Services.AddressService;

public class AddressService : IAddressService
{
     private readonly HttpClient _httpClient;
    
    public AddressService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    private const string BaseAddressUrl = "api/address";

    public async Task<Address> AddAddress(Address address)
    {
        var response = await _httpClient.PostAsJsonAsync(BaseAddressUrl, address);
        var serviceResponse = await response.Content.ReadFromJsonAsync<ServiceResponse<Address>>();
     
        return serviceResponse is not null && serviceResponse.Data is not null ?
            serviceResponse.Data : 
            default!;
    }

    public async Task<List<Address>> GetAddresses()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Address>>>(BaseAddressUrl);
       
        return response is not null && response.Data is not null && response.Data.Any() ? 
            response.Data : default!;
    }
}
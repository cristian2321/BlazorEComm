using BlazorEComm.Shared;

namespace BlazorEComm.Client.Services.AddressService;

public class AddressService : IAddressService
{
     private readonly HttpClient _httpClient;
    
    public AddressService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Address> AddAddress(Address address)
    {
        var response = await _httpClient.PostAsJsonAsync(ClientApiEndpoints.BaseApiAddressUrl, address);
        var serviceResponse = await response.Content.ReadFromJsonAsync<ServiceResponse<Address>>();
     
        return serviceResponse is not null && serviceResponse.Data is not null ?
            serviceResponse.Data : 
            default!;
    }

    public async Task<List<Address>> GetAddresses()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Address>>>
            (ClientApiEndpoints.BaseApiAddressUrl);
       
        return response is not null && response.Data is not null && response.Data.Any() ? 
            response.Data : default!;
    }

    public async Task<bool> UpdateAddress(Address address)
    {
        var response = await _httpClient.PutAsJsonAsync(ClientApiEndpoints.BaseApiAddressUrl, address);
        if (response is null)
        {
            return default;
        }

        var responseContent = await response.Content.ReadFromJsonAsync<ServiceResponse<Address>>();
        return responseContent is not null && responseContent.Data is not null && responseContent.Succes; 
    }

    public async Task<bool> DeleteAddress(Guid addressId)
    {
        var response = await _httpClient.DeleteAsync($"{ClientApiEndpoints.BaseApiAddressUrl}/{addressId}");
        if (response is null)
        {
            return default;
        }

        var responseContent = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();

        return responseContent is not null && responseContent.Data && responseContent.Succes;
    }

    public async Task<Address?> GetAddress(Guid addressId)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<Address>>
            ($"{ClientApiEndpoints.BaseApiAddressUrl}/{addressId}");

        return response is not null && response.Data is not null ?
            response.Data : default!;
    }
}
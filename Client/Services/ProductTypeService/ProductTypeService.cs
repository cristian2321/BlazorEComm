using BlazorEComm.Shared;

namespace BlazorEComm.Client.Services.ProductTypeService;

public class ProductTypeService : IProductTypeService
{
    private readonly HttpClient _httpClient;

    public ProductTypeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<ProductType> AdminProductTypes { get; set; } = new ();

    public List<ProductType> ProductTypes { get; set; } = new();

    public event Action? OnChange;

    public async Task AddProductType(ProductType productType)
    {
        var response = await _httpClient.PostAsJsonAsync(ClientApiEndpoints.AdminProductTypeApiUrl, productType);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    public async Task<bool> DeleteProductType(Guid productTypeId)
    {
        var response = await _httpClient.DeleteAsync($"{ClientApiEndpoints.AdminProductTypeApiUrl}/{productTypeId}");
        if (response is null || !response.IsSuccessStatusCode)
        {
            return !ClientConstants.IsSucces;
        }

        await AfterResponseForAddDeleteAndUpdate(response);

        return ClientConstants.IsSucces;
    }

    public async Task<ProductType?> GetAdminProductType(Guid productTypeId)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<ProductType?>>
            ($"{ClientApiEndpoints.AdminProductTypeApiUrl}/{productTypeId}");

        return response is not null && response.Data is not null && response.Succes ?
            response.Data : default;
    }

    public async Task<List<string>> GetAdminProductTypeNames()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<string>>>
           ($"{ClientApiEndpoints.ProductTypeNamesApiUrl}");

        return response is not null && response.Data is not null && response.Succes ?
            response.Data : default!;
    }

    public async Task GetAdminProductTypes()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ProductType>>>
            (ClientApiEndpoints.AdminProductTypeApiUrl);
        if (response is not null && response.Data is not null && response.Succes)
        {
            AdminProductTypes = response.Data;
        }
    }

    public async Task GetProductTypes()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ProductType>>>
             (ClientApiEndpoints.ProductTypesUrl);
        if (response is not null && response.Data is not null && response.Succes)
        {
            ProductTypes = response.Data;
        }
    }

    public async Task UpdateProductType(ProductType productType)
    {
        var response = await _httpClient.PutAsJsonAsync(ClientApiEndpoints.AdminProductTypeApiUrl, productType);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    private async Task AfterResponseForAddDeleteAndUpdate(HttpResponseMessage response)
    {
        var responseProductTypes = (await response.Content.ReadFromJsonAsync<ServiceResponse<List<ProductType>>>());
        if (responseProductTypes is not null && responseProductTypes.Data is not null && responseProductTypes.Succes)
        {
            AdminProductTypes = responseProductTypes.Data;
        }

        await GetAdminProductTypes();

        OnChange?.Invoke();
    }
}
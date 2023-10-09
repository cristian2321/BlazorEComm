using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ProductVariantService;

public class ProductVariantService : IProductVariantService
{
    private readonly HttpClient _httpClient;

    public ProductVariantService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<ProductVariantDto> AdminProductVariants { get; set; } = new();
  
    public List<ProductVariantDto> ProductVariants { get; set; } = new();

    public event Action? OnChange;

    public async Task AddProductVariant(ProductVariantDto productVariant)
    {
        var response = await _httpClient.PostAsJsonAsync(ClientApiEndpoints.AdminProductVariantApiUrl, productVariant);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    public async Task<bool> DeleteProductVariant(Guid productId, Guid productTypeId)
    {
        var response = await _httpClient.DeleteAsync($"{ClientApiEndpoints.AdminProductVariantApiUrl}/{productId}/{productTypeId}");
        if (response is null || !response.IsSuccessStatusCode)
        {
            return !ClientConstants.IsSucces;
        }

        await AfterResponseForAddDeleteAndUpdate(response);

        return ClientConstants.IsSucces;
    }

    public async Task<ProductVariantDto?> GetAdminProductVariant(Guid productId, Guid productTypeId)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<ProductVariantDto?>>
            ($"{ClientApiEndpoints.AdminProductVariantApiUrl}/{productId}/{productTypeId}");

        return response is not null && response.Data is not null && response.Succes ?
            response.Data : default;
    }

    public async Task GetAdminProductVariants()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ProductVariantDto>>>
          (ClientApiEndpoints.AdminProductVariantApiUrl);
        if (response is not null && response.Data is not null && response.Succes)
        {
            AdminProductVariants = response.Data;
        }
    }

    public async Task GetProductVariants()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ProductVariantDto>>>
          (ClientApiEndpoints.ProductVariantsUrl);
        if (response is not null && response.Data is not null && response.Succes)
        {
            ProductVariants = response.Data;
        }
    }

    public async Task UpdateProductVariant(ProductVariantDto productVariant)
    {
        var response = await _httpClient.PutAsJsonAsync(ClientApiEndpoints.AdminProductVariantApiUrl, productVariant);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    private async Task AfterResponseForAddDeleteAndUpdate(HttpResponseMessage response)
    {
        var responseProductTypes = (await response.Content.ReadFromJsonAsync<ServiceResponse<List<ProductVariantDto>>>());
        if (responseProductTypes is not null && responseProductTypes.Data is not null && responseProductTypes.Succes)
        {
            AdminProductVariants = responseProductTypes.Data;
        }

        await GetAdminProductVariants();

        OnChange?.Invoke();
    }
}
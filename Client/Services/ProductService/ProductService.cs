using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ProductService;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    private readonly ConfigurationAppDto _configurationApp;

    public ProductService(HttpClient httpClient, ConfigurationAppDto configurationApp)
    {
        _httpClient = httpClient;
        _configurationApp = configurationApp;
    }

    public event Action? ProductsChanged;

    public List<Product>? Products { get; set; } 

    public List<ProductDto> AdminProducts { get; set; } = new();
 
    public int CurrentPage { get; set; } = ClientConstants.DefaultPage;

    public int PageCount { get; set; } = default;

    public int PageProductsAdmin { get; set; } = default;

    public string LastSearchText { get; set; } = default!;

    public async Task<ServiceResponse<Product>> GetProduct(Guid productId)
    {
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>
            ($"{ClientApiEndpoints.BaseApiProductUrl}/{productId}");

        return result!;
    }

    public async Task GetProducts(string? categoryUrl = null)
    {
        var result = categoryUrl == null ?
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>
                (ClientApiEndpoints.ProductFeaturedUrl) :
            
            await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>
                ($"{ClientApiEndpoints.ProductCategoryUrl}/{categoryUrl}");

        if (result is not null && result.Data is not null)
        {
            Products = result.Data;
        }
   
        CurrentPage = 1;
        PageCount = 0;
        ProductsChanged?.Invoke();
    }

    public async Task SearchProducts(string searchText, int page)
    {
        LastSearchText = searchText;
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<ProductSearchResultDto>>
            ($"{ClientApiEndpoints.ProductSearchUrl}/{searchText}/{page}");

        if (result is not null && result.Data is not null)
        {
            Products = result.Data.Products;
            CurrentPage = result.Data.CurrentPage;
            PageCount = result.Data.Pages;
        }
     
        ProductsChanged?.Invoke();
    }

    public async Task<List<string>> GetProductsSearchSuggestions(string searchText)
    {
        var result = await _httpClient
            .GetFromJsonAsync<ServiceResponse<List<string>>>
                ($"{ClientApiEndpoints.ProductSearchSuggestionUrl}/{searchText}");

        return result is not null && result.Data is not null ?
            result.Data : default!;
    }

    public async Task<List<string>> GetProductTitles()
    {
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<string>>>
                 (ClientApiEndpoints.ProductTitleApiUrl);

        return result is not null && result.Data is not null && result.Succes ? 
            result.Data : default!;
    }

    public string GetLoadingProductsMessage() =>
        _configurationApp.Configurations
            .Where(x => x.Activ && x.Language.ToLower() == _configurationApp.Language.ToLower() && 
                x.Key.ToLower() == ClientConstants.MessageLoadingProducts.ToLower())
            .Select(x => x.Value).FirstOrDefault() ?? string.Empty;
    public string GetEmptyProductMessage() =>
        _configurationApp.Configurations
        .Where(x => x.Activ && x.Language.ToLower() == _configurationApp.Language.ToLower() &&
            x.Key.ToLower() == ClientConstants.NoProductsFound.ToLower())
        .Select(x => x.Value).FirstOrDefault() ?? string.Empty;

    #region Admin

    public async Task AddProduct(ProductDto product)
    {
        var response = await _httpClient.PostAsJsonAsync(ClientApiEndpoints.AdminProducsApiBaseUrl, product);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    public async Task<bool> DeleteProduct(Guid productId)
    {
        var response = await _httpClient.DeleteAsync($"{ClientApiEndpoints.AdminProducsApiBaseUrl}/{productId}");
        if (response is null || !response.IsSuccessStatusCode)
        {
            return !ClientConstants.IsSucces;
        }

        await AfterResponseForAddDeleteAndUpdate(response);

        return ClientConstants.IsSucces;
    }

    public async Task GetAdminProducts()
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ProductDto>>>
             ($"{ClientApiEndpoints.AdminProducsApiUrl}/{PageProductsAdmin}");
        if (response is not null && response.Data is not null && response.Succes)
        {
            AdminProducts = response.Data;
        }
    }

    public async Task<Product?> GetAdminProduct(Guid productId)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<Product?>>
            ($"{ClientApiEndpoints.AdminProducsApiBaseUrl}/{productId}");

        return response is not null && response.Data is not null && response.Succes ?
            response.Data : default;
    }
    
    public async Task UpdateProduct(ProductDto product)
    {
        var response = await _httpClient.PutAsJsonAsync(ClientApiEndpoints.AdminProducsApiBaseUrl, product);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    private async Task AfterResponseForAddDeleteAndUpdate(HttpResponseMessage response)
    {
        var responseProductTypes = (await response.Content.ReadFromJsonAsync<ServiceResponse<List<ProductDto>>>());
        if (responseProductTypes is not null && responseProductTypes.Data is not null && responseProductTypes.Succes)
        {
            AdminProducts = responseProductTypes.Data;
        }

        await GetAdminProducts();

        ProductsChanged?.Invoke();
    }

    #endregion
}
using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ProductService;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
   
    public event Action? ProductsChanged;

    public List<Product> Products { get; set; } = new List<Product>();

    public string Message { get; set; } = MessagesClientPages.MessageLoadingProduct;
 
    public int CurrentPage { get; set; } = ClientConstants.DefaultPage;

    public int PageCount { get; set; } = default;

    public string LastSearchText { get; set; } = default!;

    
    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
  
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

        if (!Products.Any())
        {
            Message = MessagesClientServices.MessageNoProductFound;
        }
          
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

        if (!Products.Any())
        {
            Message = MessagesClientServices.MessageNoProductFound;
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
}
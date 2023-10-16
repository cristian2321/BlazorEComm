using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ProductService;

public interface IProductService
{
    event Action? ProductsChanged;

    List<Product> ? Products { get; set; }

    List<ProductDto> AdminProducts { get; set; }

    int CurrentPage { get; set; }

    int PageCount { get; set; }
    
    int PageProductsAdmin { get; set; }

    string LastSearchText { get; set; }

    Task GetProducts(string? categoryUrl = null);

    Task AddProduct(ProductDto product);

    Task<bool> DeleteProduct(Guid productId);

    Task GetAdminProducts();

    Task<Product?> GetAdminProduct(Guid productId);
  
    Task UpdateProduct(ProductDto product);

    Task<ServiceResponse<Product>> GetProduct(Guid productId);

    Task SearchProducts(string searchText, int page);

    Task<List<string>> GetProductsSearchSuggestions(string searchText);

    Task<List<string>> GetProductTitles();

    string GetLoadingProductsMessage();

    string GetEmptyProductMessage();
}
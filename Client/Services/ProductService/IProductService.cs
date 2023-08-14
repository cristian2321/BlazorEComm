using BlazorEComm.Shared;

namespace BlazorEComm.Client.Services.ProductService;

public interface IProductService
{
    event Action? ProductsChanged;

    string Message { get; set; }

    List<Product> Products { get; set; }

    int CurrentPage { get; set; }

    int PageCount { get; set; }

    string LastSearchText { get; set; }

    Task GetProducts(string? categoryUrl = null);

    Task<ServiceResponse<Product>> GetProduct(Guid productId);

    Task SearchProducts(string searchText, int page);

    Task<List<string>> GetProductsSearchSuggestions(string searchText);
}

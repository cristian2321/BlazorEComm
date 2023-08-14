using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProducts(CancellationToken cancellationToken);

    Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl, CancellationToken cancellationToken);

    Task<ServiceResponse<Product>> GetProduct(Guid productId, CancellationToken cancellationToken);

    Task<ServiceResponse<ProductSearchResultDto>> SearchProducts(string searchText, int page, CancellationToken cancellationToken);

    Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText, CancellationToken cancellationToken);
  
    Task<ServiceResponse<List<Product>>> GetFeaturedProducts(CancellationToken cancellationToken);
}
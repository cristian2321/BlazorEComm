using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductService.Interfaces;

public interface IAdminProductService
{
    Task<ServiceResponse<List<ProductDto>>> AddProduct(ProductDto product, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductDto>>> DeleteProduct(Guid productId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductDto>>> GetProducts(int page, CancellationToken cancellationToken);

    Task<ServiceResponse<Product>> GetProduct(Guid productId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<string>>> GetProductTitles(CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductDto>>> UpdateProduct(ProductDto product, CancellationToken cancellationToken);

    Task<Guid> GetProductIdByTitle(string title, CancellationToken cancellationToken);
}
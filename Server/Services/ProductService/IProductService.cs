using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductService;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProducts(CancellationToken cancellationToken);
}

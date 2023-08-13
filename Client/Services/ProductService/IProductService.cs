using BlazorEComm.Shared;

namespace BlazorEComm.Client.Services.ProductService;

public interface IProductService
{
    List<Product> Products { get; set; }

    Task GetProducts();

    Task<ServiceResponse<Product>> GetProduct(Guid productId);
}

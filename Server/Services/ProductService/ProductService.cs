using BlazorEComm.Server.Data;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductService;

public class ProductService : IProductService
{
    private EcommDbContext _ecommDbContext;

    public ProductService(EcommDbContext ecomDbContext)
    {
        _ecommDbContext = ecomDbContext;
    }

    public async Task<ServiceResponse<Product>> GetProduct(Guid productId, 
        CancellationToken cancellationToken)
    {
        var product = await _ecommDbContext.Products.FirstOrDefaultAsync(x => x.Id == productId, cancellationToken);
        return product is null ? 
            new() 
            {
                Succes = false,
                Message = $"Product not found for product Id:{productId}"
            }: 
            new() { Data = product };
    }

    public async Task<ServiceResponse<List<Product>>> GetProducts(CancellationToken cancellationToken) => 
        new () {  Data = await _ecommDbContext.Products.ToListAsync(cancellationToken)  };
}

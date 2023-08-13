using BlazorEComm.Server.Data;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductService;

public class ProductService : IProductService
{
    private EcomDbContext _ecomDbContext;

    public ProductService(EcomDbContext ecomDbContext)
    {
        _ecomDbContext = ecomDbContext;
    }

    public async Task<ServiceResponse<List<Product>>> GetProducts(CancellationToken cancellationToken) => 
        new ()
        {
            Data = await _ecomDbContext.Products.ToListAsync(cancellationToken)
        };
}

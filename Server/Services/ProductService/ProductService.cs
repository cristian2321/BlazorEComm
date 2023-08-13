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
        var product = await _ecommDbContext.Products
            .Where(x=>x.Id == productId)
            .Include(x=> x.Variants)
            .ThenInclude(x=>x.ProductType)
            .FirstOrDefaultAsync(cancellationToken);
        
        return product is null ? 
            new() 
            {
                Succes = false,
                Message = $"Product not found for product Id:{productId}"
            }: 
            new() { Data = product };
    }

    public async Task<ServiceResponse<List<Product>>> GetProducts(CancellationToken cancellationToken) => 
        new () 
        { 
            Data = await _ecommDbContext.Products
                .Include(x=>x.Variants)
                .ToListAsync(cancellationToken)  
        };

    public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl, CancellationToken cancellationToken) =>
        new ()
        {
            Data = await _ecommDbContext.Products
                .Where(x => x.Category != null && 
                    x.Category.Url.ToLower() == categoryUrl.ToLower())
                .Include(x => x.Variants)
                .ToListAsync(cancellationToken)
        };
}

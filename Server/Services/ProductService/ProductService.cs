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
            .Where(x => x.Id == productId)
            .Include(x => x.ProductVariants)
            .ThenInclude(x => x.ProductType)
            .FirstOrDefaultAsync(cancellationToken);

        return product is null ?
            new()
            {
                Succes = false,
                Message = $"Product not found for product Id:{productId}"
            } :
            new() { Data = product };
    }

    public async Task<ServiceResponse<List<Product>>> GetProducts(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _ecommDbContext.Products
                .Include(x => x.ProductVariants)
                .ToListAsync(cancellationToken)
        };

    public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl, CancellationToken cancellationToken) =>
        new()
        {
            Data = await _ecommDbContext.Products
                .Where(x => x.Category != null &&
                    x.Category.Url.ToLower() == categoryUrl.ToLower())
                .Include(x => x.ProductVariants)
                .ToListAsync(cancellationToken)
        };

    public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText, CancellationToken cancellationToken)
    {
        var productsSearch = await FindProductBySearchText(searchText, cancellationToken);

        List<string> results = new();

        foreach (var product in productsSearch) 
        {
            if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(product.Title);
            }

            if (product.Description is not null)
            {
                AddDescriptionToResults(searchText, product.Description, results);
            }
        }

        return new() { Data = results };
    }

    private static void AddDescriptionToResults(string searchText, 
        string description,
        List<string> results)
    {
        var punctuation = description.Where(char.IsPunctuation)
            .Distinct()
            .ToArray();

        var words = description
            .Split()
            .Select(x => x.Trim(punctuation));

        foreach (var word in words)
        {
            if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase) &&
                !results.Contains(word))
            {
                results.Add(word);
            }
        }
    }

    public async Task<ServiceResponse<List<Product>>> SearchProducts(string searchText, CancellationToken cancellationToken) =>
        new()
        {
            Data = await FindProductBySearchText(searchText, cancellationToken)
        };

    private async Task<List<Product>> FindProductBySearchText(string searchText, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
            .Where(x => x.Title.ToLower().Contains(searchText) || x.Description.ToLower().Contains(searchText))
            .Include(x => x.ProductVariants)
            .ToListAsync(cancellationToken);
}

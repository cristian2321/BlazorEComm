using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions;

public class ProductExtensionRepository : IProductExtensionRepository
{
    private readonly EcommDbContext _ecommDbContext;

    public ProductExtensionRepository(EcommDbContext ecommDbContext)
    {
        _ecommDbContext = ecommDbContext;
    }

    public async Task<bool> AnyDbProduct(string title, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products.AnyAsync(x => x.Title.ToLower() == title.ToLower(),
            cancellationToken);

    public async Task<List<Product>> FindProductsBySearchText(string searchText, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
            .Where(x => x.Visible && !x.Deleted &&
                x.Title.ToLower().Contains(searchText) || x.Description.ToLower().Contains(searchText))
            .Include(x => x.ProductVariants.Where(x => x.Visible && !x.Deleted &&
                x.ProductType != null && x.ProductType.Visible && !x.ProductType.Deleted))
            .Include(x => x.Images)
            .ToListAsync(cancellationToken);

    public async Task<List<Product>> FindProductsBySearchTextWithPage(string searchText, float pageResults, int page, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
            .Where(p => p.Visible && !p.Deleted && p.Title.ToLower().Contains(searchText.ToLower()) ||
                p.Description.ToLower().Contains(searchText.ToLower()))
            .Include(x => x.ProductVariants.Where(p => p.Visible && !p.Deleted &&
                p.ProductType != null && p.ProductType.Visible && !p.ProductType.Deleted))
            .Include(x => x.Images)
            .Skip((page - 1) * (int)pageResults)
            .Take((int)pageResults)
            .ToListAsync(cancellationToken);

    public async Task<ProductCartDto?> GetProductCartById(Guid productId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
            .Where(p => p.Id == productId && !p.Deleted)
            .Select(x => new ProductCartDto
            {
                Id = x.Id,
                Title = x.Title,
                ImageUrl = x.ImageUrl
            })
        .FirstOrDefaultAsync(cancellationToken);

    public async Task<List<Product>> GetAdminProducts(int page, int productsByPage, CancellationToken cancellationToken) => 
        await _ecommDbContext.Products
            .Where(x => !x.Deleted && x.Category != null)
            .Include(x => x.Category)
            .Include(x=> x.Images)
            .OrderByDescending(x => x.Featured)
            .Skip(page * productsByPage)
            .Take(productsByPage)
            .ToListAsync(cancellationToken);

    public async Task<Product?> GetProductWithCategory(Guid productId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
             .Where(x => x.Id == productId && !x.Deleted)
             .Include(x => x.Category)
             .Include(x => x.Images)
             .FirstOrDefaultAsync(cancellationToken);

    public async Task<List<string>> GetProductTitles(CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
            .Where(x => x.Visible && !x.Deleted)
            .OrderByDescending(x => x.Featured)
            .Select(x => x.Title)
            .ToListAsync(cancellationToken);

    public async Task<Guid> GetProductIdByTitle(string title, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
             .Where(p => p.Title.ToLower() == title.ToLower())
             .Select(x => x.Id)
             .FirstOrDefaultAsync(cancellationToken);

    public async Task<Product?> GetProduct(Guid productId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
            .Where(x => x.Id == productId && x.Visible && !x.Deleted)
            .Include(x => x.ProductVariants.Where(x => x.Visible && !x.Deleted && x.ProductType != null && 
                x.ProductType.Visible && !x.ProductType.Deleted))
            .ThenInclude(x => x.ProductType)
            .Include(x => x.Images)    
            .FirstOrDefaultAsync(cancellationToken);

    public async Task<List<Product>> GetProducts(CancellationToken cancellationToken) =>
        await _ecommDbContext.Products.Where(x => x.Visible && !x.Deleted)
            .Include(x => x.ProductVariants.Where(x => x.Visible && !x.Deleted &&
                x.ProductType != null && x.ProductType.Visible && !x.ProductType.Deleted))
            .ToListAsync(cancellationToken);

    public async Task<List<Product>> GetProductsByCategory(string categoryUrl, CancellationToken cancellationToken) =>
        await _ecommDbContext.Products
            .Where(x => x.Category != null &&       
                x.Category.Url.ToLower() == categoryUrl.ToLower() && x.Visible && !x.Deleted)
            .Include(x => x.ProductVariants.Where(x => x.Visible && !x.Deleted &&
                x.ProductType != null && x.ProductType.Visible && !x.ProductType.Deleted))
            .Include(x=>x.Images)
            .ToListAsync(cancellationToken);

    public async Task<List<Product>> GetFeaturedProducts(CancellationToken cancellationToken) => 
        await _ecommDbContext.Products
            .Where(x => x.Visible && !x.Deleted && x.Featured)
            .Include(x => x.ProductVariants.Where(x => x.Visible && !x.Deleted && 
                x.ProductType != null && x.ProductType.Visible && !x.ProductType.Deleted))
            .Include(x => x.Images)    
            .ToListAsync(cancellationToken);

    public void RemoveProductsImages(List<Image> images) =>
        _ecommDbContext.Images.RemoveRange(images);
}
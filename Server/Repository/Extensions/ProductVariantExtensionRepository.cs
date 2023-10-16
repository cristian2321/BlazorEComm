using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions;

public class ProductVariantExtensionRepository : IProductVariantExtensionRepository
{
    private readonly EcommDbContext _ecommDbContext;

    public ProductVariantExtensionRepository(EcommDbContext ecommDbContext) 
    { 
        _ecommDbContext = ecommDbContext;
    }

    public async Task<ProductVariantDto?> GetAdminProductVariant(Guid productId, Guid productTypeId, CancellationToken cancellationToken)
    {
        var productVariant = await (from pv in _ecommDbContext.ProductVariants
                                        .Where(x => !x.Deleted && x.ProductTypeId == productTypeId && x.ProductId == productId)
                                    join pt in _ecommDbContext.ProductTypes
                                        .Where(x => !x.Deleted && x.Id == productTypeId) on pv.ProductTypeId equals pt.Id
                                    join p in _ecommDbContext.Products
                                        .Where(x => !x.Deleted && x.Id == productId) on pv.ProductId equals p.Id
                                    select new ProductVariantDto
                                    {
                                        ProductId = productId,
                                        ProductTypeId = productTypeId,
                                        OriginalPrice = pv.OriginalPrice,
                                        Price = pv.Price,
                                        Product = p.Title,
                                        ProductType = pt.Name,
                                        Visible = pv.Visible,
                                    })
                                    .FirstOrDefaultAsync(cancellationToken);

        return productVariant;
    }

    public async Task<List<ProductVariantDto>> GetAdminProductVariants(CancellationToken cancellationToken) =>
        await ( from pv in _ecommDbContext.ProductVariants
                    .Where(x => !x.Deleted)
                join pt in _ecommDbContext.ProductTypes
                    .Where(x => !x.Deleted) on pv.ProductTypeId equals pt.Id
                join p in _ecommDbContext.Products
                    .Where(x => !x.Deleted) on pv.ProductId equals p.Id
                select new ProductVariantDto
                {
                    ProductId = pv.ProductId,
                    ProductTypeId = pv.ProductTypeId,
                    OriginalPrice = pv.OriginalPrice,
                    Price = pv.Price,
                    Product = p.Title,
                    ProductType = pt.Name,
                    Visible = pv.Visible,
                })
                .ToListAsync(cancellationToken);

    public async Task<ProductTypeCartDto?> GetProductTypeCart(Guid productId, Guid productTypeId, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductVariants
            .Where(v => !v.Deleted &&
                v.ProductId == productId &&
                v.ProductTypeId == productTypeId &&
                v.ProductType != null &&
                !v.ProductType.Deleted)
            .Include(v => v.ProductType)
            .Select(x => new ProductTypeCartDto
            {
                Price = x.Price,
                ProductTypeId = x.ProductTypeId,
                ProductTypeName = x.ProductType!.Name
            })
            .FirstOrDefaultAsync(cancellationToken);

    public async Task<ProductVariant?> GetProductVariantByProductIdAndProductTypeId(Guid productId, Guid productTypeId, CancellationToken cancellationToken) => 
        await _ecommDbContext.ProductVariants.FirstOrDefaultAsync(x => x.ProductId == productId && x.ProductTypeId == productTypeId && !x.Deleted, cancellationToken);

    public async Task<List<ProductVariantDto>> GetProductVariants(CancellationToken cancellationToken) =>
        await ( from pv in _ecommDbContext.ProductVariants
                    .Where(x => x.Visible && !x.Deleted)
                join pt in _ecommDbContext.ProductTypes
                    .Where(x => x.Visible && !x.Deleted) on pv.ProductTypeId equals pt.Id
                join p in _ecommDbContext.Products
                    .Where(x => x.Visible && !x.Deleted) on pv.ProductId equals p.Id
                select new ProductVariantDto
                {
                    ProductId = pv.ProductId,
                    ProductTypeId = pv.ProductTypeId,
                    OriginalPrice = pv.OriginalPrice,
                    Price = pv.Price,
                    Product = p.Title,
                    ProductType = pt.Name,
                    Visible = pv.Visible,
                })
                .ToListAsync(cancellationToken);

    public async Task<List<ProductVariant>?> GetProductVariantsByProductId(Guid productId, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductVariants
            .Where(x => x.ProductId == productId && !x.Deleted)
            .ToListAsync(cancellationToken);

    public async Task<List<ProductVariant>?> GetProductVariantsByProductTypeId(Guid productTypeId, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductVariants
            .Where(x => x.ProductTypeId == productTypeId && !x.Deleted)
            .ToListAsync(cancellationToken);

    public async Task<List<ProductVariant>?> GetProductVariantsNotVisibleByProductId(Guid productId, CancellationToken cancellationToken) => 
        await _ecommDbContext.ProductVariants
            .Where(x => x.ProductId == productId && !x.Visible && !x.Deleted)
            .ToListAsync(cancellationToken);

    public async Task<List<ProductVariant>?> GetProductVariantsNotVisibleByProductTypeId(Guid productTypeId, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductVariants
            .Where(x => x.ProductTypeId == productTypeId && !x.Visible && !x.Deleted)
            .ToListAsync(cancellationToken);

    public async Task<List<ProductVariant>?> GetProductVariantsVisibleByProductId(Guid productId, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductVariants
          .Where(x => x.ProductId == productId && x.Visible && !x.Deleted)
          .ToListAsync(cancellationToken);

    public async Task<List<ProductVariant>?> GetProductVariantsVisibleByProductTypeId(Guid productTypeId, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductVariants
            .Where(x => x.ProductTypeId == productTypeId && x.Visible && !x.Deleted)
            .ToListAsync(cancellationToken);
}
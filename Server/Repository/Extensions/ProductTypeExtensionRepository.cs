using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions;

public class ProductTypeExtensionRepository : IProductTypeExtensionRepository
{
    private readonly EcommDbContext _ecommDbContext;

    public ProductTypeExtensionRepository(EcommDbContext ecommDbContext)
    {
        _ecommDbContext = ecommDbContext;
    }

    public async Task<bool> AnyDbProductType(string name, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductTypes.AnyAsync(x => x.Name.ToLower() == name.ToLower() && !x.Deleted, cancellationToken);

    public async Task<List<ProductType>> GetAdminProductTypes(CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductTypes
            .Where(x => !x.Deleted)
            .ToListAsync(cancellationToken);
    
    public async Task<List<ProductType>> GetProductTypes(CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductTypes
            .Where(x => x.Visible && !x.Deleted)
            .ToListAsync(cancellationToken);

    public async Task<List<string>> GetProductTypeNames(CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductTypes
            .Where(x => !x.Deleted)
            .Select(x => x.Name)
            .ToListAsync(cancellationToken);

    public async Task<Guid> GetProductTypeIdByName(string name, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductTypes
            .Where(p => p.Name.ToLower() == name.ToLower() && !p.Deleted)
            .Select(x => x.Id)
            .FirstOrDefaultAsync(cancellationToken);

    public async Task<ProductType?> GetProductTypeById(Guid productTypeId, CancellationToken cancellationToken) =>
        await _ecommDbContext.ProductTypes.FirstOrDefaultAsync(x => !x.Deleted && x.Id == productTypeId, cancellationToken);
}
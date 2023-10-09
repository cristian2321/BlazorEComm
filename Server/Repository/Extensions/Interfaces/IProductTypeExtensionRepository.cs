using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface IProductTypeExtensionRepository
{
    Task<bool> AnyDbProductType(string name, CancellationToken cancellationToken);

    Task<List<ProductType>> GetAdminProductTypes(CancellationToken cancellationToken);

    Task<List<ProductType>> GetProductTypes(CancellationToken cancellationToken);

    Task<List<string>> GetProductTypeNames(CancellationToken cancellationToken);

    Task<Guid> GetProductTypeIdByName(string name, CancellationToken cancellationToken);

    Task<ProductType?> GetProductTypeById(Guid productTypeId, CancellationToken cancellationToken);
}
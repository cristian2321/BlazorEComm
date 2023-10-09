using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductTypeService;

public interface IProductTypeService
{
    Task<ServiceResponse<List<ProductType>>> AddProductType(ProductType productType, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductType>>> DeleteProductType(Guid productTypeId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductType>>> GetAdminProductTypes(CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductType>>> GetProductTypes(CancellationToken cancellationToken);

    Task<ServiceResponse<ProductType?>> GetAdminProductType(Guid productTypeId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductType>>> UpdateProductType(ProductType productType, CancellationToken cancellationToken);
 
    Task<ServiceResponse<List<string>>> GetProductTypeNames(CancellationToken cancellationToken);

    Task<Guid> GetProductTypeIdByName(string name, CancellationToken cancellationToken);
}
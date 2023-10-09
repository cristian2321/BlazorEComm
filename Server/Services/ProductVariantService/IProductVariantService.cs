using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Server.Services.ProductVariantService;

public interface IProductVariantService
{
    Task<ServiceResponse<List<ProductVariantDto>>> AddProductVariant(ProductVariantDto productVariant, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductVariantDto>>> DeleteProductVariant(Guid productId, Guid productTypeId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductVariantDto>>> GetAdminProductVariants(CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductVariantDto>>> GetProductVariants(CancellationToken cancellationToken);

    Task<ServiceResponse<ProductVariantDto?>> GetAdminProductVariant(Guid productId, Guid productTypeId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ProductVariantDto>>> UpdateProductVariant(ProductVariantDto productVariant, CancellationToken cancellationToken);
}
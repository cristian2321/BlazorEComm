using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface IProductVariantExtensionRepository
{
    Task<ProductTypeCartDto?> GetProductTypeCart(Guid productId, Guid productTypeId, CancellationToken cancellationToken);

    Task<List<ProductVariant>?> GetProductVariantsByProductId(Guid productId, CancellationToken cancellationToken);

    Task<List<ProductVariant>?> GetProductVariantsByProductTypeId(Guid productTypeId, CancellationToken cancellationToken);

    Task<List<ProductVariant>?> GetProductVariantsVisibleByProductTypeId(Guid productTypeId, CancellationToken cancellationToken);

    Task<List<ProductVariant>?> GetProductVariantsNotVisibleByProductTypeId(Guid productTypeId, CancellationToken cancellationToken);

    Task<List<ProductVariant>?> GetProductVariantsNotVisibleByProductId(Guid productId, CancellationToken cancellationToken);

    Task<List<ProductVariant>?> GetProductVariantsVisibleByProductId(Guid productId, CancellationToken cancellationToken);

    Task<ProductVariant?> GetProductVariantByProductIdAndProductTypeId(Guid productId, Guid productTypeId, CancellationToken cancellationToken);

    Task<ProductVariantDto?> GetAdminProductVariant(Guid productId, Guid productTypeId, CancellationToken cancellationToken);

    Task<List<ProductVariantDto>> GetAdminProductVariants(CancellationToken cancellationToken);

    Task<List<ProductVariantDto>> GetProductVariants(CancellationToken cancellationToken);
}
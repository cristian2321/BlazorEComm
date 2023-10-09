using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ProductVariantService;

public interface IProductVariantService
{
    event Action? OnChange;

    List<ProductVariantDto> AdminProductVariants { get; set; }

    List<ProductVariantDto> ProductVariants { get; set; }

    Task GetAdminProductVariants();

    Task GetProductVariants();

    Task<ProductVariantDto?> GetAdminProductVariant(Guid productId, Guid productTypeId);

    Task AddProductVariant(ProductVariantDto productVariant);

    Task UpdateProductVariant(ProductVariantDto productVariant);

    Task<bool> DeleteProductVariant(Guid productId, Guid productTypeId);
}
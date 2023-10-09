using BlazorEComm.Shared.Models;

namespace BlazorEComm.Shared.Dtos;

public class ProductVariantDto
{
    public Guid ProductId { get; set; }

    public Guid ProductTypeId { get; set; }

    public string Product { get; set; } = string.Empty;

    public string ProductType { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public decimal OriginalPrice { get; set; }

    public bool Visible { get; set; }

    public bool Deleted { get; set; }
}

public static class ProductVariantExtension
{
    public static ProductVariant GetProductVariantFromProductVariantDto(this ProductVariantDto productVariant)
    {
        return new ProductVariant
        {
            Deleted = productVariant.Deleted,
            OriginalPrice = productVariant.OriginalPrice,
            Price = productVariant.Price,
            ProductId = productVariant.ProductId,
            ProductTypeId = productVariant.ProductTypeId,
            Visible = productVariant.Visible
        };
    }
}
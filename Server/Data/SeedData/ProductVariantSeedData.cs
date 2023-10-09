using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Data.SeedData;

internal class ProductVariantSeedData
{
    internal static ProductVariant[] GetProductVariants() =>
        new ProductVariant[]
        {
            new ()
            {
                ProductId = SeedDataId.IdProduct1,
                ProductTypeId = SeedDataId.IdProductType2,
                Price = 9.99m,
                OriginalPrice = 19.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct1,
                ProductTypeId = SeedDataId.IdProductType3,
                Price = 7.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct1,
                ProductTypeId = SeedDataId.IdProductType4,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct2,
                ProductTypeId = SeedDataId.IdProductType2,
                Price = 7.99m,
                OriginalPrice = 14.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct3,
                ProductTypeId = SeedDataId.IdProductType2,
                Price = 6.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct4,
                ProductTypeId = SeedDataId.IdProductType5,
                Price = 3.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct4,
                ProductTypeId = SeedDataId.IdProductType6,
                Price = 9.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct4,
                ProductTypeId = SeedDataId.IdProductType7,
                Price = 19.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct5,
                ProductTypeId = SeedDataId.IdProductType5,
                Price = 3.99m,
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct6,
                ProductTypeId = SeedDataId.IdProductType5,
                Price = 2.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct7,
                ProductTypeId = SeedDataId.IdProductType8,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct7,
                ProductTypeId = SeedDataId.IdProductType9,
                Price = 69.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct7,
                ProductTypeId = SeedDataId.IdProductType10,
                Price = 49.99m,
                OriginalPrice = 59.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct8,
                ProductTypeId = SeedDataId.IdProductType8,
                Price = 9.99m,
                OriginalPrice = 24.99m,
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct9,
                ProductTypeId = SeedDataId.IdProductType8,
                Price = 14.99m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct10,
                ProductTypeId = SeedDataId.IdProductType1,
                Price = 159.99m,
                OriginalPrice = 299m
            },
            new ()
            {
                ProductId = SeedDataId.IdProduct4,
                ProductTypeId = SeedDataId.IdProductType1,
                Price = 79.99m,
                OriginalPrice = 399m
            }
        };
}

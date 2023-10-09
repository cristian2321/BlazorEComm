using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Data.SeedData;

internal class ProductTypeSeedData
{
    internal static ProductType[] GetProductTypes() =>
        new ProductType[]
        {
            new () { Id = SeedDataId.IdProductType1, Name = "Default" },
            new () { Id = SeedDataId.IdProductType2, Name = "Paperback" },
            new () { Id = SeedDataId.IdProductType3, Name = "E-Book" },
            new () { Id = SeedDataId.IdProductType4, Name = "Audiobook" },
            new () { Id = SeedDataId.IdProductType5, Name = "Stream" },
            new () { Id = SeedDataId.IdProductType6, Name = "Blu-ray" },
            new () { Id = SeedDataId.IdProductType7, Name = "VHS" },
            new () { Id = SeedDataId.IdProductType8, Name = "PC" },
            new () { Id = SeedDataId.IdProductType9, Name = "PlayStation" },
            new () { Id = SeedDataId.IdProductType10, Name = "Xbox" }
        };
}
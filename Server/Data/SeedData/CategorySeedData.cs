using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Data.SeedData;

internal static class CategorySeedData
{
    internal static Category[] GetCategories() =>
        new Category[]
        {
            new ()
            {
                Id =SeedDataId.IdCategory1,
                Name = "Books",
                Url = "books"
            },
            new ()
            {
                Id = SeedDataId.IdCategory2,
                Name = "Movies",
                Url = "movie"
            },
            new ()
            {
                Id = SeedDataId.IdCategory3,
                Name = "Video Games",
                Url = "video-games"
            }
        };
}

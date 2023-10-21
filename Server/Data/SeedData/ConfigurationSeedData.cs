using BlazorEComm.Shared.Constants;
using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Data.SeedData;

internal class ConfigurationSeedData
{
    const string Language = "en";

    internal static Configuration[] GetConfigurations() =>
        new Configuration[]
        {
            new ()
            {
                Id = Guid.NewGuid(),
                Key = "ProductsByPage",
                Type = "Configurations Product",
                Value = "5",
                Language = Language
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Key = ClientConstants.DefaultLanguage,
                Type = "Configurations Company",
                Value = Language
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Key = ClientConstants.CompanyName,
                Value = "Cristian Company",
                Type = "Configurations Company",
                Language = Language,
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Key = ClientConstants.MessageLoadingProducts,
                Value = MessagesClientPages.MessageLoadingProduct,
                Type = "Configurations Messages",
                Language = Language,
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Key = ClientConstants.NoProductsFound,
                Value = MessagesClientServices.MessageNoProductsFound,
                Type = "Configurations Messages",
                Language = Language,
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Key = ClientConstants.TitleFeaturedProducts,
                Value = "Top Products of Today",
                Type = "Configurations Product",
                Language = Language,
            },
        };
}
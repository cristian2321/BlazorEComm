using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Data.SeedData;

internal class ConfigurationSeedData
{
    internal static Configuration[] GetConfigurations() =>
        new Configuration[]
        {
            new ()
            {
                Id = SeedDataId.IdConfig1,
                Key = "ProductsByPage",
                Value = "5"
            } 
        };
}
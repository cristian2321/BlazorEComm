using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface IConfigurationExtensionRepository
{
    Task<bool> AnyConfigurationDb(Configuration configuration, CancellationToken cancellationToken);

    Task<Configuration?> GetConfiguration(string configurationKey, string configurationLanguage, CancellationToken cancellationToken);

    Task<List<Configuration>> GetConfigurations(CancellationToken cancellationToken);

    Task<string?> GetConfigurationValue(string configurationKey, string configurationLanguage, CancellationToken cancellationToken);
}

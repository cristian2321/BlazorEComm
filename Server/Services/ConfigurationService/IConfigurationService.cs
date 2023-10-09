using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ConfigurationService;

public interface IConfigurationService 
{
    Task<ServiceResponse<string>> GetConfigValue(string configKey, CancellationToken cancellationToken);

    Task<ServiceResponse<Configuration>> GetConfiguration(Guid configurationId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<Configuration>>> GetConfigurations(CancellationToken cancellationToken);

    Task<ServiceResponse<List<Configuration>>> AddConfiguration(Configuration configuration, CancellationToken cancellationToken);

    Task<ServiceResponse<List<Configuration>>> DeleteConfiguration(Guid configurationId, CancellationToken cancellationToken);

    Task<ServiceResponse<List<Configuration>>> UpdateConfiguration(Configuration configuration, CancellationToken cancellationToken);
}
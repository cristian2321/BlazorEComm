using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Server.Services.ConfigurationService;

public interface IConfigurationService 
{
    Task<ServiceResponse<string>> GetConfigurationValue(string configurationKey, string configurationLanguage, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ConfigurationDto>>> GetConfigurations(CancellationToken cancellationToken);

    Task<ServiceResponse<List<ConfigurationDto>>> AddConfiguration(ConfigurationDto configuration, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ConfigurationDto>>> DeleteConfiguration(string configurationKey, string configurationLanguage, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ConfigurationDto>>> UpdateConfiguration(ConfigurationDto configuration, CancellationToken cancellationToken);
}
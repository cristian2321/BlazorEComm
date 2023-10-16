using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ConfigurationService;

public interface IConfigurationService
{
    Task<ServiceResponse<Configuration?>> GetConfiguration(string confugrationKey, string configurationLanguage, CancellationToken cancellationToken);

    Task<ServiceResponse<string>> GetConfigurationValue(string configurationKey, string configurationLanguage, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ConfigurationDto>>> GetConfigurations(CancellationToken cancellationToken);

    Task<ServiceResponse<List<ConfigurationDto>>> AddConfiguration(ConfigurationDto configuration, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ConfigurationDto>>> DeleteConfiguration(string configurationKey, string configurationLanguage, CancellationToken cancellationToken);

    Task<ServiceResponse<List<ConfigurationDto>>> UpdateConfiguration(ConfigurationDto configuration, CancellationToken cancellationToken);
}
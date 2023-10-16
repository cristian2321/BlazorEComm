using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ConfigurationService;

public interface IConfigurationService
{
    List<ConfigurationDto> ConfgurationAppConfigurations { get; }

    event Action? OnChange;

    Task GetConfigurations();

    Task<Configuration?> GetConfiguration(string configurationKey, string configurationLanguage);

    Task<string?> GetConfigurationValue(string configurationKey);

    Task AddConfiguration(ConfigurationDto configuration);
    
    Task<bool> DeleteConfiguration(string configurationKey, string configurationLanguage);
    
    Task UpdateConfiguration(ConfigurationDto configuration);
}
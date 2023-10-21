using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ConfigurationService;

public interface IConfigurationService
{
    List<ConfigurationDto> ConfgurationAppConfigurations { get; }

    List<string>? ConfigurationsKeys { get; set; }

    event Action? OnChange;

    Task GetConfigurations(bool updateConfigurations = false);

    Task<Configuration?> GetConfiguration(string configurationKey, string configurationLanguage);

    Task<List<ConfigurationDto>?> GetConfigurationsByKeysAndType(string configurationType);

    Task<string?> GetConfigurationValue(string configurationKey);

    Task AddConfiguration(ConfigurationDto configuration);
    
    Task<bool> DeleteConfiguration(string configurationKey, string configurationLanguage);
    
    Task UpdateConfiguration(ConfigurationDto configuration);

    Task AddConfigurationsKeys(string configurationKey);
}
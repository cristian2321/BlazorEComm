using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ConfigurationService;

public interface IConfigurationService
{
    event Action? OnChange;

    Task GetConfigurations();

    Task<string?> GetConfigurationValue(string configurationKey);

    Task AddConfiguration(ConfigurationDto configuration);
    
    Task<bool> DeleteConfiguration(Guid configurationId);
    
    Task UpdateConfiguration(ConfigurationDto configuration);
}
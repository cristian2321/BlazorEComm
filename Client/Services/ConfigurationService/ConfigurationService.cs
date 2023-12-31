﻿using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ConfigurationService;

public class ConfigurationService : IConfigurationService
{
    private readonly HttpClient _httpClient;
    private readonly ConfigurationAppDto _configurationApp;

    public ConfigurationService(HttpClient httpClient, ConfigurationAppDto configurationApp)
    {
        _httpClient = httpClient;
        _configurationApp = configurationApp;
    }

    public event Action? OnChange;

    public List<string>? ConfigurationsKeys { get; set; }

    public List<ConfigurationDto> ConfgurationAppConfigurations => _configurationApp.Configurations;

    public async Task AddConfiguration(ConfigurationDto configuration)
    {
        var response = await _httpClient.PostAsJsonAsync(ClientApiEndpoints.AdminConfigurationApiUrl, configuration);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    public async Task<bool> DeleteConfiguration(string configurationKey, string configurationLanguage)
    {
        var response = await _httpClient.DeleteAsync
            ($"{ClientApiEndpoints.AdminConfigurationApiUrl}/{configurationKey}/{configurationLanguage}");
        
        if (response is null || !response.IsSuccessStatusCode)
        {
            return !ClientConstants.IsSucces;
        }

        await AfterResponseForAddDeleteAndUpdate(response);

        return ClientConstants.IsSucces;
    }

    public async Task<string?> GetConfigurationValue(string configurationKey)
    {
        if (_configurationApp is null || _configurationApp.Configurations is null || !_configurationApp.Configurations.Any())
        {
            await GetConfigurations(ClientConstants.UpdateConfigurations);
        }

        return _configurationApp!.Configurations!.Where(x => x.Key.ToLower() == configurationKey.ToLower() &&
                x.Language.ToLower() == _configurationApp.Language.ToLower() && x.Activ)
            .Select(x => x.Value).FirstOrDefault();
    }

    public async Task<List<ConfigurationDto>?> GetConfigurationsByKeysAndType(string configurationType)
    {
        if (_configurationApp is null || _configurationApp.Configurations is null || !_configurationApp.Configurations.Any())
        {
            await GetConfigurations(ClientConstants.UpdateConfigurations);
        }
        
        return _configurationApp!.Configurations!.Where(x=> ConfigurationsKeys!.Contains(x.Key) &&
                x.Type.ToLower() == configurationType.ToLower() &&
                x.Language.ToLower() == _configurationApp.Language.ToLower() && x.Activ)
            .ToList(); 
    }

    public async Task GetConfigurations(bool updateConfigurations = false)
    {
        if (updateConfigurations || _configurationApp.Configurations is null || !_configurationApp.Configurations.Any())
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ConfigurationDto>>>
                (ClientApiEndpoints.ConfigurationsUrl);
                if (response is not null && response.Data is not null && response.Succes)
                {
                    _configurationApp.Configurations = response.Data;
                    _configurationApp.Language = _configurationApp.Configurations
                        .Where(x => x.Key == ClientConstants.DefaultLanguage && x.Activ)
                        .Select(x => x.Value)
                        .FirstOrDefault() ?? string.Empty;

                    OnChange?.Invoke();
                }
            }    
    }

    public async Task UpdateConfiguration(ConfigurationDto configuration)
    {
        var response = await _httpClient.PutAsJsonAsync(ClientApiEndpoints.AdminConfigurationApiUrl, configuration);
        await AfterResponseForAddDeleteAndUpdate(response);
    }

    public async Task<Configuration?> GetConfiguration(string configurationKey, string configurationLanguage)
    {
        var response = await _httpClient.GetFromJsonAsync<ServiceResponse<Configuration?>>
         ($"{ClientApiEndpoints.AdminConfigurationApiUrl}/{nameof(Configuration)}/{configurationKey}/{configurationLanguage}");

        return response is not null && response.Data is not null && response.Succes ?
            response.Data : default;
    }

    public async Task AddConfigurationsKeys(string configurationKey) 
    {
        await InitializeConfigurationsKeys();

        if (!ConfigurationsKeys!.Contains(configurationKey))
        {
            ConfigurationsKeys!.Add(configurationKey);
        } 
    }

    private Task InitializeConfigurationsKeys()
    {
        if (ConfigurationsKeys is null || !ConfigurationsKeys.Any())
        {
            ConfigurationsKeys ??= new List<string>();

            ConfigurationsKeys.AddRange(new List<string> { ClientConstants.AddButtonTitle, ClientConstants.DeleteButtonTitle, ClientConstants.UpdateButtonTitle });
        }

        return Task.CompletedTask;
    }

    private async Task AfterResponseForAddDeleteAndUpdate(HttpResponseMessage response)
    {
        var responseConfigurations = (await response.Content.ReadFromJsonAsync<ServiceResponse<List<ConfigurationDto>>>());
        if (responseConfigurations is not null && responseConfigurations.Data is not null && responseConfigurations.Succes)
        {
            _configurationApp.Configurations = responseConfigurations.Data;
            _configurationApp.Language = _configurationApp.Configurations
                .Where(x => x.Key == ClientConstants.DefaultLanguage && x.Activ)
                .Select(x => x.Value)
                .FirstOrDefault() ?? string.Empty;
        }

        await GetConfigurations(ClientConstants.UpdateConfigurations);
    }
}
using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ConfigurationService;

public class ConfigurationService : IConfigurationService
{
    private readonly IRepository _repository;
    private readonly IConfigurationExtensionRepository _configurationExtensionRepository;

    public ConfigurationService(IRepository repository, IConfigurationExtensionRepository configurationExtensionRepository)
    {
        _repository = repository;
        _configurationExtensionRepository = configurationExtensionRepository;
    }

    public async Task<ServiceResponse<List<ConfigurationDto>>> AddConfiguration(ConfigurationDto configuration, CancellationToken cancellationToken)
    {
        var dbConfiguration = configuration.GetConfigurationFromConfigurationDto();

        if (!await _configurationExtensionRepository.AnyConfigurationDb(dbConfiguration, cancellationToken))
        {
            var added = _repository.Add(dbConfiguration);
            if (added)
            {
                _ = await _repository.SaveChangesAsync(cancellationToken);
            }
        }

        return await GetConfigurations(cancellationToken);
    }

    public async Task<ServiceResponse<List<ConfigurationDto>>> GetConfigurations(CancellationToken cancellationToken)
    {
        var data = new List<ConfigurationDto>();    
      
        var configurations = await _configurationExtensionRepository.GetConfigurations(cancellationToken);
        if (configurations is not null && configurations.Any())
        {
            configurations.ForEach(x => data.Add(x.GetConfigurationDtoFromConfiguration()));
        }

        return new()
        {
            Data = data
                .OrderBy(x => x.Type)
                .ThenBy(x=>x.Key)
                .ThenBy(x=> x.Language)
                .ToList()
        };
    }

    public async Task<ServiceResponse<string>> GetConfigurationValue(string configurationKey, string configurationLanguage, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        string? configurationValue = await _configurationExtensionRepository.GetConfigurationValue(configurationKey, configurationLanguage, cancellationToken);

        return configurationValue is null ?
            new()
            {
                Message = MessagesServerServices.MessageProductNotFound,
                Succes = !ConstantServerServices.IsSucces
            }:
            new() 
            {
                Data = configurationValue 
            };
    }

    public async Task<ServiceResponse<Configuration?>> GetConfiguration(string confugrationKey, string configurationLanguage, CancellationToken cancellationToken)
    {
        var configuration = await _configurationExtensionRepository.GetConfiguration(confugrationKey, configurationLanguage, cancellationToken);

        return configuration is null ?
            new()
            {
                Message = MessagesServerServices.MessageConfigNotFound,
                Succes = !ConstantServerServices.IsSucces
            } :
            new()
            {
                Data = configuration
            };
    }

    public async Task<ServiceResponse<List<ConfigurationDto>>> DeleteConfiguration(string configurationKey, string configurationLanguage, CancellationToken cancellationToken)
    {
        var configuration = (await GetConfiguration(configurationKey, configurationLanguage, cancellationToken)).Data;
        if (configuration is null)
        {
            return new ()
            {
                Message = MessagesServerServices.MessageProductNotFound,
                Succes = !ConstantServerServices.IsSucces
            };
        }

        configuration.Activ = !ConstantServerServices.IsActiv;
        configuration.Deleted = ConstantServerServices.IsDelete;

        var updated = _repository.Update(configuration);
        if (updated)
        {
            _ = await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetConfigurations(cancellationToken);
    }

    public async Task<ServiceResponse<List<ConfigurationDto>>> UpdateConfiguration(ConfigurationDto configuration, CancellationToken cancellationToken)
    {
        var dbConfiguration = (await GetConfiguration(configuration.Key, configuration.Language, cancellationToken)).Data;
        if (dbConfiguration is null)
        {
            return new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageProductTypeNotFound
            };
        }

        dbConfiguration.Activ = configuration.Activ;
        dbConfiguration.Value = configuration.Value;
        dbConfiguration.Key = configuration.Key;

        var updated = _repository.Update(dbConfiguration);
        
        if (updated) 
        {
            _ = await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetConfigurations(cancellationToken);
    }
}
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

    public async Task<ServiceResponse<List<Configuration>>> AddConfiguration(Configuration configuration, CancellationToken cancellationToken)
    {
        if (!await _configurationExtensionRepository.AnyConfigurationDb(configuration, cancellationToken))
        {
            var added = _repository.Add(configuration);
            if (added)
            {
                _ = await _repository.SaveChangesAsync(cancellationToken);
            }
        }

        return await GetConfigurations(cancellationToken);
    }

    public async Task<ServiceResponse<Configuration>> GetConfiguration(Guid configurationId, CancellationToken cancellationToken)
    {
        var configuration = await _configurationExtensionRepository.GetConfiguration(configurationId, cancellationToken);

        return configuration is null ?
            new()
            {
                Message = MessagesServerServices.MessageProductNotFound,
                Succes = !ConstantServerServices.IsSucces
            }:
            new() 
            { 
                Data = configuration 
            };
    }

    public async Task<ServiceResponse<List<Configuration>>> GetConfigurations(CancellationToken cancellationToken) =>
        new ()
        {
            Data = await _configurationExtensionRepository.GetConfigurations(cancellationToken)
        };

    public async Task<ServiceResponse<string>> GetConfigValue(string configurationKey, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        string? configurationValue = await _configurationExtensionRepository.GetConfigurationValue(configurationKey, cancellationToken);

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

    public async Task<ServiceResponse<List<Configuration>>> DeleteConfiguration(Guid configurationId, CancellationToken cancellationToken)
    {
        var configuration = (await GetConfiguration(configurationId, cancellationToken)).Data;
        if (configuration is null)
        {
            return new ()
            {
                Message = MessagesServerServices.MessageProductNotFound,
                Succes = !ConstantServerServices.IsSucces
            };
        }

        configuration.Activ = !ConstantServerServices.IsActiv;

        var updated = _repository.Update(configuration);
        if (updated)
        {
            _ = await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetConfigurations(cancellationToken);
    }

    public async Task<ServiceResponse<List<Configuration>>> UpdateConfiguration(Configuration configuration, CancellationToken cancellationToken)
    {
        var dbConfiguration = (await GetConfiguration(configuration.Id, cancellationToken)).Data;
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
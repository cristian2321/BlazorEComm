﻿using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public class ConfigurationExtensionRepository : IConfigurationExtensionRepository
{
    private readonly EcommDbContext _ecommDbContext;

    public ConfigurationExtensionRepository(EcommDbContext ecommDbContext)
    {
        _ecommDbContext = ecommDbContext;
    }

    public async Task<bool> AnyConfigurationDb(Configuration configuration, CancellationToken cancellationToken) => 
        await _ecommDbContext.Configurations.AnyAsync(x => x.Key.ToLower() == configuration.Key.ToLower(), cancellationToken);

    public async Task<Configuration?> GetConfiguration(string configurationKey, string configurationLanguage, CancellationToken cancellationToken) =>
        await _ecommDbContext.Configurations.FirstOrDefaultAsync(x => x.Key.ToLower() == configurationKey.ToLower() &&
                configurationLanguage.ToLower() == x.Language.ToLower() &&
                x.Activ, cancellationToken);

    public async Task<List<Configuration>> GetConfigurations(CancellationToken cancellationToken) =>
        await _ecommDbContext.Configurations.Where(x => x.Activ)
                .ToListAsync(cancellationToken);

    public async Task<string?> GetConfigurationValue(string configurationKey, string configurationLanguage, CancellationToken cancellationToken) => 
        string.IsNullOrWhiteSpace(configurationLanguage) ?     
            
            await _ecommDbContext.Configurations.Where(x => x.Key.ToLower() == configurationKey.ToLower() && x.Activ)
                .Select(x => x.Value)
                .FirstOrDefaultAsync(cancellationToken) :
            
            await _ecommDbContext.Configurations.Where(x => x.Key.ToLower() == configurationKey.ToLower() && 
                    configurationLanguage.ToLower() == x.Language.ToLower() && x.Activ)
                .Select(x => x.Value)
                .FirstOrDefaultAsync(cancellationToken);
}
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Shared.Dtos;

public class ConfigurationDto
{
    public string Key { get; set; } = string.Empty;

    public string Value { get; set; } = string.Empty;

    public string Language { get; set; } = string.Empty;

    public bool Activ { get; set; }
}

public static class ConfigurationExtension 
{
    public static ConfigurationDto GetConfigurationDtoFromConfiguration(this Configuration configuration) 
    {
        return new()
        {
            Key = configuration.Key,
            Language = configuration.Language,
            Value = configuration.Value,
            Activ = configuration.Activ
        };
    }

    public static Configuration GetConfigurationFromConfigurationDto(this ConfigurationDto configuration)
    {
        return new()
        {
            Key = configuration.Key,
            Language = configuration.Language,
            Value = configuration.Value,
            Activ = configuration.Activ
        };
    }
}
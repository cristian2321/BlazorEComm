using BlazorEComm.Shared.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorEComm.Shared.Dtos;

public class ConfigurationDto
{
    [Required, MaxLength(256)]
    public string Key { get; set; } = string.Empty;
   
    [Required, MaxLength(256)]
    public string Value { get; set; } = string.Empty;

    [Required, MaxLength(256)]
    public string Type { get; set; } = string.Empty;

    [Required, MaxLength(256)]
    public string Language { get; set; } = string.Empty;

    public bool Activ { get; set; }
}

public static class ConfigurationExtension 
{
    public static ConfigurationDto GetConfigurationDtoFromConfiguration(this Configuration configuration) => 
        new()
        {
            Key = configuration.Key,
            Language = configuration.Language,
            Value = configuration.Value,
            Type = configuration.Type,
            Activ = configuration.Activ
        };

    public static Configuration GetConfigurationFromConfigurationDto(this ConfigurationDto configuration) => 
        new()
        {
            Key = configuration.Key,
            Language = configuration.Language,
            Value = configuration.Value,
            Type = configuration.Type,
            Activ = configuration.Activ
        };
}
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.ConfigurationService;

public class ConfigurationAppDto
{
    public List<ConfigurationDto> Configurations { get; set; } = new();

    public string Language { get; set; } = string.Empty;
}
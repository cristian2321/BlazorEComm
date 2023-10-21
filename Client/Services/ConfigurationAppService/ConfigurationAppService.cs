namespace BlazorEComm.Client.Services.ConfigurationAppService;

public class ConfigurationAppService : IConfigurationAppService
{
    private readonly IConfigurationService _configurationService;

    public bool CallConfigurationService { get; set; }

    public ConfigurationAppService(IConfigurationService configurationService)
    {
        _configurationService = configurationService;
    }

    public async Task ConfigurationAppIntialize() => 
        await _configurationService.GetConfigurations();
}

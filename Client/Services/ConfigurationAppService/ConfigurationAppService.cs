namespace BlazorEComm.Client.Services.ConfigurationAppService;

public class ConfigurationAppService : IConfigurationAppService
{
    private readonly IConfigurationService _configurationService;
    private readonly ConfigurationAppDto? _configurationApp;

    public bool CallConfigurationService { get; set; }

    public ConfigurationAppService(IConfigurationService configurationService, ConfigurationAppDto? configurationApp)
    {
        _configurationService = configurationService;
        _configurationApp = configurationApp;
    }

    public async Task ConfigurationAppIntialize() 
    {
        if (!CallConfigurationService)
        {
            if (_configurationApp is null || _configurationApp.Configurations is null || !_configurationApp.Configurations.Any())
            {
                await _configurationService.GetConfigurations();

                CallConfigurationService = ClientConstants.CallConfigurationService;
            }
        } 
    }
}

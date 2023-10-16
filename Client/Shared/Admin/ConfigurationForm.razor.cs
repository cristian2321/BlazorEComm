using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared.Admin;

public partial class ConfigurationForm
{
    [Inject]
    public IConfigurationService ConfigurationService { get; set; } = default!;

    [Inject]
    public IRedirectService RedirectService { get; set; } = default!;

    [Parameter, EditorRequired]
    public bool Add { get; set; }

    [Parameter]
    public string ConfigurationKey { get; set; } = string.Empty;
    
    [Parameter]
    public string ConfigurationLanguage { get; set; } = string.Empty;

    private string _submitText = string.Empty;
    private ConfigurationDto _configuration = new();

    protected override async Task OnInitializedAsync()
    {
        if (Add)
        {
            _submitText = MessagesClientSharedComponements.AddConfigurationSubmit;
        }
        else
        {
            _submitText = MessagesClientSharedComponements.UpdateConfigurationSubmit;
            var configuration = await ConfigurationService.GetConfiguration(ConfigurationKey, ConfigurationLanguage);
            if (configuration is not null)
            {
                _configuration = configuration.GetConfigurationDtoFromConfiguration();
            }
        }
    }

    private async Task HandleAddOrUpdateConfiguration()
    {
        if (Add)
        {
            await ConfigurationService.AddConfiguration(_configuration!);
        }
        else
        {
            await ConfigurationService.UpdateConfiguration(_configuration!);
        }

        RedirectService.NavigateTo(ClientApiEndpoints.AdminConfigurationsUrl);
    }
}
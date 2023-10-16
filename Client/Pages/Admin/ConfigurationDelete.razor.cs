using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ConfigurationDelete
{
    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;
   
    [Parameter]
    public string ConfigurationKey { get; set; } = string.Empty;

    [Parameter]
    public string ConfigurationLanguage { get; set; } = string.Empty;
   
    private string _messageError = string.Empty;
    
    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            var response = await ConfigurationService.DeleteConfiguration(ConfigurationKey, ConfigurationLanguage);
            if (response)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.AdminConfigurationsUrl);
            }
            else
            {
                _messageError = MessagesClientPages.MessageDeleteNotWork;
            }
        }
    }
}
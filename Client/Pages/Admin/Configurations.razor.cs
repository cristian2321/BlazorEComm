using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class Configurations
{
    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    [Inject]
    private IConfigurationAppService ConfigurationAppService { get; set; } = default!;

    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    private List<ConfigurationDto> _configurations = new();

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            await ConfigurationAppService.ConfigurationAppIntialize();

            _configurations = ConfigurationService.ConfgurationAppConfigurations;
        }
    }

    public void NavigateToAddConfiguration() =>
        RedirectService.NavigateTo(ClientApiEndpoints.AdminConfigurationAddUrl);

    public void NavigateToDeleteConfiguration(string configurationKey, string configurationLanguage) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminConfigurationDeleteUrl}/{configurationKey}/{configurationLanguage}");

    public void NavigateToEditConfiguration(string configurationKey, string configurationLanguage) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminConfigurationUpdateUrl}/{configurationKey}/{configurationLanguage}");
}
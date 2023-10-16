using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class HomeButton
{
    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;
  
    [Inject]
    IConfigurationService ConfigurationService { get; set; } = default!;

    [Inject]
    IConfigurationAppService ConfigurationAppService { get; set; } = default!;

    private string _companyName = string.Empty;


    protected override async Task OnInitializedAsync()
    {
        await ConfigurationAppService.ConfigurationAppIntialize();
        
        _companyName = await ConfigurationService.GetConfigurationValue(ClientConstants.CompanyName) ?? ClientConstants.DefaultCompanyName;
    }

    private void GoToHome() => 
        RedirectService.NavigateTo(RedirectService.GetBaseUri());
}
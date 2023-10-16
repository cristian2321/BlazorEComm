using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ConfigurationUpdate
{
    [Inject]
    private IAdminService AdminService { get; set; } = default!;
   
    [Parameter]
    public string ConfigurationKey { get; set; } = string.Empty;

    [Parameter]
    public string ConfigurationLanguage { get; set; } = string.Empty;
    
    protected override async Task OnInitializedAsync() =>
        _ = await AdminService.IsUserWithAdminRole();
}
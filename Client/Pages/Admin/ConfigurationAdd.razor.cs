using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ConfigurationAdd
{
    [Inject]
    private IAdminService AdminService { get; set; } = default !;

    protected override async Task OnInitializedAsync() => 
        _ = await AdminService.IsUserWithAdminRole();
}
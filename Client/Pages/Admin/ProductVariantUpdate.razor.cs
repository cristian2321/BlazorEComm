using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductVariantUpdate
{
    [Parameter]
    public Guid ProductId { get; set; }

    [Parameter]
    public Guid ProductTypeId { get; set; }

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        var authentificateRole = await AuthService.IsUserAuthenticatedWithRoleAdmin();
        if (!authentificateRole)
        {
            NavigationManager.NavigateTo(ClientApiEndpoints.BaseRegisterUrl);
        }
    }
}
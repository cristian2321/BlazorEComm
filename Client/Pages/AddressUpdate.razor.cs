using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class AddressUpdate
{
    [Inject]
    IAuthService AuthService { get; set; } = default!;

    [Parameter]
    public Guid AddressId { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await AuthService.ValidateUserAuthenticated();
    }
}
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class AddressAdd
{
    [Inject]
    IAuthService AuthService { get; set; } = default!;

    protected override async Task OnInitializedAsync() =>
        await AuthService.ValidateUserAuthenticated();
}
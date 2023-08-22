using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class AddressAdd
{
    [Inject]
    IAuthService AuthService { get; set; } = default!;

    [Inject]
    NavigationManager NavigationManager { get; set; } = default!;
  
    private const string RegisterUrl = "register";
    
    protected override async Task OnInitializedAsync()
    {
        if (!await AuthService.IsUserAuthenticated())
        {
            NavigationManager.NavigateTo(RegisterUrl);
        }
    }
}
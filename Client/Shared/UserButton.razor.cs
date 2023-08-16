using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorEComm.Client.Shared;

public partial class UserButton
{
    [Inject]
    private ILocalStorageService LocalStorageService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;

    private bool showUserMenu = false;
    
    private string? UserMenuCssClass => showUserMenu ? "show-menu" : null;
   
    private const string AuthToken = "authToken";

    private void ToggleUserMenu()
    {
        showUserMenu = !showUserMenu;
    }

    private async Task HideUserMenu()
    {
        await Task.Delay(200);
        showUserMenu = false;
    }

    private async Task Logout()
    {
        await LocalStorageService.RemoveItemAsync(AuthToken);

        await AuthenticationStateProvider.GetAuthenticationStateAsync();

        NavigationManager.NavigateTo(NavigationManager.BaseUri);
    }
}
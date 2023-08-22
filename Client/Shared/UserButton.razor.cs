using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorEComm.Client.Shared;

public partial class UserButton
{
    [Inject]
    private ILocalStorageService LocalStorageService { get; set; } = default!;
  
    [Inject]
    private ICartService CartService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;

    private bool _showUserMenu = false;

    private string? GetUserMenuCssClass() =>
        _showUserMenu ? ClientCssConstants.ShowMenu : null;


    private void ToggleUserMenu() => 
        _showUserMenu = !_showUserMenu;

    private async Task HideUserMenu()
    {
        await Task.Delay(200);

        _showUserMenu = default;
    }

    private async Task Logout()
    {
        await LocalStorageService.RemoveItemAsync(ClientConstants.AuthToken);

        await CartService.GetCartItemsCount();

        await AuthenticationStateProvider.GetAuthenticationStateAsync();

        NavigationManager.NavigateTo(NavigationManager.BaseUri);
    }
}
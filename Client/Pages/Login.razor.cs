using BlazorEComm.Shared.Dtos;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.WebUtilities;

namespace BlazorEComm.Client.Pages;

public partial class Login
{
    [Inject]
    private IAuthService AuthService { get; set; } = default!;
   
    [Inject]
    private ILocalStorageService LocalStorageService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;
  
    [Inject]
    private AuthenticationStateProvider AuthenticationStateProvider { get; set; } = default!;

    [Inject]
    private ICartService CartService { get; set; } = default!;

    private readonly UserLoginDto _userLogin = new();

    private string _errorMessage = string.Empty;

    private string _returnUrl = string.Empty;

    protected override void OnInitialized()
    {
        if (QueryHelpers.ParseQuery(NavigationManager.ToAbsoluteUri(NavigationManager.Uri).Query)
            .TryGetValue(ClientApiEndpoints.ReturnUrl, out var url))
        {
            _returnUrl = url;
        }
    }

    private async Task HandleLogin()
    {
        var loginResult = await AuthService.Login(_userLogin);
        if (loginResult.Succes)
        {
            _errorMessage = string.Empty;

            await LocalStorageService.SetItemAsync(ClientConstants.AuthToken, loginResult.Data);

            await AuthenticationStateProvider.GetAuthenticationStateAsync();

            await CartService.StoreCartItems(true);

            await CartService.GetCartItemsCount();

            NavigationManager.NavigateTo(_returnUrl);
        }
        else
        {
            _errorMessage = loginResult.Message;
        }
    }
}
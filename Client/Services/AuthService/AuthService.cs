using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorEComm.Client.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly NavigationManager _navigationManager;
    public AuthService(HttpClient httpClient,
        AuthenticationStateProvider authenticationStateProvider, 
        NavigationManager navigationManager)
    {
        _httpClient = httpClient;
        _authenticationStateProvider = authenticationStateProvider;
        _navigationManager = navigationManager;
    }

    public async Task<ServiceResponse<bool>> ChangePassword(UserChangePasswordDto userChangePassword)
    {
        if (await IsUserAuthenticated())
        {
            return await (await _httpClient.PostAsJsonAsync(ClientApiEndpoints.ChangePasswordUrl, userChangePassword.Password))
                .Content.ReadFromJsonAsync<ServiceResponse<bool>>() ?? default!;
        }

        return default!;
    }

    public async Task<bool> IsUserAuthenticated() => (await _authenticationStateProvider.GetAuthenticationStateAsync()).User.Identity!.IsAuthenticated;

    public async Task<ServiceResponse<string>> Login(UserLoginDto userLogin) =>
        await (await _httpClient.PostAsJsonAsync(ClientApiEndpoints.BaseApiLoginUrl, userLogin))
            .Content.ReadFromJsonAsync<ServiceResponse<string>>() ?? default!;

    public async Task<ServiceResponse<string>> Register(UserRegisterDto userRegister) =>
        await (await _httpClient.PostAsJsonAsync(ClientApiEndpoints.BaseApiRegisterUrl, userRegister))
            .Content.ReadFromJsonAsync<ServiceResponse<string>>() ?? default!;

    public async Task ValidateUserAuthenticated()
    {
        var isAuthenticated = (await _authenticationStateProvider.GetAuthenticationStateAsync()).User.Identity!.IsAuthenticated;
        if (!isAuthenticated)
        {
            _navigationManager.NavigateTo(ClientApiEndpoints.BaseRegisterUrl);
        }
    }
}
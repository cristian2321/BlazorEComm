using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorEComm.Client.Services.AuthService;

public class AuthService : IAuthService
{
    private const string RegisterUrl = "api/auth/register";
    private const string ChangePasswordUrl = "api/auth/change-password";
    private const string LoginUrl = "api/auth/login";

    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public AuthService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider)
    {
        _httpClient = httpClient;
        _authenticationStateProvider = authenticationStateProvider;
    }

    public async Task<ServiceResponse<bool>> ChangePassword(UserChangePasswordDto userChangePassword) =>
        await (await _httpClient.PostAsJsonAsync(ChangePasswordUrl, userChangePassword.Password))
            .Content.ReadFromJsonAsync<ServiceResponse<bool>>() ?? default!;

    public async Task<ServiceResponse<string>> Login(UserLoginDto userLogin) =>
        await (await _httpClient.PostAsJsonAsync(LoginUrl, userLogin))
            .Content.ReadFromJsonAsync<ServiceResponse<string>>() ?? default!;

    public async Task<ServiceResponse<string>> Register(UserRegisterDto userRegister) =>
        await (await _httpClient.PostAsJsonAsync(RegisterUrl, userRegister))
            .Content.ReadFromJsonAsync<ServiceResponse<string>>() ?? default!;

    public async Task<bool> IsUserAuthenticated() =>
        (await _authenticationStateProvider.GetAuthenticationStateAsync()).User.Identity!.IsAuthenticated;

}
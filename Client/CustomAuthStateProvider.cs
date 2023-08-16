using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace BlazorEComm.Client;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    private readonly ILocalStorageService _localStorageService;
    private readonly HttpClient _httpClient;

    private const string AuthToken = "authToken";
    private const string Bearer = "Bearer";
    private const string Jwt = "jwt";
    
    private const char Point = '.';

    public CustomAuthStateProvider(ILocalStorageService localStorageService, HttpClient httpClient)
    {
        _localStorageService = localStorageService;
        _httpClient = httpClient;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = new ClaimsIdentity();
        var aurthToken = await _localStorageService.GetItemAsStringAsync(AuthToken);

        _httpClient.DefaultRequestHeaders.Authorization = null;

        return !string.IsNullOrWhiteSpace(aurthToken) ? 
            SetAuthState(await GetIdentity(aurthToken)) : 
            SetAuthState(identity);
    }

    private async Task<ClaimsIdentity> GetIdentity(string aurthToken)
    {
        try
        {
             var identity = new ClaimsIdentity(ParseClaimsJwt(aurthToken), Jwt);

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                Bearer, aurthToken.Replace("\"", ""));

            return identity;
        }
        catch
        {
            await _localStorageService.RemoveItemAsync(AuthToken);

            return new();
        }
    }

    private AuthenticationState SetAuthState(ClaimsIdentity identity)
    {
        var state = new AuthenticationState(new ClaimsPrincipal(identity));

        NotifyAuthenticationStateChanged(Task.FromResult(state));

        return state;
    }

    private static IEnumerable<Claim> ParseClaimsJwt(string jwt)
    {
        var keyValues = JsonSerializer
            .Deserialize<Dictionary<string, object>>(ParseBase64WithoutPadding(jwt.Split(Point)[1]));

        return keyValues is not null ?
            keyValues.Select(x => new Claim(x.Key, x.Value.ToString()!)) : 
            default!;
    }

    private static byte[] ParseBase64WithoutPadding(string base64)
    {
        switch (base64.Length % 4)
        {
            case 2: base64 += "=="; break;
            case 3: base64 += "="; break;
        }

        return Convert.FromBase64String(base64);
    }
}

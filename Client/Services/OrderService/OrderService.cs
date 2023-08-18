using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorEComm.Client.Services.OrderService;

public class OrderService : IOrderService
{ 
    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly NavigationManager _navigationManager;
    
    private const string BaseOrderUrl = "api/order";
    private const string LoginUrl = "login";

    public OrderService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider, NavigationManager navigationManager)
    {
        _httpClient = httpClient;
        _authenticationStateProvider = authenticationStateProvider;
        _navigationManager = navigationManager;
    }
    public async Task<List<OrderOverviewDto>> GetOrders()
    {
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<OrderOverviewDto>>>(BaseOrderUrl);
        
        return result is not null && result.Data is not null ? 
            result.Data : default!;
    }

    public async Task PlaceOrder()
    {
        if (await IsUserAuthenticated())
        {
            await _httpClient.PostAsync(BaseOrderUrl, null);
        }
        else
        {
            _navigationManager.NavigateTo(LoginUrl);
        }
    }

    private async Task<bool> IsUserAuthenticated() =>
        (await _authenticationStateProvider.GetAuthenticationStateAsync()).User.Identity!.IsAuthenticated;
}
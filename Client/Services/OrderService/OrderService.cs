using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Services.OrderService;

public class OrderService : IOrderService
{ 
    private readonly HttpClient _httpClient;
    private readonly IAuthService _authService;
    private readonly NavigationManager _navigationManager;
    
    private const string BaseOrderUrl = "api/order";
    private const string RegisterUrl = "register";

    public OrderService(HttpClient httpClient, IAuthService authService, NavigationManager navigationManager)
    {
        _httpClient = httpClient;
        _authService = authService;
        _navigationManager = navigationManager;
    }

    public async Task<OrderDetailsDto> GetOrderDetails(Guid orderId)
    {
        if (await _authService.IsUserAuthenticated())
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<OrderDetailsDto>>($"{BaseOrderUrl}/{orderId}");

            return result is not null && result.Data is not null ?
                result.Data : default!;
        }
        else
        {
            _navigationManager.NavigateTo(RegisterUrl);
            return default!;
        }
    }

    public async Task<List<OrderOverviewDto>> GetOrders()
    {
        if (await _authService.IsUserAuthenticated())
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<OrderOverviewDto>>>(BaseOrderUrl);

            return result is not null && result.Data is not null ?
                result.Data : default!;
        }
        else
        {
            _navigationManager.NavigateTo(RegisterUrl);
            return default!;
        }
    }


    public async Task PlaceOrder()
    {
        if (await _authService.IsUserAuthenticated())
        {
            await _httpClient.PostAsync(BaseOrderUrl, null);
        }
        else
        {
            _navigationManager.NavigateTo(RegisterUrl);
        }
    }
}
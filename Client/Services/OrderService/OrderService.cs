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
    private const string OrderFailUrl = "api/order/order-fail";
    private const string CheckoutUrl = "api/payment/checkout";

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


    public async Task<string> PlaceOrder()
    {
        if (!await _authService.IsUserAuthenticated())
        {
            return RegisterUrl;
        }

        var result = await _httpClient.PostAsync(CheckoutUrl, null);

        return await result.Content.ReadAsStringAsync();
    }

    public async Task RemoveOrderCancelPayments()
    {
        if (!await _authService.IsUserAuthenticated())
        {
            _navigationManager.NavigateTo(RegisterUrl);
        }

        else
        {
             await _httpClient.PostAsync(OrderFailUrl, null);
        }
    }
}
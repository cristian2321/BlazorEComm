using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.OrderService;

public class OrderService : IOrderService
{ 
    private readonly HttpClient _httpClient;
    private readonly IAuthService _authService;

    public OrderService(HttpClient httpClient, IAuthService authService)
    {
        _httpClient = httpClient;
        _authService = authService;
    }

    public async Task<OrderDetailsDto> GetOrderDetails(Guid orderId)
    {
        await _authService.ValidateUserAuthenticated();
        
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<OrderDetailsDto>>
         ($"{ClientApiEndpoints.BaseApiOrderUrl}/{orderId}");

        return result is not null && result.Data is not null ?
            result.Data : default!;
    }

    public async Task<List<OrderOverviewDto>> GetOrders()
    {
        await _authService.ValidateUserAuthenticated();
       
        var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<OrderOverviewDto>>>
                  (ClientApiEndpoints.BaseApiOrderUrl);

        return result is not null && result.Data is not null ?
            result.Data : default!;
    }

    public async Task<string> CheckoutOrder()
    {
        await _authService.ValidateUserAuthenticated();

        var result = await _httpClient.PostAsync(ClientApiEndpoints.OrderCheckoutUrl, null);

        return await result.Content.ReadAsStringAsync();
    }

    public async Task<string> CheckoutOrderById(Guid orderId)
    {
        await _authService.ValidateUserAuthenticated();

        var result = await _httpClient.PostAsync($"{ClientApiEndpoints.OrderCheckoutUrl}/{orderId}", null);

        return await result.Content.ReadAsStringAsync();
    }

    public async Task RemoveOrderCancelPayments()
    {
        await _authService.ValidateUserAuthenticated();
        await _httpClient.PostAsync(ClientApiEndpoints.OrderFailUrl, null);
    }

    public async Task UpdateOrderPaymentFlag()
    {
        await _authService.ValidateUserAuthenticated();
        await _httpClient.PostAsync(ClientApiEndpoints.OrderSuccesUrl, null);
    }
}
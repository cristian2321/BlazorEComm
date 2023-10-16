using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Orders
{
    [Inject]
    private IOrderService OrderService { get; set; } = default!;
    
    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    private List<OrderOverviewDto>? _orders = null;

    protected async override Task OnInitializedAsync()
    {
        await AuthService.ValidateUserAuthenticated();

        _orders = await OrderService.GetOrders();
    }

    private async Task CheckoutOrderById(Guid orderId) =>
        RedirectService.NavigateTo(await OrderService.CheckoutOrderById(orderId));
}
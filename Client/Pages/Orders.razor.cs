using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Orders
{
    [Inject]
    private IOrderService OrderService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    private List<OrderOverviewDto>? _orders = null;

    protected async override Task OnInitializedAsync()
    {
        _orders = await OrderService.GetOrders();
    }

    private async Task CheckoutOrderById(Guid orderId)
    {
        string url = await OrderService.CheckoutOrderById(orderId);
        NavigationManager.NavigateTo(url);
    }
}
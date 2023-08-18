using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Orders
{
    [Inject]
    private IOrderService OrderService { get; set; } = default!;

    private List<OrderOverviewDto>? _orders = null;

    protected async override Task OnInitializedAsync()
    {
        _orders = await OrderService.GetOrders();
    }
}
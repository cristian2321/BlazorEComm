using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class OrderFail
{
    [Inject]
    private IOrderService OrderService { get; set; } = default!;

    [Inject]
    private ICartService CartService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        await OrderService.RemoveOrderCancelPayments();

        await CartService.GetCartItemsCount();

        NavigationManager.NavigateTo(NavigationManager.BaseUri);
    }
}
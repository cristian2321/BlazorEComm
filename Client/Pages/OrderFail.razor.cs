using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class OrderFail
{
    [Inject]
    private IOrderService OrderService { get; set; } = default!;

    [Inject]
    private ICartService CartService { get; set; } = default!;

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        await AuthService.ValidateUserAuthenticated();

        await OrderService.RemoveOrderCancelPayments();

        await CartService.GetCartItemsCount();

        RedirectService.NavigateTo(RedirectService.GetBaseUri());
    }
}
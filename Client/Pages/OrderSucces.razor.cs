using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class OrderSucces
{
    [Inject]
    private IOrderService OrderService { get; set; } = default!;

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        await AuthService.ValidateUserAuthenticated();

        await OrderService.UpdateOrderPaymentFlag();

        NavigationManager.NavigateTo(NavigationManager.BaseUri);
    }
}
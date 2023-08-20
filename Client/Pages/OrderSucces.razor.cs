using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class OrderSucces
{
    [Inject]
    private IOrderService OrderService { get; set; } = default!;
    
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        await OrderService.UpdateOrderPaymentFlag();

        NavigationManager.NavigateTo(NavigationManager.BaseUri);
    }
}
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class OrderSucces
{
    [Inject]
    private ICartService CartService { get; set; } = default!;

    protected override async Task OnInitializedAsync() => 
        await CartService.GetCartItemsCount();
}
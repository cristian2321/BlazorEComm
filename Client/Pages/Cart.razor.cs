using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Cart
{
    [Inject]
    public ICartService CartService { get; set; } = default!;

    private List<CartProductDto>? _cartProducts = null;
    
    private string _message = "Loading cart...";
    
    protected override async Task OnInitializedAsync()
    {
        var cardsItem = await CartService.GetCardItems();

        if (cardsItem is null) 
        {
            _message = "Your cart is empty";
            _cartProducts = new();
        }
        else
        {
            _cartProducts = await CartService.GetCartProducts();
        }
    }
}
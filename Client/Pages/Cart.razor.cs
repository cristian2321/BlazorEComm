using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Cart
{
    [Inject]
    private ICartService CartService { get; set; } = default!;

    private List<CartProductDto>? _cartProducts = null;
    
    private string _message = "Loading cart...";
    
    protected override async Task OnInitializedAsync()
    {
        await LoadCarts();
    }

    private async Task RemoveProductFromCart(Guid productId, Guid productTypeId) 
    {
        await CartService.RemoveProductFromCart(productId, productTypeId);

        await LoadCarts();
    }

    private async Task LoadCarts()
    {
        string messageEmptyCart = "Your cart is empty";
        var cardsItem = await CartService.GetCardItems();

        if (cardsItem is null)
        {         
            _cartProducts = new();
            
            _message = messageEmptyCart;
        }
        else
        {
            _cartProducts = await CartService.GetCartProducts();
            if (_cartProducts is not null && !_cartProducts.Any())
            {
                _message = messageEmptyCart; 
            }
        }
    }

    private async Task UpdateQuantity(ChangeEventArgs changeEventArgs, CartProductDto cartProduct) 
    {
        if (changeEventArgs is not null && changeEventArgs.Value is not null)
        {
            cartProduct.Quantity = int.Parse(changeEventArgs.Value.ToString()!);
            if (cartProduct.Quantity < 1)
            {
                cartProduct.Quantity = 1;
            }

            await CartService.UpdateQuantity(cartProduct);
        }

    }
}
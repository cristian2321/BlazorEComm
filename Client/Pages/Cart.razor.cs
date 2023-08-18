using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Cart
{
    [Inject]
    private ICartService CartService { get; set; } = default!;

    [Inject]
    private IOrderService OrderService { get; set; } = default!;

    private List<CartProductDto>? _cartProducts = null;

    private string _message = "Loading cart...";
    private bool _isOrderPlace = false;

    protected override async Task OnInitializedAsync()
    {
        _isOrderPlace = false;

        await LoadCart();
    }

    private async Task RemoveProductFromCart(Guid productId, Guid productTypeId)
    {
        await CartService.RemoveProductFromCart(productId, productTypeId);

        await LoadCart();
    }

    private async Task LoadCart()
    {
        await CartService.GetCartItemsCount();
        _cartProducts = await CartService.GetCartProducts();
        if (_cartProducts == null || !_cartProducts.Any())
        {
            _message = "Your cart is empty.";
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

    private async Task PlaceOrder()
    {
        await OrderService.PlaceOrder();

        await CartService.GetCartItemsCount();
        
        _isOrderPlace = true;
    }
}
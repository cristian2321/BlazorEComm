using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Cart
{
    [Inject]
    private ICartService CartService { get; set; } = default!;

    [Inject]
    private IOrderService OrderService { get; set; } = default!;
  
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    private List<CartProductDto>? _cartProducts = null;

    private string _message = MessagesClientPages.MessageLoadingCart;

    protected override async Task OnInitializedAsync() =>
        await LoadCart();

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
            _message = MessagesClientPages.MessageCartEmpty;
        }
    }

    private async Task UpdateQuantity(ChangeEventArgs e, CartProductDto product)
    {
        product.Quantity = int.Parse(e!.Value!.ToString()!);
        
        if (product.Quantity < 1)
        {
            product.Quantity = ClientConstants.ProductDefaultQuantity;
        }     
        
        await CartService.UpdateQuantity(product);
    }

    private async Task CheckoutOrder() => 
        NavigationManager.NavigateTo(await OrderService.CheckoutOrder());
}
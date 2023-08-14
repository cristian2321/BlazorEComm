using BlazorEComm.Client.Services.CartService;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class CartCounter : IDisposable
{
    [Inject]
    private ICartService CartService { get; set; } = default!;
   
    [Inject]
    private ISyncLocalStorageService SyncLocalStorageService { get; set; } = default!;

    private int GetCartItemsCount() 
    {
        var cart = SyncLocalStorageService.GetItem<List<CartItem>>("cart");

        return cart is not null ? cart.Count : 0;
    }

    protected override void OnInitialized()
    {
        CartService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        CartService.OnChange -= StateHasChanged;
    }
}
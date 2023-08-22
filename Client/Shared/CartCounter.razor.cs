using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class CartCounter : IDisposable
{
    [Inject]
    private ICartService CartService { get; set; } = default!;
   
    [Inject]
    private ISyncLocalStorageService LocalStorageService { get; set; } = default!;

    private int GetCartItemsCount() =>
        LocalStorageService.GetItem<int>(ClientConstants.CartItemsCount);

    protected override void OnInitialized() =>
        CartService.OnChange += StateHasChanged;

    public void Dispose() => 
        CartService.OnChange -= StateHasChanged;
}
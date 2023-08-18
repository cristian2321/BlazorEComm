using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class CartCounter : IDisposable
{
    private const string CartItemsCount = "cartItemsCount";

    [Inject]
    private ICartService CartService { get; set; } = default!;
   
    [Inject]
    private ISyncLocalStorageService LocalStorageService { get; set; } = default!;

    private int GetCartItemsCount() =>
        LocalStorageService.GetItem<int>(CartItemsCount);

    protected override void OnInitialized() =>
        CartService.OnChange += StateHasChanged;

    public void Dispose() => 
        CartService.OnChange -= StateHasChanged;
}
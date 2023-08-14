using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;
using Blazored.LocalStorage;
using System.ComponentModel;

namespace BlazorEComm.Client.Services.CartService;

public class CartService : ICartService
{
    private const string Cart = "cart";
    private const string CartProductsUrl = "api/cart/products";
    
    private readonly ILocalStorageService _localStorageService;

    private readonly HttpClient _httpClient;

    public event Action OnChange = default!;

    public CartService(ILocalStorageService localStorageService, HttpClient httpClient)
    {
        _localStorageService = localStorageService;
        _httpClient = httpClient;
    }

    public async Task AddToCard(CartItem card)
    {
        var cart = await GetCarts();

        cart.Add(card);

        await _localStorageService.SetItemAsync(Cart, cart);

        OnChange.Invoke();
    }

    public async Task<List<CartItem>> GetCardItems() =>
        await GetCarts();

    public async Task<List<CartProductDto>> GetCartProducts()
    {
        var cartItems = await GetCarts();
        if (cartItems is null)
            return new ();

        var response = await _httpClient.PostAsJsonAsync(CartProductsUrl, cartItems);

        var cartProducts =
            await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductDto>>>();

        return cartProducts is not null && cartProducts.Data is not null ?
            cartProducts!.Data: new();
    }


    private async Task<List<CartItem>> GetCarts()
    {
        var cart = await _localStorageService.GetItemAsync<List<CartItem>>(Cart);

        return cart ??= new();
    }
}
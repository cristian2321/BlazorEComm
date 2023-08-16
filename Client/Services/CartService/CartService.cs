using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;
using Blazored.LocalStorage;

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

    public async Task AddToCard(CartItemDto cartItem)
    {
        var cart = await GetCart();

        var sameItem = cart.Find(x => x.ProductId == cartItem.ProductId &&
            x.ProductTypeId == cartItem.ProductTypeId);

        if (sameItem is null)
        {
            cart.Add(cartItem);
        }
        else
        {
            sameItem.Quantity += cartItem.Quantity;
        }      

        await _localStorageService.SetItemAsync(Cart, cart);

        OnChange.Invoke();
    }

    public async Task<List<CartItemDto>> GetCardItems() =>
        await GetCart();

    public async Task<List<CartProductDto>> GetCartProducts()
    {
        var cartItems = await GetCart();
        if (cartItems is null)
            return new ();

        var response = await _httpClient.PostAsJsonAsync(CartProductsUrl, cartItems);

        var cartProducts =
            await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductDto>>>();

        return cartProducts is not null && cartProducts.Data is not null ?
            cartProducts!.Data: new();
    }


    private async Task<List<CartItemDto>> GetCart()
    {
        var cart = await _localStorageService.GetItemAsync<List<CartItemDto>>(Cart);

        return cart ??= new();
    }

    public async Task RemoveProductFromCart(Guid productId, Guid productTypeId)
    {
        var cart = await GetCart();

        var cardItem = GetCartItem(cart, productId, productTypeId);

        if (cardItem is not null)
        {
            cart.Remove(cardItem);

            await _localStorageService.SetItemAsync(Cart, cart);

            OnChange.Invoke();
        }
    }

    public async Task UpdateQuantity(CartProductDto cartProduct)
    {
        var cart = await GetCart();

        var cardItem = GetCartItem(cart, cartProduct.ProductId, cartProduct.ProductTypeId);

        if (cardItem is not null)
        {
            cardItem.Quantity = cartProduct.Quantity;

            await _localStorageService.SetItemAsync(Cart, cart);
        }
    }

    private static CartItemDto? GetCartItem(List<CartItemDto> cart, Guid productId, Guid productTypeId) =>
        cart is null ?
            default :
            cart.Find(x => x.ProductId == productId &&
                x.ProductTypeId == productTypeId);
}
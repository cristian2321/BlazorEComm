﻿using BlazorEComm.Shared;
using BlazorEComm.Shared.Dtos;
using Blazored.LocalStorage;

namespace BlazorEComm.Client.Services.CartService;

public class CartService : ICartService
{
    private readonly ILocalStorageService _localStorageService;

    private readonly HttpClient _httpClient;
    private readonly IAuthService _authService;

    public event Action OnChange = default!;

    public CartService(ILocalStorageService localStorageService, HttpClient httpClient, 
        IAuthService authService)
    {
        _localStorageService = localStorageService;
        _httpClient = httpClient;
        _authService = authService;
    }

    private const string AddCartUrl = "api/cart/add";
    private const string BaseCartUrl = "api/cart";
    private const string Cart = "cart";
    private const string CartItemsCount = "cartItemsCount";
    private const string CartItemsCountUrl = "api/cart/count";
    private const string CartProductsUrl = "api/cart/products";
    private const string UpdateQuantityCartUrl = "api/cart/update-quantity";

    public async Task AddToCard(CartItem cartItem)
    {
        if (await _authService.IsUserAuthenticated())
        {
            await _httpClient.PostAsJsonAsync(AddCartUrl, cartItem);
        }
        else
        {
            var cart = await GetCarts();

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
        }

        await GetCartItemsCount();
    }

    public async Task<List<CartProductDto>> GetCartProducts()
    {
        if (await _authService.IsUserAuthenticated())
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<CartProductDto>>>(BaseCartUrl);

            return response is not null && response.Data is not null ? 
                response.Data : new();
        }
        else
        {
            var cartItems = await GetCarts();
            if (cartItems is null)
            {
                return new();
            }
             
            var response = await _httpClient.PostAsJsonAsync(CartProductsUrl, cartItems);

            var cartProducts =
                await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductDto>>>();

            return cartProducts is not null && cartProducts.Data is not null ?
                cartProducts!.Data : new();
        }
    }

    public async Task RemoveProductFromCart(Guid productId, Guid productTypeId)
    {
        if (await _authService.IsUserAuthenticated())
        { 
            await _httpClient.DeleteAsync($"{BaseCartUrl}/{productId}/{productTypeId}");
        }
        else
        {
            var cart = await GetCarts();

            var cartItem = GetCartItem(cart, productId, productTypeId);

            if (cartItem is not null)
            {
                cart.Remove(cartItem);

                await _localStorageService.SetItemAsync(Cart, cart);
            }
        }
    }

    public async Task UpdateQuantity(CartProductDto cartProduct)
    {
        if (await _authService.IsUserAuthenticated())
        {
            var request = new CartItem
            {
                ProductId = cartProduct.ProductId,
                Quantity = cartProduct.Quantity,
                ProductTypeId = cartProduct.ProductTypeId,  
            };

            await _httpClient.PutAsJsonAsync(UpdateQuantityCartUrl, request);
        }
        else
        {
            var cart = await GetCarts();

            var cardItem = GetCartItem(cart, cartProduct.ProductId, cartProduct.ProductTypeId);

            if (cardItem is not null)
            {
                cardItem.Quantity = cartProduct.Quantity;

                await _localStorageService.SetItemAsync(Cart, cart);
            }
        } 
    }

    public async Task StoreCartItems(bool emptyLocalCart = default)
    {
        var localCart = await GetCarts();
        if (localCart is null)
        {
            return;
        }

        await _httpClient.PostAsJsonAsync(BaseCartUrl, localCart);

        if (emptyLocalCart)
        {
            await _localStorageService.RemoveItemAsync(Cart);
        }
    }

    public async Task GetCartItemsCount()
    {
        if (await _authService.IsUserAuthenticated())
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<int>>(CartItemsCountUrl);
            if (result is not null)
            {
                var count = result.Data;

                await _localStorageService.SetItemAsync(CartItemsCount, count);
            }
        }
        else
        {
            var carts = await GetCarts();

            await _localStorageService.SetItemAsync(CartItemsCount,
                carts is not null ?
                    carts.Count: 0);
        }

        OnChange.Invoke();
    }

    private async Task<List<CartItem>> GetCarts()
    {
        var cart = await _localStorageService.GetItemAsync<List<CartItem>>(Cart);

        return cart ??= new();
    }

    private static CartItem? GetCartItem(List<CartItem> cart, Guid productId, Guid productTypeId) =>
        cart is null ?
            default :
            cart.Find(x => x.ProductId == productId &&
                x.ProductTypeId == productTypeId);

}
using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.CartService;

public interface ICartService
{
    Task<ServiceResponse<List<CartProductDto>>> GetCartProducts(List<CartItem> cartItems, 
        CancellationToken cancellationToken);

    Task<ServiceResponse<List<CartProductDto>>> StoreCartItems(List<CartItem> cartItems,
        CancellationToken cancellationToken);

    Task<ServiceResponse<int>> GetCartItemsCount(CancellationToken cancellationToken);

    Task<ServiceResponse<List<CartProductDto>>> GetDbCartProducts(CancellationToken cancellationToken);

    Task<ServiceResponse<bool>> AddToCart(CartItem cartItem, CancellationToken cancellationToken);

    Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem, CancellationToken cancellationToken);

    Task<ServiceResponse<bool>> RemoveItemFromCart(Guid productId, Guid productTypeId, CancellationToken cancellationToken);

}
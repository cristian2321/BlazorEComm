using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.CartService;

public interface ICartService
{
    event Action OnChange;

    Task AddToCard(CartItemDto cartItem);

    Task<List<CartItemDto>> GetCardItems();

    Task<List<CartProductDto>> GetCartProducts();

    Task RemoveProductFromCart(Guid productId, Guid productTypeId);

    Task UpdateQuantity(CartProductDto cartProduct);
}
using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.CartService;

public interface ICartService
{
    event Action OnChange;

    Task AddToCard(CartItem cartItem);

    Task<List<CartItem>> GetCardItems();

    Task<List<CartProductDto>> GetCartProducts();

    Task RemoveProductFromCart(Guid productId, Guid productTypeId);

    Task UpdateQuantity(CartProductDto cartProduct);
}
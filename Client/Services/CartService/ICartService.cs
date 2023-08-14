using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.CartService;

public interface ICartService
{
    event Action OnChange;

    Task AddToCard(CartItem card);

    Task<List<CartItem>> GetCardItems();

    Task<List<CartProductDto>> GetCartProducts();
}

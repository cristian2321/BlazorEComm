using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface ICartExtensionRepository
{
    Task<CartItem?> GetDbCartItem(Guid productId, 
        Guid productTypeId,
        CancellationToken cancellationToken,
        Guid userId = default);

    Task<int> GetCartItemsCount(CancellationToken cancellationToken);

    Task<List<CartItem>> GetCartItems(CancellationToken cancellationToken);

    void RemoveRangeCartItems(List<CartItem> cartItems);
}
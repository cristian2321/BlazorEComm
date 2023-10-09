using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions;

public class CartExtensionRepository : ICartExtensionRepository
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IHttpContextService _httpContextService;

    public CartExtensionRepository(EcommDbContext ecommDbContext, IHttpContextService httpContextService)
    {
        _ecommDbContext = ecommDbContext;
        _httpContextService = httpContextService;
    }

    public async Task<List<CartItem>> GetCartItems(CancellationToken cancellationToken) =>
        await _ecommDbContext.CartItems
            .Where(x => x.UserId == _httpContextService.GetUserId())
            .ToListAsync(cancellationToken);

    public async Task<int> GetCartItemsCount(CancellationToken cancellationToken) =>
        await _ecommDbContext.CartItems
            .Where(x => x.UserId == _httpContextService.GetUserId())
            .CountAsync(cancellationToken);

    public async Task<CartItem?> GetDbCartItem(Guid productId, 
        Guid productTypeId, 
        CancellationToken cancellationToken,
        Guid userId = default)
    {
        userId = userId == default ? _httpContextService.GetUserId() : userId;

        return await _ecommDbContext.CartItems.FirstOrDefaultAsync(x => x.UserId == userId &&
                    x.ProductId == productId &&
                    x.ProductTypeId == productTypeId,
                cancellationToken);
    }

    public void RemoveRangeCartItems(List<CartItem> cartItems) =>
        _ecommDbContext.CartItems.RemoveRange(cartItems);
}
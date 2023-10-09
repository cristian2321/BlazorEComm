using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions;

public class OrderExtensionRepository : IOrderExtensionRepository
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IHttpContextService _httpContextService;

    public OrderExtensionRepository(EcommDbContext ecommDbContext, IHttpContextService httpContextService)
    {
        _ecommDbContext = ecommDbContext;
        _httpContextService = httpContextService;
    }

    public async Task<Order?> GetOrder(Guid userId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Orders
            .Where(x => x.UserId == userId)
            .Include(x => x.OrderItems)
            .OrderByDescending(x => x.OrderDate)
            .FirstOrDefaultAsync(cancellationToken);

    public async Task<List<Order>> GetOrdersWithProducts(CancellationToken cancellationToken) =>
        await _ecommDbContext.Orders
            .Where(x => x.UserId == _httpContextService.GetUserId())
            .Include(x => x.OrderItems)
            .ThenInclude(x => x.Product)
            .OrderByDescending(x => x.OrderDate)
            .ToListAsync(cancellationToken);
    public async Task<Order?> GetOrderWithItemsAndProducts(Guid orderId, CancellationToken cancellationToken) =>
        await _ecommDbContext.Orders
            .Where(x => x.Id == orderId &&
                x.UserId == _httpContextService.GetUserId())
            .Include(x => x.OrderItems)
            .ThenInclude(x => x.Product)
            .Include(x => x.OrderItems)
            .ThenInclude(x => x.ProductType)
            .OrderByDescending(x => x.OrderDate)
            .FirstOrDefaultAsync(cancellationToken);
    
    public async Task<List<OrderItem>> GetOrderItemsWithProducts(Guid orderId, CancellationToken cancellationToken) =>
        await _ecommDbContext
            .OrderItems
            .Where(x => x.OrderId == orderId)
            .Include(x => x.Product)
            .ToListAsync(cancellationToken);

    public void RemoveRangeOrderItems(Order order) =>
        _ecommDbContext.RemoveRange(order.OrderItems);
}
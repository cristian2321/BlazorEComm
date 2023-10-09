using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface IOrderExtensionRepository
{
    Task<Order?> GetOrder(Guid userId, CancellationToken cancellationToken);

    Task<List<Order>> GetOrdersWithProducts(CancellationToken cancellationToken);

    Task<Order?> GetOrderWithItemsAndProducts(Guid orderId, CancellationToken cancellationToken);

    Task<List<OrderItem>> GetOrderItemsWithProducts(Guid orderId, CancellationToken cancellationToken);

    void RemoveRangeOrderItems(Order order);
}
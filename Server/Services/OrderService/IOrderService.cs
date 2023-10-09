using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.OrderService;

public interface IOrderService
{
    Task<ServiceResponse<bool>> PlaceOrder(CancellationToken cancellationToken);

    Task<ServiceResponse<List<OrderOverviewDto>>> GetOrders(CancellationToken cancellationToken);

    Task<ServiceResponse<OrderDetailsDto>> GetOrderDetails(Guid orderId, CancellationToken cancellationToken);

    Task<List<OrderItem>> GetOrderItemsWithProducts(Guid orderId, CancellationToken cancellationToken);

    Task<ServiceResponse<bool>> RemoveOrderCancelPayments(CancellationToken cancellationToken);

    Task<ServiceResponse<bool>> UpdateOrderPaymentFlag(CancellationToken cancellationToken);
}
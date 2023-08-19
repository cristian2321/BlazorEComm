using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Server.Services.OrderService;

public interface IOrderService
{
    Task<ServiceResponse<bool>> PlaceOrder(CancellationToken cancellationToken);

    Task<ServiceResponse<List<OrderOverviewDto>>> GetOrders(CancellationToken cancellationToken);

    Task<ServiceResponse<OrderDetailsDto>> GetOrderDetails(Guid orderId, CancellationToken cancellationToken);

    Task<ServiceResponse<bool>> RemoveOrderCancelPayments(CancellationToken cancellationToken);
}
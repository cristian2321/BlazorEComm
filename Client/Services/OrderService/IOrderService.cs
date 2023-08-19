using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.OrderService;

public interface IOrderService
{
    Task<string> PlaceOrder();

    Task<List<OrderOverviewDto>> GetOrders();

    Task RemoveOrderCancelPayments();

    Task<OrderDetailsDto> GetOrderDetails(Guid orderId);
}

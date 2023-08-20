using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.OrderService;

public interface IOrderService
{
    Task<string> CheckoutOrder();

    Task<string> CheckoutOrderById(Guid orderId);

    Task<List<OrderOverviewDto>> GetOrders();

    Task RemoveOrderCancelPayments();

    Task<OrderDetailsDto> GetOrderDetails(Guid orderId);

    Task UpdateOrderPaymentFlag();
}

using BlazorEComm.Shared.Dtos;

namespace BlazorEComm.Client.Services.OrderService;

public interface IOrderService
{
    Task PlaceOrder();

    Task<List<OrderOverviewDto>> GetOrders();
}

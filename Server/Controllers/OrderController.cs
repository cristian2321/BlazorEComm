using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<ServiceResponse<bool>> PlaceOrder(CancellationToken cancellationToken) =>
            await _orderService.PlaceOrder(cancellationToken);

        [HttpGet]
        public async Task<ServiceResponse<List<OrderOverviewDto>>> GetOrders(CancellationToken cancellationToken) =>
            await _orderService.GetOrders(cancellationToken);
    }
}

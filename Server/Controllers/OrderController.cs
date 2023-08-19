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

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<OrderOverviewDto>>>> GetOrders(CancellationToken cancellationToken) =>
            Ok(await _orderService.GetOrders(cancellationToken));
       
        [HttpGet("{orderId}")]
        public async Task<ActionResult<ServiceResponse<List<OrderDetailsDto>>>> GetOrder(Guid orderId, CancellationToken cancellationToken) =>
            Ok(await _orderService.GetOrderDetails(orderId, cancellationToken));
       
        [HttpPost("order-fail")]
        public async Task<ActionResult<ServiceResponse<bool>>> RemoveOrderCancelPayments(CancellationToken cancellationToken)
        {
            var response = await _orderService.RemoveOrderCancelPayments(cancellationToken);

            return response.Succes ?
                Ok(response) :
                BadRequest(response);
        }
    }
}
using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages
{
    public partial class OrderDetails
    {
        [Inject]
        private IOrderService OrderService { get; set; } = default!;
        
        [Parameter]
        public Guid OrderId { get; set; }

        private OrderDetailsDto? _orderDetails = null;

        protected override async Task OnInitializedAsync()
        {
            _orderDetails = await OrderService.GetOrderDetails(OrderId);
        }
    }
}
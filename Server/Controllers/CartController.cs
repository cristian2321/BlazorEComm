using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductDto>>>> GetCartProducts(List<CartItemDto> cartItems,
            CancellationToken cancellationToken) =>
                Ok(await _cartService.GetCartProducts(cartItems, cancellationToken));
    }
}

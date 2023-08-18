using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        public async Task<ActionResult<ServiceResponse<List<CartProductDto>>>> GetCartProducts(List<CartItem> cartItems,
            CancellationToken cancellationToken) =>
                Ok(await _cartService.GetCartProducts(cartItems, cancellationToken));

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<CartProductDto>>>> StoreCartItems(List<CartItem> cartItems,
            CancellationToken cancellationToken) =>
                Ok(await _cartService.StoreCartItems(cartItems, cancellationToken));

        [HttpPost("add")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddToCart(CartItem cartItem,
            CancellationToken cancellationToken) =>
                Ok(await _cartService.AddToCart(cartItem, cancellationToken));


        [HttpPut("update-quantity")]
        public async Task<ActionResult<ServiceResponse<bool>>> UpdateQuantity(CartItem cartItem,
            CancellationToken cancellationToken) =>
                Ok(await _cartService.UpdateQuantity(cartItem, cancellationToken));

        [HttpDelete("{productId}/{productTypeId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> RemoveItemFromCart(Guid productId, Guid productTypeId,
            CancellationToken cancellationToken) =>
                Ok(await _cartService.RemoveItemFromCart(productId, productTypeId, cancellationToken));

        [HttpGet("count")]
        public async Task<ActionResult<ServiceResponse<int>>> GetCartItemsCount(CancellationToken cancellationToken) =>
            Ok(await _cartService.GetCartItemsCount(cancellationToken));

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<CartProductDto>>>> GetDbCartProducts(CancellationToken cancellationToken)
        {
            var carts = await _cartService.GetDbCartProducts(cancellationToken);
            return Ok(carts) ;
        }
    }
}

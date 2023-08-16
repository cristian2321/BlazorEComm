using BlazorEComm.Shared.Dtos;
using System.Threading;

namespace BlazorEComm.Server.Services.CartService;

public interface ICartService
{
    Task<ServiceResponse<List<CartProductDto>>> GetCartProducts(List<CartItemDto> cartItems, CancellationToken cancellationToken);
}
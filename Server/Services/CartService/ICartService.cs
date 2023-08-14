using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;
using System.Threading;

namespace BlazorEComm.Server.Services.CartService;

public interface ICartService
{
    Task<ServiceResponse<List<CartProductDto>>> GetCartProducts(List<CartItem> cartItems, CancellationToken cancellationToken);
}
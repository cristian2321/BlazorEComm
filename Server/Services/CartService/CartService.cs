using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.CartService;

public class CartService : ICartService
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly IHttpContextService _httpContextService;

    public CartService(EcommDbContext ecommDbContext, IHttpContextService httpContextService)
    {
        _ecommDbContext = ecommDbContext;
        _httpContextService = httpContextService;
    }

    private const bool IsSucces = true;
    private const string MessageErrorCartNotExists = "Cart item does not exists !";

    public async Task<ServiceResponse<bool>> AddToCart(CartItem cartItem, CancellationToken cancellationToken)
    {
        cartItem.UserId = _httpContextService.GetUserId();
       
        var sameItem = await GetDbCartItem(cartItem.ProductId, 
            cartItem.ProductTypeId, 
            cancellationToken, 
            cartItem.UserId);

        if (sameItem is null)
        {
            _ecommDbContext.Add(cartItem);
        }
        else
        {
            sameItem.Quantity += cartItem.Quantity;
        }

        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<bool> { Data = IsSucces };
    }

    public async Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem, CancellationToken cancellationToken)
    {
        var dbCartItem = await GetDbCartItem(cartItem.ProductId, cartItem.ProductTypeId, cancellationToken);

        if (dbCartItem is null)
        {
            return GetServiceResponseWithError(MessageErrorCartNotExists);
        }

        dbCartItem.Quantity = cartItem.Quantity;
        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<bool> { Data = IsSucces };
    }

    public async Task<ServiceResponse<bool>> RemoveItemFromCart(Guid productId, Guid productTypeId, 
        CancellationToken cancellationToken)
    {
        var dbCartItem = await GetDbCartItem(productId, productTypeId, cancellationToken);

        if (dbCartItem is null)
        {
            return GetServiceResponseWithError(MessageErrorCartNotExists);
        }

        _ecommDbContext.CartItems.Remove(dbCartItem);

        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<bool> { Data = IsSucces };
    }

    public async Task<ServiceResponse<int>> GetCartItemsCount(CancellationToken cancellationToken) =>
        new ()
        {
            Data = (await _ecommDbContext.CartItems
                .Where(x => x.UserId == _httpContextService.GetUserId())
                .CountAsync(cancellationToken))
        };

    public async Task<ServiceResponse<List<CartProductDto>>> GetCartProducts(List<CartItem> cartItems, 
        CancellationToken cancellationToken)
    {
        var result = new ServiceResponse<List<CartProductDto>>
        {
            Data = new List<CartProductDto>()
        };

        foreach (var item in cartItems)
        {
            var product = await _ecommDbContext.Products
                .Where(p => p.Id == item.ProductId)
                .Select(x=> new 
                { 
                    x.Id, 
                    x.Title, 
                    x.ImageUrl
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (product == null)
            {
                continue;
            }

            var productVariant = await _ecommDbContext.ProductVariants
                .Where(v => v.ProductId == item.ProductId
                    && v.ProductTypeId == item.ProductTypeId)
                .Include(v => v.ProductType)
                .Select(x => new
                {
                    x.Price,
                    x.ProductTypeId,
                    ProductTypeName = x.ProductType!.Name
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (productVariant == null)
            {
                continue;
            }

            var cartProduct = new CartProductDto
            {
                ProductId = product.Id,
                Title = product.Title,
                ImageUrl = product.ImageUrl,
                Price = productVariant.Price,
                ProductType = productVariant.ProductTypeName,
                ProductTypeId = productVariant.ProductTypeId,
                Quantity = item.Quantity
            };

            result.Data.Add(cartProduct);
        }

        return result;
    }

    public async Task<ServiceResponse<List<CartProductDto>>> GetDbCartProducts(CancellationToken cancellationToken) =>
        await GetCartProducts(await _ecommDbContext.CartItems
            .Where(x => x.UserId == _httpContextService.GetUserId())
            .ToListAsync(cancellationToken), cancellationToken);

    public async Task<ServiceResponse<List<CartProductDto>>> StoreCartItems(List<CartItem> cartItems,
        CancellationToken cancellationToken)
    {
        cartItems.ForEach(cartItem => cartItem.UserId = _httpContextService.GetUserId());

        await _ecommDbContext.CartItems.AddRangeAsync(cartItems, cancellationToken);

        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return await GetDbCartProducts(cancellationToken);
    }

    private async Task<CartItem?> GetDbCartItem(Guid productId, Guid productTypeId,
        CancellationToken cancellationToken,
        Guid userId = default)
    {
        userId = userId == default ? _httpContextService.GetUserId() : userId;

        return await _ecommDbContext.CartItems.FirstOrDefaultAsync(x => x.UserId == userId &&
                    x.ProductId == productId &&
                    x.ProductTypeId == productTypeId,
                cancellationToken);
    }

    private static ServiceResponse<bool> GetServiceResponseWithError(string message) => 
        new()
        {
            Data = !IsSucces,
            Message = message,
            Succes = !IsSucces
        };
}
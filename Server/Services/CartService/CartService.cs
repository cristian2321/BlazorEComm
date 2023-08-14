using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.CartService;

public class CartService : ICartService
{
    private readonly EcommDbContext _ecommDbContext;

    public CartService(EcommDbContext ecommDbContext)
    {
        _ecommDbContext = ecommDbContext;
    }

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
            };

            result.Data.Add(cartProduct);
        }

        return result;
    }
}

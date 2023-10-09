using BlazorEComm.Server.Data;
using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.CartService;

public class CartService : ICartService
{
    private readonly IHttpContextService _httpContextService;
    private readonly IRepository _repository;
    private readonly ICartExtensionRepository _cartExtensionRepository;
    private readonly IProductExtensionRepository _productExtensionRepository;
    private readonly IProductVariantExtensionRepository _productVariantExtensionRepository;

    public CartService(ICartExtensionRepository cartExtensionRepository, 
        IRepository repository,  
        IProductExtensionRepository productExtensionRepository,
        IProductVariantExtensionRepository productVariantExtensionRepository,
        IHttpContextService httpContextService)
    {
        _cartExtensionRepository = cartExtensionRepository;
        _repository = repository;
        _productExtensionRepository = productExtensionRepository;
        _productVariantExtensionRepository = productVariantExtensionRepository;
        _httpContextService = httpContextService;
    }

    public async Task<ServiceResponse<bool>> AddToCart(CartItem cartItem, CancellationToken cancellationToken)
    {
        bool addedOrUpdated;

        cartItem.UserId = _httpContextService.GetUserId();

        var sameItem = await _cartExtensionRepository.GetDbCartItem(cartItem.ProductId,
            cartItem.ProductTypeId,
            cancellationToken,
            cartItem.UserId);

        if (sameItem is null)
        {
            addedOrUpdated = _repository.Add(cartItem);
        }
        else
        {
            sameItem.Quantity += cartItem.Quantity;

            addedOrUpdated = _repository.Update(sameItem);
        }

        if (addedOrUpdated)
        {
            addedOrUpdated = await _repository.SaveChangesAsync(cancellationToken);
        }

        return addedOrUpdated ?
            new() { Data = ConstantServerServices.IsSucces } :
            GetServiceResponseWithError(MessagesServerServices.MessageCartNotAdded);
    }

    public async Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem, CancellationToken cancellationToken)
    {
        var dbCartItem = await _cartExtensionRepository.GetDbCartItem(cartItem.ProductId, cartItem.ProductTypeId, cancellationToken);

        if (dbCartItem is null)
        {
            return GetServiceResponseWithError(MessagesServerServices.MessageCartNotExists);
        }

        dbCartItem.Quantity = cartItem.Quantity;

        var updated = _repository.Update(dbCartItem);

        if (updated)
        {
            updated = await _repository.SaveChangesAsync(cancellationToken);
        }

        return updated ?
                new() { Data = ConstantServerServices.IsSucces } :
                GetServiceResponseWithError(MessagesServerServices.MessageCartNotUpdated);
    }

    public async Task<ServiceResponse<bool>> RemoveItemFromCart(Guid productId, Guid productTypeId,
        CancellationToken cancellationToken)
    {
        var dbCartItem = await _cartExtensionRepository.GetDbCartItem(productId, productTypeId, cancellationToken);

        if (dbCartItem is null)
        {
            return GetServiceResponseWithError(MessagesServerServices.MessageCartNotExists);
        }

        var deleted = _repository.Delete(dbCartItem);

        if (deleted)
        {
            deleted = await _repository.SaveChangesAsync(cancellationToken);
        }

        return deleted ?
          new() { Data = ConstantServerServices.IsSucces } :
          GetServiceResponseWithError(MessagesServerServices.MessageCartNotDeleted);
    }

    public async Task<ServiceResponse<int>> GetCartItemsCount(CancellationToken cancellationToken) =>
       new() { Data = await _cartExtensionRepository.GetCartItemsCount(cancellationToken) };

    public async Task<List<CartItem>> GetCartItems(CancellationToken cancellationToken) =>
        await _cartExtensionRepository.GetCartItems(cancellationToken);

    public async Task<ServiceResponse<List<CartProductDto>>> GetCartProducts(CancellationToken cancellationToken) =>
        await GetCartProducts(await GetCartItems(cancellationToken), cancellationToken);

    public async Task<ServiceResponse<List<CartProductDto>>> GetCartProducts(List<CartItem> cartItems,
        CancellationToken cancellationToken)
    {
        var result = new ServiceResponse<List<CartProductDto>>
        {
            Data = new List<CartProductDto>()
        };

        foreach (var cartItem in cartItems)
        {
            var product = await _productExtensionRepository
                .GetProductCartById(cartItem.ProductId, cancellationToken);

            if (product is null)
            {
                continue;
            }

            var productVariant = await _productVariantExtensionRepository
                .GetProductTypeCart(cartItem.ProductId, cartItem.ProductTypeId, cancellationToken);

            if (productVariant is null)
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
                Quantity = cartItem.Quantity
            };

            result.Data.Add(cartProduct);
        }

        return result;
    }

    public async Task<ServiceResponse<List<CartProductDto>>> StoreCartItems(List<CartItem> cartItems,
        CancellationToken cancellationToken)
    {
        cartItems.ForEach(cartItem => 
        {
            cartItem.UserId = _httpContextService.GetUserId();

            _repository.Add(cartItem);
        });
 
        return await GetCartProducts(cancellationToken);
    }


    public void RemoveRangeCartItems(List<CartItem> cartItems) =>
       _cartExtensionRepository.RemoveRangeCartItems(cartItems);

    private static ServiceResponse<bool> GetServiceResponseWithError(string message) =>
        new()
        {
            Data = !ConstantServerServices.IsSucces,
            Message = message,
            Succes = !ConstantServerServices.IsSucces
        };
}
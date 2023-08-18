using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.OrderService;

public class OrderService : IOrderService
{
    private readonly EcommDbContext _ecommDbContext;
    private readonly ICartService _cartService;
    private readonly IHttpContextService _httpContextService;
    
    public OrderService(EcommDbContext ecommDbContext, ICartService cartService, IHttpContextService httpContextService)
    {
        _ecommDbContext = ecommDbContext;
        _cartService = cartService;
        _httpContextService = httpContextService;
    }

    private const bool IsSucess = true;

    public async Task<ServiceResponse<bool>> PlaceOrder(CancellationToken cancellationToken)
    {
        var products = (await _cartService.GetDbCartProducts(cancellationToken)).Data;
        if (products is null || !products.Any())
        {
            return new ServiceResponse<bool> { Data = !IsSucess, Message = "No products in the cart" };
        }

        decimal totalPrice = GetTotalPriceForOrder(products);

        var orderItems = GetOrdersItems(products);

        Order order = GetOrder(totalPrice, orderItems);

        _ecommDbContext.Orders.Add(order);

        _ecommDbContext.CartItems.RemoveRange(_ecommDbContext.CartItems
            .Where(x => x.UserId == _httpContextService.GetUserId()));
       
        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<bool> { Data = IsSucess };
    }
    public async Task<ServiceResponse<List<OrderOverviewDto>>> GetOrders(CancellationToken cancellationToken)
    {
        var response = new ServiceResponse<List<OrderOverviewDto>>();

        var orders = await _ecommDbContext.Orders
            .Where(x => x.UserId == _httpContextService.GetUserId())
            .Include(x=> x.OrderItems)
            .ThenInclude(x=>x.Product)
            .OrderByDescending(x=>x.OrderDate)
            .ToListAsync(cancellationToken);

        var orderOverviews = new List<OrderOverviewDto>();
        orders.ForEach(x=> orderOverviews.Add(new OrderOverviewDto 
        {
            Id = x.Id,
            OrderDate = x.OrderDate,
            TotalPrice = x.TotalPrice,
            ProductName = x.OrderItems.Count > 1 ? $"{x.OrderItems.First().Product.Title} and " +
                $"{x.OrderItems.Count -1} more ..." : x.OrderItems.First().Product.Title,
            ProductImageUrl = x.OrderItems.First().Product.ImageUrl
        }));


        response.Data = orderOverviews;
        return response;
    }

    private static decimal GetTotalPriceForOrder(List<CartProductDto> products)
    {
        decimal totalPrice = 0;
        
        products.ForEach(product => totalPrice += product.Price * product.Quantity);
      
        return totalPrice;
    }

    private static List<OrderItem> GetOrdersItems(List<CartProductDto> products)
    {
        var orderItems = new List<OrderItem>();
        
        products.ForEach(product => orderItems.Add(new OrderItem
        {
            ProductId = product.ProductId,
            ProductTypeId = product.ProductTypeId,
            Quantity = product.Quantity,
            TotalPrice = product.Price * product.Quantity
        }));

        return orderItems;
    }

    private Order GetOrder(decimal totalPrice, List<OrderItem> orderItems) =>
        new()
        {
            UserId = _httpContextService.GetUserId(),
            OrderDate = DateTime.Now,
            TotalPrice = totalPrice,
            OrderItems = orderItems
        };   
}
using BlazorEComm.Server.Data;
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
    private const string OrderNotFound = "Order not found";

    public async Task<ServiceResponse<bool>> PlaceOrder(CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();

        var products = (await _cartService.GetDbCartProducts(cancellationToken)).Data;
        if (products is null || !products.Any())
        {
            return new ServiceResponse<bool> { Data = !IsSucess, Message = "No products in the cart" };
        }

        decimal totalPrice = GetTotalPriceForOrder(products);

        var orderItems = GetOrdersItems(products);

        var order = GetOrder(userId, totalPrice, orderItems);

        _ecommDbContext.Orders.Add(order);

        _ecommDbContext.CartItems.RemoveRange(_ecommDbContext.CartItems
            .Where(x => x.UserId == userId));
       
        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<bool> { Data = IsSucess };
    }

    public async Task<ServiceResponse<bool>> RemoveOrderCancelPayments(CancellationToken cancellationToken) 
    {
        var userId = _httpContextService.GetUserId();
        var order = await _ecommDbContext.Orders
            .Where(x => x.UserId == userId)
            .Include(x=>x.OrderItems)
            .OrderByDescending(x => x.OrderDate)
            .FirstOrDefaultAsync(cancellationToken);

        if (order is null)
        {
            return new ServiceResponse<bool> {Data = !IsSucess, Succes = !IsSucess, Message = OrderNotFound};
        }

        var cartItems = new List<CartItem>();
        order.OrderItems.ForEach(x => cartItems.Add(new()
        {
            ProductId = x.ProductId,
            ProductTypeId = x.ProductTypeId,
            Quantity = x.Quantity,
            UserId = userId
        }));

        await _ecommDbContext.AddRangeAsync(cartItems, cancellationToken);
        _ecommDbContext.RemoveRange(order.OrderItems);
        _ecommDbContext.Remove(order);

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
            IsPayment = x.IsPayment,
            OrderDate = x.OrderDate,
            TotalPrice = x.TotalPrice,
            ProductName = x.OrderItems.Count > 1 ? $"{x.OrderItems.First().Product.Title} and " +
                $"{x.OrderItems.Count -1} more ..." : x.OrderItems.First().Product.Title,
            ProductImageUrl = x.OrderItems.First().Product.ImageUrl
        }));


        response.Data = orderOverviews;
        return response;
    }

    public async Task<ServiceResponse<OrderDetailsDto>> GetOrderDetails(Guid orderId, CancellationToken cancellationToken)
    {
        var response = new ServiceResponse<OrderDetailsDto>();

        var order = await GetOrder(orderId, cancellationToken);

        if (order is null)
        {
            response.Succes = !IsSucess;
            response.Message = "Order does not exists !";

            return response;
        }

        var orderDetails = GetOrderDetails(order);

        AddOrderDetails(order, orderDetails);

        response.Data = orderDetails;
        return response;
    }

    public async Task<ServiceResponse<bool>> UpdateOrderPaymentFlag(CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();
        var order = await _ecommDbContext.Orders
            .Where(x => x.UserId == userId)
            .Include(x => x.OrderItems)
            .OrderByDescending(x => x.OrderDate)
            .FirstOrDefaultAsync(cancellationToken);

        if (order is null)
        {
            return new ServiceResponse<bool> { Data = !IsSucess, Succes = !IsSucess, Message = OrderNotFound };
        }

        order.IsPayment = IsSucess;

        await _ecommDbContext.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<bool> { Data = IsSucess };
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

    private static Order GetOrder(Guid userId, decimal totalPrice, List<OrderItem> orderItems) =>
        new()
        {
            UserId = userId,
            OrderDate = DateTime.Now,
            TotalPrice = totalPrice,
            OrderItems = orderItems
        };

    private async Task<Order?> GetOrder(Guid orderId, CancellationToken cancellationToken)
    {
        return await _ecommDbContext.Orders
            .Where(x => x.Id == orderId &&
                x.UserId == _httpContextService.GetUserId())
            .Include(x => x.OrderItems)
            .ThenInclude(x => x.Product)
            .Include(x => x.OrderItems)
            .ThenInclude(x => x.ProductType)
            .OrderByDescending(x => x.OrderDate)
            .FirstOrDefaultAsync(cancellationToken);
    }
    
    private static OrderDetailsDto GetOrderDetails(Order order) =>
        new()
        {
            OrderDate = order.OrderDate,
            TotalPrice = order.TotalPrice,
            OrderDetailsProducts = new List<OrderDetailsProductDto>()
        };

    private static void AddOrderDetails(Order order, OrderDetailsDto orderDetails) =>
        order.OrderItems.ForEach(o =>
            orderDetails.OrderDetailsProducts
            .Add(new()
            {
                ProductId = o.ProductId,
                ImageUrl = o.Product.ImageUrl,
                ProductType = o.ProductType.Name,
                Quantity = o.Quantity,
                Title = o.Product.Title,
                TotalPrice = o.TotalPrice,
            }));
}
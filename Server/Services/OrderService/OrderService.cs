using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.OrderService;

public class OrderService : IOrderService
{
    private readonly ICartService _cartService;
    private readonly IHttpContextService _httpContextService;
    private readonly IRepository _repository;
    private readonly IOrderExtensionRepository _orderExtensionRepository;
    
    public OrderService(ICartService cartService, 
        IHttpContextService httpContextService,
        IRepository repository,
        IOrderExtensionRepository orderExtensionRepository)
    {
        _cartService = cartService;
        _httpContextService = httpContextService;
        _repository = repository;
        _orderExtensionRepository = orderExtensionRepository;
    }

    public async Task<ServiceResponse<bool>> PlaceOrder(CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();

        var products = (await _cartService.GetCartProducts(cancellationToken)).Data;
        if (products is null || !products.Any())
        {
            return new ()
            {
                Succes = !ConstantServerServices.IsSucces, 
                Message = MessagesServerServices.MessageCartProductsEmpty 
            };
        }

        decimal totalPrice = GetTotalPriceForOrder(products);

        var orderItems = GetOrdersItems(products);

        var order = GetOrder(userId, totalPrice, orderItems);

        var added = _repository.Add(order);
        if (added)
        {
            var cartItems = await _cartService.GetCartItems(cancellationToken);
            if (cartItems is not null && cartItems.Any())
            {
                _cartService.RemoveRangeCartItems(cartItems);
            }

            added = await _repository.SaveChangesAsync(cancellationToken);
        }

        return new ServiceResponse<bool> { Data = added };
    }

    public async Task<ServiceResponse<bool>> RemoveOrderCancelPayments(CancellationToken cancellationToken)
    {
        bool transitionValid = true;
        var userId = _httpContextService.GetUserId();
        var order = await _orderExtensionRepository.GetOrder(userId, cancellationToken);

        if (order is null)
        {
            return new ServiceResponse<bool>
            {
                Data = !ConstantServerServices.IsSucces,
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageOrderNotFound
            };
        }

        var cartItems = GetCartItemsFromOrder(userId, order);

        transitionValid = AddCartItems(transitionValid, cartItems);

        if (transitionValid)
        {
            _orderExtensionRepository.RemoveRangeOrderItems(order);

            transitionValid = _repository.Delete(order);
            if (transitionValid)
            {
                await _repository.SaveChangesAsync(cancellationToken);
            }
        }

        return new ServiceResponse<bool> { Data = transitionValid };
    }

    public async Task<ServiceResponse<List<OrderOverviewDto>>> GetOrders(CancellationToken cancellationToken)
    {
        var response = new ServiceResponse<List<OrderOverviewDto>>();

        var orders = await _orderExtensionRepository.GetOrdersWithProducts(cancellationToken);

        var orderOverviews = new List<OrderOverviewDto>();
        orders.ForEach(x => orderOverviews.Add(new OrderOverviewDto
        {
            Id = x.Id,
            IsPayment = x.IsPayment,
            OrderDate = x.OrderDate,
            TotalPrice = x.TotalPrice,
            ProductName = x.OrderItems.Count > 1 ? $"{x.OrderItems.First().Product.Title} and " +
                $"{x.OrderItems.Count - 1} more ..." : x.OrderItems.First().Product.Title,
            ProductImageUrl = x.OrderItems.First().Product.ImageUrl
        }));


        response.Data = orderOverviews;
        return response;
    }

    public async Task<ServiceResponse<OrderDetailsDto>> GetOrderDetails(Guid orderId, CancellationToken cancellationToken)
    {
        var response = new ServiceResponse<OrderDetailsDto>();

        var order = await _orderExtensionRepository.GetOrderWithItemsAndProducts(orderId, cancellationToken);

        if (order is null)
        {
            response.Succes = !ConstantServerServices.IsSucces;
            response.Message = MessagesServerServices.MessageOrderNotExist;

            return response;
        }

        var orderDetails = GetOrderDetails(order);

        AddOrderDetails(order, orderDetails);

        response.Data = orderDetails;
        return response;
    }

    public async Task<List<OrderItem>> GetOrderItemsWithProducts(Guid orderId, CancellationToken cancellationToken) =>
        await _orderExtensionRepository.GetOrderItemsWithProducts(orderId, cancellationToken);    

    public async Task<ServiceResponse<bool>> UpdateOrderPaymentFlag(CancellationToken cancellationToken)
    {
        var userId = _httpContextService.GetUserId();
        var order = await _orderExtensionRepository.GetOrder(userId, cancellationToken);

        if (order is null)
        {
            return new ServiceResponse<bool> 
            {
                Data = !ConstantServerServices.IsSucces, 
                Succes = !ConstantServerServices.IsSucces, 
                Message = MessagesServerServices.MessageOrderNotFound 
            };
        }

        order.IsPayment = ConstantServerServices.IsSucces;

        await _repository.SaveChangesAsync(cancellationToken);

        return new ServiceResponse<bool> { Data = ConstantServerServices.IsSucces };
    }

    private static List<CartItem> GetCartItemsFromOrder(Guid userId, Order order)
    {
        var cartItems = new List<CartItem>();

        order.OrderItems.ForEach(x => cartItems.Add(new()
        {
            ProductId = x.ProductId,
            ProductTypeId = x.ProductTypeId,
            Quantity = x.Quantity,
            UserId = userId
        }));

        return cartItems;
    }

    private bool AddCartItems(bool added, List<CartItem> cartItems)
    {
        foreach (var cartItem in cartItems)
        {
            if (!added)
            {
                break;
            }

            added = _repository.Add(cartItem);
        }

        return added;
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
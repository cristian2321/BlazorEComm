using BlazorEComm.Shared.Dtos;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;

namespace BlazorEComm.Server.Services.PaymentService;

public class PaymentService : IPaymentService
{
    private readonly ICartService _cartService;
    private readonly IHttpContextService _httpContextService;
    private readonly IOrderService _orderService;
    private readonly IOptions<AppSetting> _options;

    public PaymentService(ICartService cartService, 
        IHttpContextService httpContextService, 
        IOrderService orderService,
        IOptions<AppSetting> options)
    {
        _cartService = cartService;
        _httpContextService = httpContextService;
        _orderService = orderService;
        _options = options;
 
        StripeConfiguration.ApiKey = _options.Value.StripeKey;
    }

    public async Task<Session> CreateCheckoutSession(CancellationToken cancellationToken)
    {
        var products = (await _cartService.GetCartProducts(cancellationToken)).Data;
     
        if (products is null || !products.Any())
        {
            return default!;
        }
        
        await _orderService.PlaceOrder(cancellationToken);

        var lineItems = GetSessionLineItemOptions(products);

        return ReturnSessionCreate(lineItems);
    }

    private List<SessionLineItemOptions> GetSessionLineItemOptions(List<CartProductDto> products)
    {
        var lineItems = new List<SessionLineItemOptions>();
     
        products.ForEach(x => lineItems.Add(new()
        {
            PriceData = new()
            {
                UnitAmountDecimal = x.Price * _options.Value.DecimalMultiplier,
                Currency = _options.Value.PaymentCurrency,
                ProductData = new()
                {
                    Name = x.Title,
                    Images = new List<string> { x.ImageUrl }
                }
            },
            Quantity = x.Quantity
        }));
        
        return lineItems;
    }

    public async Task<Session> CreateCheckoutSessionByOrderId(Guid orderId, CancellationToken cancellationToken)
    {
        var detaisOrderProducts = await _orderService.GetOrderItemsWithProducts(orderId, cancellationToken);

        var lineItems = new List<SessionLineItemOptions>();

        detaisOrderProducts.ForEach(x => lineItems.Add(new()
        {
            PriceData = new()
            {
                UnitAmountDecimal = x.TotalPrice / x.Quantity * _options.Value.DecimalMultiplier,
                Currency = _options.Value.PaymentCurrency,
                ProductData = new()
                {
                    Name = x.Product.Title,
                    Images = new List<string> { x.Product.ImageUrl }
                }
            },
            Quantity = x.Quantity
        }));
 
        return ReturnSessionCreate(lineItems);
    }

    private Session ReturnSessionCreate(List<SessionLineItemOptions> lineItems)
    {
        var service = new SessionService();

        return service.Create(new SessionCreateOptions
        {
            CustomerEmail = _httpContextService.GetUserEmail(),
            ShippingAddressCollection = new SessionShippingAddressCollectionOptions 
            {
                AllowedCountries = GetAllowedCountries()
            },
            PaymentMethodTypes = new List<string> { _options.Value.PaymentMethod },
            LineItems = lineItems,
            Mode = _options.Value.PaymentMode,
            SuccessUrl = _options.Value.OrderSuccesUrl,
            CancelUrl = _options.Value.OrderCancelUrl,
        });
    }

    private List<string> GetAllowedCountries()
    {
        List<string> returnValues = new();
        
        var countries = _options.Value.AllowedShippingCountry.Split(",");
        if (countries is not null && countries.Any())
        {
            foreach (var item in countries)
            {
                returnValues.Add(item);
            }
        }

        return returnValues;
    }
}
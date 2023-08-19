using BlazorEComm.Shared.Dtos;
using Stripe;
using Stripe.Checkout;

namespace BlazorEComm.Server.Services.PaymentService;

public class PaymentService : IPaymentService
{
    private readonly ICartService _cartService;
    private readonly IHttpContextService _httpContextService;
    private readonly IOrderService _orderService;
    private readonly IConfiguration _configuration;

    private const string OrderCancelUrlKey = "AppSettings:OrderCancelUrl";
    private const string OrderSuccesUrlKey = "AppSettings:OrderSuccesUrl";
    private const string PaymentCurrencyKey = "AppSettings:PaymentCurrency";
    private const string PaymentMethodKey = "AppSettings:PaymentMethod";
    private const string PaymentModeKey = "AppSettings:PaymentMode";
    private const string StripeKey = "AppSettings:StripeKey";
    private const bool IsSucees = true;
    
    public PaymentService(ICartService cartService, IHttpContextService httpContextService, 
        IOrderService orderService, IConfiguration configuration)
    {
        _cartService = cartService;
        _httpContextService = httpContextService;
        _orderService = orderService;
        _configuration = configuration;

        StripeConfiguration.ApiKey = _configuration[StripeKey];
    }


    public async Task<Session> CreateCheckoutSession(CancellationToken cancellationToken)
    {
        var products = (await _cartService.GetDbCartProducts(cancellationToken)).Data;
     
        if (products is null || !products.Any())
        {
            return default!;
        }
        
        await _orderService.PlaceOrder(cancellationToken);

        var lineItems = GetSessionLineItemOptions(products);

        var service = new SessionService();
        return service.Create(new SessionCreateOptions
        {
            CustomerEmail = _httpContextService.GetUserEmail(),
            ShippingAddressCollection = new SessionShippingAddressCollectionOptions()
            {
                AllowedCountries = new List<string> { "US", "CA" }
            },
            PaymentMethodTypes = new List<string> { _configuration[PaymentMethodKey] },
            LineItems = lineItems,
            Mode = _configuration[PaymentModeKey],
            SuccessUrl = _configuration[OrderSuccesUrlKey],
            CancelUrl = _configuration[OrderCancelUrlKey],
        }); ;
    }

    private List<SessionLineItemOptions> GetSessionLineItemOptions(List<CartProductDto> products)
    {
        var lineItems = new List<SessionLineItemOptions>();
     
        products.ForEach(x => lineItems.Add(new()
        {
            PriceData = new()
            {
                UnitAmountDecimal = x.Price * 100,
                Currency = _configuration[PaymentCurrencyKey],
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
}
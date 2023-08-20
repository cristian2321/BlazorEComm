using Stripe.Checkout;

namespace BlazorEComm.Server.Services.PaymentService;

public interface IPaymentService
{
    Task<Session> CreateCheckoutSession(CancellationToken cancellationToken);

    Task<Session> CreateCheckoutSessionByOrderId(Guid orderId, CancellationToken cancellationToken);
}
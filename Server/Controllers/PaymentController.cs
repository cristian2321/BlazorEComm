﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;
    
    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpPost("checkout"), Authorize]
    public async Task<ActionResult<string>> CreateCheckoutSession(CancellationToken cancellationToken) =>
        Ok((await _paymentService.CreateCheckoutSession(cancellationToken)).Url);


    [HttpPost("checkout/{orderId}"), Authorize]
    public async Task<ActionResult<string>> CreateCheckoutSession(Guid orderId, CancellationToken cancellationToken) =>
        Ok((await _paymentService.CreateCheckoutSessionByOrderId(orderId, cancellationToken)).Url);
} 
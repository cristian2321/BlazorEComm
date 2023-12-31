﻿using System.Security.Claims;

namespace BlazorEComm.Server.Services.HttpContextService;

public class HttpContextService : IHttpContextService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public HttpContextService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetUserEmail() =>
        _httpContextAccessor!.HttpContext!.User.FindFirstValue(ClaimTypes.Name);

    public Guid GetUserId() => 
        Guid.Parse(_httpContextAccessor!.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier));
}

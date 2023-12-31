﻿using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.AuthService;

public interface IAuthService
{
    Task<ServiceResponse<string>> Register(User user, string password, CancellationToken cancellationToken);

    Task<ServiceResponse<string>> Login(string email, string password, CancellationToken cancellationToken);
}
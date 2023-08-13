﻿using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.CategoryService;

public interface ICategoryService
{
    Task<ServiceResponse<List<Category>>> GetCategories(CancellationToken cancellationToken);
}

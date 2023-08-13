﻿using BlazorEComm.Shared;

namespace BlazorEComm.Client.Services.ProductService;

public interface IProductService
{
    event Action? ProductsChanged;

    List<Product> Products { get; set; }

    Task GetProducts(string? categoryUrl = null);

    Task<ServiceResponse<Product>> GetProduct(Guid productId);
}

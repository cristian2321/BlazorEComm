using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IAdminProductService _adminProductService;

    public ProductController(IProductService productService, IAdminProductService adminProductService)
    {
        _productService = productService;
        _adminProductService = adminProductService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts(
        CancellationToken cancellationToken) =>
            Ok(await _productService.GetProducts(cancellationToken));

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(
        Guid id,
        CancellationToken cancellationToken) =>
            Ok(await _productService.GetProduct(id, cancellationToken));
    
    [HttpGet("category/{categoryUrl}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(
        string categoryUrl,
        CancellationToken cancellationToken) =>
            Ok(await _productService.GetProductsByCategory(categoryUrl, cancellationToken));

    [HttpGet("search/{searchText}/{page}")]
    public async Task<ActionResult<ServiceResponse<ProductSearchResultDto>>> SearchProducts(
        string searchText,
        CancellationToken cancellationToken,
        int page = 1) =>
            Ok(await _productService.SearchProducts(searchText, page, cancellationToken));

    [HttpGet("searchsuggestions/{searchText}")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetProductSearchSuggestions(
      string searchText,
      CancellationToken cancellationToken) =>
          Ok(await _productService.GetProductSearchSuggestions(searchText, cancellationToken));

    [HttpGet("featured")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetFeaturedProducts(
     CancellationToken cancellationToken) =>
         Ok(await _productService.GetFeaturedProducts(cancellationToken));

    #region Admin
    
    [HttpPost("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductDto>>>> AddProduct(ProductDto product, CancellationToken cancellationToken) =>
        Ok(await _adminProductService.AddProduct(product, cancellationToken));
    
    [HttpDelete("admin/{productId}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductDto>>>> DeleteProduct(Guid productId, CancellationToken cancellationToken) =>
        Ok(await _adminProductService.DeleteProduct(productId, cancellationToken));

    [HttpGet("admin/titles"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetProductTitles(CancellationToken cancellationToken) =>
        Ok(await _adminProductService.GetProductTitles(cancellationToken));

    [HttpGet("admin/products/{page}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductDto>>>> GetProductsAdmin(int page, CancellationToken cancellationToken) =>
        Ok(await _adminProductService.GetProducts(page, cancellationToken));

    [HttpGet("admin/{productId}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<Product>>> GetProductAdmin(Guid productId, CancellationToken cancellationToken) =>
        Ok(await _adminProductService.GetProduct(productId, cancellationToken));

    [HttpPut("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductDto>>>> UpdateProduct(ProductDto product, CancellationToken cancellationToken) =>
        Ok(await _adminProductService.UpdateProduct(product, cancellationToken));

    #endregion
}
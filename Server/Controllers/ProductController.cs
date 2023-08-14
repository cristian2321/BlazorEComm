using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
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

    [HttpGet("search/{searchText}")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> SearchProducts(
        string searchText,
        CancellationToken cancellationToken) =>
            Ok(await _productService.SearchProducts(searchText, cancellationToken));

    [HttpGet("searchsuggestions/{searchText}")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetProductSearchSuggestions(
      string searchText,
      CancellationToken cancellationToken) =>
          Ok(await _productService.GetProductSearchSuggestions(searchText, cancellationToken));

    [HttpGet("featured")]
    public async Task<ActionResult<ServiceResponse<List<Product>>>> GetFeaturedProducts(
     CancellationToken cancellationToken) =>
         Ok(await _productService.GetFeaturedProducts(cancellationToken));
}
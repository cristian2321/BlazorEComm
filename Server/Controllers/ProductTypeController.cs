using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductTypeController : ControllerBase
{
    private readonly IProductTypeService _productTypeService;

    public ProductTypeController(IProductTypeService productTypeService)
    {
        _productTypeService = productTypeService;
    }

    [HttpPost("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductType>>>> AddProductType(ProductType productType, 
        CancellationToken cancellationToken) =>
             Ok(await _productTypeService.AddProductType(productType, cancellationToken));
    
    [HttpDelete("admin/{productTypeId}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductType>>>> DeleteProductType(Guid productTypeId,
        CancellationToken cancellationToken) =>
            Ok(await _productTypeService.DeleteProductType(productTypeId, cancellationToken));

    [HttpGet("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductType>>>> GetAdminProductTypes(CancellationToken cancellationToken) =>
        Ok(await _productTypeService.GetAdminProductTypes(cancellationToken));
   
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<ProductType>>>> GetProductTypes(CancellationToken cancellationToken) =>
        Ok(await _productTypeService.GetProductTypes(cancellationToken));

    [HttpGet("admin/{productTypeId}"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductType>>>> GetAdminProductType(Guid productTypeId, CancellationToken cancellationToken) =>
        Ok(await _productTypeService.GetAdminProductType(productTypeId, cancellationToken));

    [HttpGet("admin/productTypeNames"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<string>>>> GetProductTypeNames(CancellationToken cancellationToken) =>
        Ok(await _productTypeService.GetProductTypeNames(cancellationToken));

    [HttpPut("admin"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ServiceResponse<List<ProductType>>>> UpdateProductType(ProductType productType,
        CancellationToken cancellationToken) =>
            Ok(await _productTypeService.UpdateProductType(productType, cancellationToken));
}
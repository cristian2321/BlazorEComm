using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEComm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariantController : ControllerBase
    {
        private readonly IProductVariantService _productVariantService;

        public ProductVariantController(IProductVariantService productVariantService)
        {
            _productVariantService = productVariantService;
        }

        [HttpPost("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<ProductVariantDto>>>> AddProductVariant(ProductVariantDto productVariant,
            CancellationToken cancellationToken) =>
                 Ok(await _productVariantService.AddProductVariant(productVariant, cancellationToken));

        [HttpDelete("admin/{productId}/{productTypeId}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<ProductVariantDto>>>> DeleteProductVariant(Guid productId, Guid productTypeId,
            CancellationToken cancellationToken) =>
                Ok(await _productVariantService.DeleteProductVariant(productId, productTypeId, cancellationToken));

        [HttpGet("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<ProductVariantDto>>>> GetAdminProductVariants(CancellationToken cancellationToken) =>
            Ok(await _productVariantService.GetAdminProductVariants(cancellationToken));

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProductVariantDto>>>> GetProductVariants(CancellationToken cancellationToken) =>
            Ok(await _productVariantService.GetProductVariants(cancellationToken));

        [HttpGet("admin/{productId}/{productTypeId}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<ProductVariantDto>>>> GetAdminProductVariant(Guid productId, Guid productTypeId, 
            CancellationToken cancellationToken) =>
                Ok(await _productVariantService.GetAdminProductVariant(productId, productTypeId, cancellationToken));

        [HttpPut("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<ProductVariantDto>>>> UpdateProductType(ProductVariantDto productVariant,
            CancellationToken cancellationToken) =>
                Ok(await _productVariantService.UpdateProductVariant(productVariant, cancellationToken));
    }
}
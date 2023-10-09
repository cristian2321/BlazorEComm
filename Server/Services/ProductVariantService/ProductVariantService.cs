using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductVariantService;

public class ProductVariantService : IProductVariantService
{
    private readonly IAdminProductService _adminProductService;
    private readonly IProductTypeService _productTypeService;
    private readonly IRepository _repository;
    private readonly IProductVariantExtensionRepository _productVariantExtensionRepository;

    public ProductVariantService(IAdminProductService adminProductService, 
        IProductTypeService productTypeService, 
        IRepository repository,
        IProductVariantExtensionRepository productVariantExtensionRepository )
    {
        _adminProductService = adminProductService;
        _productTypeService = productTypeService;
        _repository = repository;
        _productVariantExtensionRepository = productVariantExtensionRepository; 
    }

    public async Task<ServiceResponse<List<ProductVariantDto>>> AddProductVariant(ProductVariantDto productVariant, CancellationToken cancellationToken)
    {
        var productId = await _adminProductService.GetProductIdByTitle(productVariant.Product, cancellationToken);
        if (productId == Guid.Empty)
        {
            return new ServiceResponse<List<ProductVariantDto>>
            {
                Message = MessagesServerServices.MessageProductNotFound,
                Succes = !ConstantServerServices.IsSucces
            };
        }

        var productTypeId = await _productTypeService.GetProductTypeIdByName(productVariant.ProductType, cancellationToken);
        if (productTypeId == Guid.Empty)
        {
            return new ServiceResponse<List<ProductVariantDto>>
            {
                Message = MessagesServerServices.MessageProductTypeNotFound,
                Succes = !ConstantServerServices.IsSucces
            };
        }

        var dbProductVariant = await _productVariantExtensionRepository
            .GetProductVariantByProductIdAndProductTypeId(productId, productTypeId, cancellationToken);
        
        if (dbProductVariant is not null)
        {
            return await GetAdminProductVariants(cancellationToken);
        }

        var added = _repository.Add(new ProductVariant
        {
            Deleted = productVariant.Deleted,
            OriginalPrice = productVariant.OriginalPrice,
            Price = productVariant.Price,
            ProductId = productId,
            ProductTypeId = productTypeId,
            Visible = productVariant.Visible,
        });

        if (added)
        {
            await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetAdminProductVariants(cancellationToken);
    }

    public async Task<ServiceResponse<List<ProductVariantDto>>> DeleteProductVariant(Guid productId, Guid productTypeId, CancellationToken cancellationToken)
    {
        var productVariant = await _productVariantExtensionRepository
            .GetProductVariantByProductIdAndProductTypeId(productId, productTypeId, cancellationToken);
        
        if (productVariant is null)
        {
            return new ServiceResponse<List<ProductVariantDto>>
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageProductVariantNotFound
            };
        }

        productVariant.Deleted = ConstantServerServices.IsDelete;
        productVariant.Visible = !ConstantServerServices.IsVisible;

        var updated = _repository.Update(productVariant);
        if (updated)
        {
            await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetAdminProductVariants(cancellationToken);
    }

    public async Task<ServiceResponse<ProductVariantDto?>> GetAdminProductVariant(Guid productId, Guid productTypeId, CancellationToken cancellationToken)
    {
        var productVariant = await _productVariantExtensionRepository
            .GetAdminProductVariant(productId, productTypeId, cancellationToken);    

        return productVariant is null ?
            new() { Succes = !ConstantServerServices.IsSucces, Message = MessagesServerServices.MessageProductVariantNotFound } :
            new() { Data = productVariant };
    }

    public async Task<ServiceResponse<List<ProductVariantDto>>> GetAdminProductVariants(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _productVariantExtensionRepository.GetAdminProductVariants(cancellationToken)
        };

    public async Task<ServiceResponse<List<ProductVariantDto>>> GetProductVariants(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _productVariantExtensionRepository 
                .GetProductVariants(cancellationToken)
        };

    public async Task<ServiceResponse<List<ProductVariantDto>>> UpdateProductVariant(ProductVariantDto productVariant, CancellationToken cancellationToken)
    { 
        var productId = await _adminProductService.GetProductIdByTitle(productVariant.Product, cancellationToken);
        if (productId == Guid.Empty)
        {
            return new ServiceResponse<List<ProductVariantDto>>
            {
                Message = MessagesServerServices.MessageProductNotFound,
                Succes = !ConstantServerServices.IsSucces
            };
        }

        var productTypeId = await _productTypeService.GetProductTypeIdByName(productVariant.ProductType, cancellationToken);
        if (productTypeId == Guid.Empty)
        {
            return new ServiceResponse<List<ProductVariantDto>>
            {
                Message = MessagesServerServices.MessageProductTypeNotFound,
                Succes = !ConstantServerServices.IsSucces
            };
        }

        var dbproductVariant = await _productVariantExtensionRepository
            .GetProductVariantByProductIdAndProductTypeId(productId, productTypeId, cancellationToken);
        
        if (dbproductVariant is null)
        {
            return new ServiceResponse<List<ProductVariantDto>>
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageProductVariantNotFound
            };
        }

        dbproductVariant.Visible = productVariant.Visible;
        dbproductVariant.Price = productVariant.Price;
        dbproductVariant.OriginalPrice = productVariant.OriginalPrice;

        var updated = _repository.Update(dbproductVariant);
        if (updated)
        {
            await _repository.SaveChangesAsync(cancellationToken);
        }
        
        return await GetAdminProductVariants(cancellationToken);
    }
}
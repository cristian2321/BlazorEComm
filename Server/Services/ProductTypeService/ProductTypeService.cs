using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductTypeService;

public class ProductTypeService : IProductTypeService
{
    private readonly IRepository _repository;
    private readonly IProductTypeExtensionRepository _productTypeExtensionRepository;
    private readonly IProductVariantExtensionRepository _productVariantExtensionRepository;

    public ProductTypeService(IRepository repository,
        IProductTypeExtensionRepository productTypeExtensionRepository, 
        IProductVariantExtensionRepository productVariantExtensionRepository)
    {
        _repository = repository;
        _productTypeExtensionRepository = productTypeExtensionRepository;
        _productVariantExtensionRepository = productVariantExtensionRepository;
    }

    public async Task<ServiceResponse<List<ProductType>>> AddProductType(ProductType productType, CancellationToken cancellationToken)
    {
        if (! await _productTypeExtensionRepository.AnyDbProductType(productType.Name, cancellationToken))
        {
            var added = _repository.Add(productType);
            if (added)
            {
                _ = _repository.SaveChangesAsync(cancellationToken);
            } 
        }

        return await GetAdminProductTypes(cancellationToken);
    }

    public async Task<ServiceResponse<List<ProductType>>> DeleteProductType(Guid productTypeId, CancellationToken cancellationToken)
    {
        var productType = await GetProductTypeById(productTypeId, cancellationToken);
        if (productType is null)
        {
            return new ServiceResponse<List<ProductType>>
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageProductTypeNotFound
            };
        }

        await DeleteProductVariants(productType, cancellationToken);

        productType.Deleted = ConstantServerServices.IsDelete;
        productType.Visible = !ConstantServerServices.IsVisible;

        var update = _repository.Update(productType);
        if (update) 
        { 
            await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetAdminProductTypes(cancellationToken);
    }

    public async Task<ServiceResponse<ProductType?>> GetAdminProductType(Guid productTypeId, CancellationToken cancellationToken)
    {
        var productType = await GetProductTypeById(productTypeId, cancellationToken);
        return productType is not null ?
            new() { Data = productType } :
            new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageProductTypeNotFound
            };
    }

    public async Task<ServiceResponse<List<ProductType>>> GetAdminProductTypes(CancellationToken cancellationToken) => 
        new ()
        {
            Data = await _productTypeExtensionRepository.GetAdminProductTypes(cancellationToken)
        };

    public async Task<ServiceResponse<List<string>>> GetProductTypeNames(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _productTypeExtensionRepository.GetProductTypeNames(cancellationToken)
        };

    public async Task<ServiceResponse<List<ProductType>>> GetProductTypes(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _productTypeExtensionRepository.GetProductTypes(cancellationToken)
        };

    public async Task<ServiceResponse<List<ProductType>>> UpdateProductType(ProductType productType, CancellationToken cancellationToken)
    {
        var dbproductType = await GetProductTypeById(productType.Id, cancellationToken);
        if (dbproductType is null)
        {
            return new ServiceResponse<List<ProductType>> 
            {
                Succes = !ConstantServerServices.IsSucces, 
                Message = MessagesServerServices.MessageProductTypeNotFound 
            };
        }

        dbproductType.Name = productType.Name;
        if (dbproductType.Visible && !productType.Visible)
        {
            await UpdateProductTypeProductVariantsNotVisible(dbproductType, cancellationToken);
        }

        else if (!dbproductType.Visible && productType.Visible)
        {
            await UpdateProductTypeProductVariantsVisible(dbproductType, cancellationToken);
        }

        dbproductType.Visible = productType.Visible;

        var updated = _repository.Update(dbproductType);
        if (updated)
        {
            await _repository.SaveChangesAsync(cancellationToken);
        }
        
        return await GetAdminProductTypes(cancellationToken);
    }
    
    public async Task<Guid> GetProductTypeIdByName(string name, CancellationToken cancellationToken) =>
        await _productTypeExtensionRepository.GetProductTypeIdByName(name, cancellationToken);

    private async Task DeleteProductVariants(ProductType productType, CancellationToken cancellationToken)
    {
        var productsVariants = await _productVariantExtensionRepository
            .GetProductVariantsByProductTypeId(productType.Id, cancellationToken);

        if (productsVariants is not null && productsVariants.Any())
        {
            productsVariants.ForEach(x =>
            {
                x.Visible = !ConstantServerServices.IsVisible;
                x.Deleted = ConstantServerServices.IsDelete;
            });
        }
    }

    private async Task<ProductType?> GetProductTypeById(Guid productTypeId, CancellationToken cancellationToken) =>
        await _productTypeExtensionRepository.GetProductTypeById(productTypeId, cancellationToken);

    private async Task UpdateProductTypeProductVariantsVisible(ProductType productType, CancellationToken cancellationToken)
    {
        var productsVariants  = await _productVariantExtensionRepository
            .GetProductVariantsNotVisibleByProductTypeId(productType.Id, cancellationToken);
        
        if (productsVariants is not null && productsVariants.Any())
        {
            productsVariants.ForEach(x => 
            {
                if (x.Product is not null && !x.Product.Deleted && x.Product.Visible)
                {
                    x.Visible = ConstantServerServices.IsVisible;
                }
            });
        }
    }

    private async Task UpdateProductTypeProductVariantsNotVisible(ProductType productType, CancellationToken cancellationToken)
    {
        var productsVariants = await _productVariantExtensionRepository
            .GetProductVariantsVisibleByProductTypeId(productType.Id, cancellationToken);

        if (productsVariants is not null && productsVariants.Any())
        {
            productsVariants.ForEach(x => { x.Visible = !ConstantServerServices.IsVisible; });
        }
    }
}
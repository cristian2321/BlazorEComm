using BlazorEComm.Shared.Constants;
using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductService;

public class AdminProductService : IAdminProductService
{
    private readonly IConfigurationService _configurationService;
    private readonly ICategoryService _categoryService;
    private readonly IRepository _repository;
    private readonly IProductExtensionRepository _productExtensionRepository;
    private readonly IProductVariantExtensionRepository _productVariantExtensionRepository;

    public AdminProductService(IConfigurationService configurationService,
        ICategoryService categoryService, 
        IRepository repository, 
        IProductExtensionRepository productExtensionRepository,
        IProductVariantExtensionRepository productVariantExtensionRepository)
    {
        _configurationService = configurationService;
        _categoryService = categoryService;
        _repository = repository;
        _productExtensionRepository = productExtensionRepository;
        _productVariantExtensionRepository = productVariantExtensionRepository;
    }
    
    public async Task<ServiceResponse<List<ProductDto>>> AddProduct(ProductDto product, CancellationToken cancellationToken)
    {
        if (! await _productExtensionRepository.AnyDbProduct(product.Title, cancellationToken))
        {
            var productModel = product.GetProductFromProductDto();
            productModel.CategoryId = (await _categoryService.GetCategoryIdByName(product.CategoryName, cancellationToken))!.Data;

            var added = _repository.Add(productModel);
            if (added)
            {
                await _repository.SaveChangesAsync(cancellationToken);
            }
        }

        return await GetProducts(ConstantServerServices.DefaultPageProducts, cancellationToken);
    }

    public async Task<ServiceResponse<List<ProductDto>>> DeleteProduct(Guid productId, CancellationToken cancellationToken)
    {
        var product = (await GetProduct(productId, cancellationToken)).Data;
        if (product is null)
        {
            return new ServiceResponse<List<ProductDto>> 
            {
                Message = MessagesServerServices.MessageProductNotFound,
                Succes = !ConstantServerServices.IsSucces
            };
        }

        await DeleteProductProductVariantsForNotVisible(product, cancellationToken);

        product.Deleted = ConstantServerServices.IsDelete;
        product.Visible = !ConstantServerServices.IsVisible;

        var updated = _repository.Update(product);
        if (updated) 
        {
            await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetProducts(ConstantServerServices.DefaultPageProducts, cancellationToken);
    }

    public async Task<ServiceResponse<Product>> GetProduct(Guid productId, CancellationToken cancellationToken)
    {
        var product = await _productExtensionRepository.GetProductWithCategory(productId, cancellationToken); 
        
        return product is null ?
            new()
            {
                Message = MessagesServerServices.MessageProductNotFound,
                Succes = !ConstantServerServices.IsSucces
            }:
            new() { Data = product };
    }

    public async Task<ServiceResponse<List<ProductDto>>> GetProducts(int page, CancellationToken cancellationToken)
    {
        var products = new List<ProductDto>();
        var languageConfigResult = await _configurationService.GetConfigurationValue(ClientConstants.DefaultLanguage, string.Empty, cancellationToken);
        if (languageConfigResult is null || !languageConfigResult.Succes || string.IsNullOrWhiteSpace(languageConfigResult.Data))
        {
            return new() { Data = products };
        }

        var configValue = await _configurationService.GetConfigurationValue(ConstantServerServices.ConfigKeyProductsByPage,
            languageConfigResult.Data,  cancellationToken);

        int productsByPage = configValue.Data is null || !configValue.Succes ?
            ConstantServerServices.DefaultPageProducts :
            int.Parse(configValue.Data);

        var productsModels = await _productExtensionRepository.GetAdminProducts(page, productsByPage, cancellationToken);

        productsModels.ForEach(x => products.Add(x.GetProductDtoFromProduct()));

        return new() { Data = products };
    }

    public async Task<ServiceResponse<List<string>>> GetProductTitles(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _productExtensionRepository.GetProductTitles(cancellationToken) 
        };

    public async Task<ServiceResponse<List<ProductDto>>> UpdateProduct(ProductDto product, CancellationToken cancellationToken)
    {
        var dbProduct = (await GetProduct(product.Id, cancellationToken)).Data;
        if (dbProduct is null)
        {
            return new()
            {
                Succes = !ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageProductTypeNotFound
            };
        }

        dbProduct.Featured = product.Featured;
        dbProduct.Title = product.Title;
        dbProduct.Description = product.Description;
        dbProduct.ImageUrl = product.ImageUrl;

        if (product.Visible && !dbProduct.Visible)
        {
            await UpdateProductProductVariantsForVisible(dbProduct, cancellationToken);
        }

        else if (!product.Visible && dbProduct.Visible)
        {
            await UpdateProductProductVariantsForNotVisible(dbProduct, cancellationToken);
        }

        dbProduct.Visible = product.Visible;
        await UpdateProductCategory(product, dbProduct, cancellationToken);

        UpdateProductImages(product, dbProduct);

        var updated = _repository.Update(dbProduct);
        if (updated)
        {
            await _repository.SaveChangesAsync(cancellationToken);
        }

        return await GetProducts(ConstantServerServices.DefaultPageProducts, cancellationToken);
    }

    public async Task<Guid> GetProductIdByTitle(string title, CancellationToken cancellationToken) =>
        await _productExtensionRepository.GetProductIdByTitle(title, cancellationToken);   

    private async Task DeleteProductProductVariantsForNotVisible(Product product, CancellationToken cancellationToken)
    {
        var productsVariants = await _productVariantExtensionRepository.GetProductVariantsByProductId(product.Id, cancellationToken);   

        if (productsVariants is not null && productsVariants.Any())
        {
            productsVariants.ForEach(x =>
            {
                x.Visible = !ConstantServerServices.IsVisible;
                x.Deleted = ConstantServerServices.IsDelete;
            });
        }
    }

    private async Task UpdateProductProductVariantsForVisible(Product product, CancellationToken cancellationToken)
    {
        var productVariants = await _productVariantExtensionRepository.GetProductVariantsNotVisibleByProductId(product.Id, cancellationToken);

        if (productVariants is not null && productVariants.Any())
        {
            productVariants.ForEach(x =>
            {
                if (x.ProductType is not null && !x.ProductType.Deleted && x.ProductType.Visible)
                {
                    x.Visible = ConstantServerServices.IsVisible;
                }
            });
        }
    }

    private async Task UpdateProductProductVariantsForNotVisible(Product product, CancellationToken cancellationToken)
    {
        var productVariants = await _productVariantExtensionRepository.GetProductVariantsVisibleByProductId(product.Id, cancellationToken);

        if (productVariants is not null && productVariants.Any())
        {
            productVariants.ForEach(x =>
            {
                x.Visible = !ConstantServerServices.IsVisible;
            });
        }
    }

    private async Task UpdateProductCategory(ProductDto product, Product dbProduct, CancellationToken cancellationToken)
    {
        if (dbProduct.Category is null 
            || string.IsNullOrWhiteSpace(dbProduct.Category.Name) 
            || dbProduct.Category.Name.ToLower() != product.CategoryName.ToLower())
        {
            dbProduct.CategoryId = (await _categoryService.GetCategoryIdByName(product.CategoryName, cancellationToken))!.Data;
        }
    }

    private void UpdateProductImages(ProductDto product, Product dbProduct)
    {
        var productsImages = dbProduct.Images;
        _productExtensionRepository.RemoveProductsImages(productsImages);
        dbProduct.Images = product.Images;
    }
}
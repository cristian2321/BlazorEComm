namespace BlazorEComm.Client.Services.ProductTypeService;

public interface IProductTypeService
{
    event Action? OnChange;

    List<ProductType> AdminProductTypes { get; set; }

    List<ProductType> ProductTypes { get; set; }

    Task GetAdminProductTypes();

    Task GetProductTypes();

    Task<List<string>> GetAdminProductTypeNames();

    Task<ProductType?> GetAdminProductType(Guid productTypeId);

    Task AddProductType(ProductType productType);

    Task UpdateProductType(ProductType productType);

    Task<bool> DeleteProductType(Guid productTypeId);
}
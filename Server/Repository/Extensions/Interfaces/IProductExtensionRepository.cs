using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Repository.Extensions.Interfaces;

public interface IProductExtensionRepository
{
    Task<bool> AnyDbProduct(string title, CancellationToken cancellationToken);

    Task<List<Product>> FindProductsBySearchText(string searchText, CancellationToken cancellationToken);

    Task<List<Product>> FindProductsBySearchTextWithPage(string searchText, float pageResults, int page, CancellationToken cancellationToken);

    Task<ProductCartDto?> GetProductCartById(Guid productId, CancellationToken cancellationToken);
    
    Task<List<Product>> GetAdminProducts(int page, int productsByPage, CancellationToken cancellationToken);

    Task<List<Product>> GetProducts(CancellationToken cancellationToken);

    Task<Product?> GetProductWithCategory(Guid productId, CancellationToken cancellationToken);

    Task<List<string>> GetProductTitles(CancellationToken cancellationToken);

    Task<Guid> GetProductIdByTitle(string title, CancellationToken cancellationToken);

    Task<Product?> GetProduct(Guid productId, CancellationToken cancellationToken);

    Task<List<Product>> GetProductsByCategory(string categoryUrl, CancellationToken cancellationToken);

    Task<List<Product>> GetFeaturedProducts(CancellationToken cancellationToken);

    void RemoveProductsImages(List<Image> images);
}
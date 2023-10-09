using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Messages;
using BlazorEComm.Shared.Models;

namespace BlazorEComm.Server.Services.ProductService;

public class ProductService : IProductService
{
    private readonly IProductExtensionRepository _productExtensionRepository;

    public ProductService(IProductExtensionRepository productExtensionRepository)
    {
        _productExtensionRepository = productExtensionRepository;
    }

    public async Task<ServiceResponse<Product>> GetProduct(Guid productId, CancellationToken cancellationToken)
    {
        var product = await _productExtensionRepository.GetProduct(productId, cancellationToken);

        return product is null ?
            new()
            {
                Succes = !!ConstantServerServices.IsSucces,
                Message = MessagesServerServices.MessageProductNotFound
            } :
            new() { Data = product };
    }

    public async Task<ServiceResponse<List<Product>>> GetProducts(CancellationToken cancellationToken) => 
        new()
        {
            Data = await _productExtensionRepository.GetProducts(cancellationToken)
        };

    public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl, CancellationToken cancellationToken) =>
        new()
        {
            Data = await _productExtensionRepository.GetProductsByCategory(categoryUrl, cancellationToken)
        };

    public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText, CancellationToken cancellationToken)
    {
        List<string> results = new();

        var productsSearch = await _productExtensionRepository.FindProductsBySearchText(searchText, cancellationToken);

        foreach (var product in productsSearch) 
        {
            if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(product.Title);
            }

            if (product.Description is not null)
            {
                AddDescriptionToResults(searchText, product.Description, results);
            }
        }

        return new() { Data = results };
    }

    public async Task<ServiceResponse<ProductSearchResultDto>> SearchProducts(string searchText, int page, CancellationToken cancellationToken)
    {
        var pageResults = 2f;
        var pageCount = Math.Ceiling((await _productExtensionRepository.FindProductsBySearchText(searchText, cancellationToken)).Count / pageResults);

        return new ServiceResponse<ProductSearchResultDto>
        {
            Data = new ProductSearchResultDto
            {
                Products = await _productExtensionRepository.FindProductsBySearchTextWithPage(searchText, pageResults, page, cancellationToken),
                CurrentPage = page,
                Pages = (int)pageCount
            }
        };
    }

    public async Task<ServiceResponse<List<Product>>> GetFeaturedProducts(CancellationToken cancellationToken) =>
        new()
        {
            Data = await _productExtensionRepository.GetFeaturedProducts(cancellationToken)
        };

    private static void AddDescriptionToResults(string searchText, string description, List<string> results)
    {
        var punctuation = description.Where(char.IsPunctuation)
            .Distinct()
            .ToArray();

        var words = description
            .Split()
            .Select(x => x.Trim(punctuation));

        foreach (var word in words)
        {
            if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase) &&
                !results.Contains(word))
            {
                results.Add(word);
            }
        }
    }
}
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class ProductList : IDisposable
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;

    public void Dispose() =>
        ProductService.ProductsChanged -= StateHasChanged;

    protected override void OnInitialized()
    {
        ProductService.ProductsChanged += StateHasChanged;
    }

    private static string GetPriceText(Product product)
    {
        var variants = product.ProductVariants;

        if (!variants.Any())
        {
            return string.Empty;
        }

        if (variants.Count == 1)
        {
            return $"${variants.First().Price}";
        }

        decimal minPrice = variants.Min(x => x.Price);
        return $"Starting at ${minPrice}";
    }
}
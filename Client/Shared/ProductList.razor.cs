using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class ProductList : IDisposable
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;

    [Inject]
    IConfigurationAppService ConfigurationAppService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        await ConfigurationAppService.ConfigurationAppIntialize();

        ProductService.ProductsChanged += StateHasChanged;
    }

    private static string GetPriceText(Product product)
    {
        if (!product.ProductVariants.Any())
        {
            return string.Empty;
        }

        return product.ProductVariants.Count switch
        {
            1 => $"${product.ProductVariants.First().Price}",
            _ => $"{MessagesClientSharedComponements.MessageStartAt}: {product.ProductVariants.Min(x => x.Price)}",
        };
    }

    public void Dispose() 
    {
        ProductService.ProductsChanged -= StateHasChanged;
    
        GC.SuppressFinalize(this);
    }
}
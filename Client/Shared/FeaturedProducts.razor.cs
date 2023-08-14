using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class FeaturedProducts : IDisposable
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;

    protected override void OnInitialized()
    {
        ProductService.ProductsChanged += StateHasChanged;
    }

    public void Dispose()
    {
        ProductService.ProductsChanged -= StateHasChanged;
    }
}
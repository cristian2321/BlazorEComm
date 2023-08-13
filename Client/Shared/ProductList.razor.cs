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
}
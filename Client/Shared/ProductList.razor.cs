using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class ProductList
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        await ProductService.GetProducts();   
    }
}
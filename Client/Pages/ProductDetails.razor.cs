using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class ProductDetails
{
    [Inject]
    public IProductService ProductService { get; set; } = default!;

    private Product? _product = default;
    private string message = default!;

    [Parameter]

    public Guid Id { get; set; } = default!;

    protected override async Task OnParametersSetAsync()
    {
        message = "Loading product ...";

        var result = await ProductService.GetProduct(Id);
        if (!result.Succes)
        {
            message = result.Message;
        }
        else
        {
            _product = result.Data;
        }
    }
}
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class ProductDetails
{
    [Inject]
    public IProductService ProductService { get; set; } = default!;

    private Product? _product = default;
    private string message = default!;
    private Guid _currentTypeId = default!;

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
            if (_product is not null && _product.Variants.Count > 0)
            {
                _currentTypeId = _product.Variants.First().ProductTypeId;
            }
        }
    }

    private ProductVariant? GetSectedVariants() =>
        _product is null ?
            default :
            _product.Variants.FirstOrDefault(x => x.ProductTypeId == _currentTypeId);

}
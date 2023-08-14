using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class ProductDetails
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;
    
    [Inject]
    private ICartService CartService { get; set; } = default!;


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
            if (_product is not null && _product.ProductVariants.Count > 0)
            {
                _currentTypeId = _product.ProductVariants.First().ProductTypeId;
            }
        }
    }

    private ProductVariant? GetSectedVariants() =>
        _product is null ?
            default :
            _product.ProductVariants.FirstOrDefault(x => x.ProductTypeId == _currentTypeId);

    private async Task AddToCart() 
    {
        var productVariant = GetSectedVariants();
        if (productVariant is not null)
        {
            var cartItem = new CartItem
            {
                ProductId = productVariant.ProductId,
                ProductTypeId = productVariant.ProductTypeId,
            };

            await CartService.AddToCard(cartItem);
        }
    }
}
using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared.Admin;

public partial class ProductVariantForm
{
    [Parameter, EditorRequired]
    public bool Add { get; set; }

    [Parameter] 
    public Guid ProductId { get; set; }

    [Parameter]
    public Guid ProductTypeId { get; set; }

    [Inject]
    private IProductVariantService ProductVariantService { get; set; } = default!;

    [Inject]
    private IProductService ProductService { get; set; } = default!;

    [Inject]
    private IProductTypeService ProductTypeService { get; set; } = default!;

    [Inject]
    public IRedirectService RedirectService { get; set; } = default!;

    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    private string? _submitText = string.Empty;
    private string _productSelect = string.Empty;
    private string _productTypeSelect = string.Empty;   

    private ProductVariantDto _productVariant = new();

    private List<string> _productTitles = new();
    private List<string> _productTypeNames = new();
    
    private const int IndexZero = 0;

    protected override async Task OnInitializedAsync()
    {
        _productTitles = await ProductService.GetProductTitles();
        _productTypeNames = await ProductTypeService.GetAdminProductTypeNames();
        if (Add)
        {
            _submitText = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.ProductVariantConfigurationType))!
                .Where(x => x.Key == ClientConstants.AddButtonTitle)
                .Select(x => x.Value)
                .FirstOrDefault();
        }
        else
        {
            _submitText = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.ProductVariantConfigurationType))!
                .Where(x => x.Key == ClientConstants.UpdateButtonTitle)
                .Select(x => x.Value)
                .FirstOrDefault();

            var productVariant = await ProductVariantService.GetAdminProductVariant(ProductId, ProductTypeId);
            if (productVariant is not null)
            {
                UpdateProductTitles(productVariant);

                UpdateProductTypeNames(productVariant);

                _productVariant = productVariant;
            }
        }
    }

    private void UpdateProductTitles(ProductVariantDto productVariant)
    {
        if (_productTitles.IndexOf(productVariant.Product) != -1)
        {
            _productTitles.Remove(productVariant.Product);
        }
        _productTitles.Insert(IndexZero, productVariant.Product);
    }

    private void UpdateProductTypeNames(ProductVariantDto productVariant)
    {
        if (_productTypeNames.IndexOf(productVariant.ProductType) != -1)
        {
            _productTypeNames.Remove(productVariant.ProductType);
        }
        _productTypeNames.Insert(IndexZero, productVariant.ProductType);
    }

    private async Task HandleAddOrUpdateProductVariant()
    {      
        if (Add)
        {
            SetSelectedProductTitle();

            SetSelectedProductTypeName();

            await ProductVariantService.AddProductVariant(_productVariant);
        }
        else
        {
            await ProductVariantService.UpdateProductVariant(_productVariant);
        }

        RedirectService.NavigateTo(ClientApiEndpoints.AdminProductVariantsUrl);
    }

    private void SetSelectedProductTitle()
    {
        if (string.IsNullOrWhiteSpace(_productSelect))
        {
            _productSelect = _productTitles.First();
        }
        _productVariant.Product = _productSelect;
    }

    private void SetSelectedProductTypeName()
    {
        if (string.IsNullOrWhiteSpace(_productTypeSelect))
        {
            _productTypeSelect = _productTypeNames.First();
        }

        _productVariant.ProductType = _productTypeSelect;
    }
}
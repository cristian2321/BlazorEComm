using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductVariants
{
    [Inject]
    IProductVariantService ProductVariantService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;
    
    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    private string? _titlePage = string.Empty;

    private List<ConfigurationDto>? _configurationsProductVariant = new();

    private List<ProductVariantDto> _productVariants = new();

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            await ProductVariantService.GetAdminProductVariants();
            _productVariants = ProductVariantService.AdminProductVariants;

            ProductVariantService.OnChange += StateHasChanged;

            await ConfigurationService.AddConfigurationsKeys(ClientConstants.ProductVariantConfigurationPageTitleKey);

            _configurationsProductVariant = await ConfigurationService.GetConfigurationsByKeysAndType
                (ClientConstants.ProductVariantConfigurationType);

            _titlePage = GetConfigurationValue(ClientConstants.ProductVariantConfigurationPageTitleKey);
        }
    }

    private void NavigateToAddProductVariant() =>
        RedirectService.NavigateTo(ClientApiEndpoints.AdminProductVariantAddUrl);

    private void NavigateToDeleteProductVariant(Guid productId, Guid productTypeId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminProductVariantDeleteUrl}/{productId}/{productTypeId}");

    private void NavigateToEditProductVariant(Guid productId, Guid productTypeId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminProductVariantUpdateUrl}/{productId}/{productTypeId}");

    public void Dispose() =>
        ProductVariantService.OnChange -= StateHasChanged;

    private string? GetConfigurationValue(string configurationKey) =>
        _configurationsProductVariant is null || !_configurationsProductVariant.Any() ?
            default :
            _configurationsProductVariant.Where(x => x.Key.ToLower() == configurationKey.ToLower())
                .Select(x => x.Value)
                .FirstOrDefault();
}
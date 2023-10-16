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

    private List<ProductVariantDto> _productVariants = new();

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            await ProductVariantService.GetAdminProductVariants();
            _productVariants = ProductVariantService.AdminProductVariants;

            ProductVariantService.OnChange += StateHasChanged;
        }
    }

    public void NavigateToAddProductVariant() =>
        RedirectService.NavigateTo(ClientApiEndpoints.AdminProductVariantAddUrl);

    public void NavigateToDeleteProductVariant(Guid productId, Guid productTypeId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminProductVariantDeleteUrl}/{productId}/{productTypeId}");

    public void NavigateToEditProductVariant(Guid productId, Guid productTypeId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminProductVariantUpdateUrl}/{productId}/{productTypeId}");

    public void Dispose() =>
        ProductVariantService.OnChange -= StateHasChanged;
}
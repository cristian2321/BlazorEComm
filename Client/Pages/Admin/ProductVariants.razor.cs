using BlazorEComm.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductVariants
{
    [Inject]
    IProductVariantService ProductVariantService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    private List<ProductVariantDto> _productVariants = new();

    protected override async Task OnInitializedAsync()
    {
        var authentificateRole = await AuthService.IsUserAuthenticatedWithRoleAdmin();
        if (authentificateRole)
        {
            await ProductVariantService.GetAdminProductVariants();
            _productVariants = ProductVariantService.AdminProductVariants;

            ProductVariantService.OnChange += StateHasChanged;
        }

        else
        {
            NavigationManager.NavigateTo(NavigationManager.BaseUri);
        }
    }

    public void NavigateToAddProductVariant() =>
        NavigationManager.NavigateTo(ClientApiEndpoints.AdminProductVariantAddUrl);

    public void NavigateToDeleteProductVariant(Guid productId, Guid productTypeId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AdminProductVariantDeleteUrl}/{productId}/{productTypeId}");

    public void NavigateToEditProductVariant(Guid productId, Guid productTypeId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AdminProductVariantUpdateUrl}/{productId}/{productTypeId}");

    public void Dispose() =>
        ProductVariantService.OnChange -= StateHasChanged;
}
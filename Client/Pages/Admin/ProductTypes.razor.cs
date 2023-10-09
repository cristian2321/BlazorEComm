using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductTypes: IDisposable
{
    [Inject]
    private IProductTypeService ProductTypeService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    private List<ProductType> _productTypes = new();

    protected override async Task OnInitializedAsync()
    {
        var authentificateRole = await AuthService.IsUserAuthenticatedWithRoleAdmin();
        if (authentificateRole)
        {
            await ProductTypeService.GetAdminProductTypes();

            _productTypes = ProductTypeService.AdminProductTypes;

            ProductTypeService.OnChange += StateHasChanged;
        }
        else
        {
            NavigationManager.NavigateTo(NavigationManager.BaseUri);
        }
    }

    public void NavigateToAddProductType() =>
        NavigationManager.NavigateTo(ClientApiEndpoints.AdminProductTypeAddUrl);
   
    public void NavigateToDeleteProductType(Guid productTypeId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AdminProductTypeDeleteUrl}/{productTypeId}");

    public void NavigateToEditProductType(Guid productTypeId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AdminProductTypeUpdateUrl}/{productTypeId}");

    public void Dispose() =>
        ProductTypeService.OnChange -= StateHasChanged;
}
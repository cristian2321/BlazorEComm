using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductTypes: IDisposable
{
    [Inject]
    private IProductTypeService ProductTypeService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    private List<ProductType> _productTypes = new();

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            await ProductTypeService.GetAdminProductTypes();

            _productTypes = ProductTypeService.AdminProductTypes;

            ProductTypeService.OnChange += StateHasChanged;
        }
    }

    public void NavigateToAddProductType() =>
        RedirectService.NavigateTo(ClientApiEndpoints.AdminProductTypeAddUrl);
   
    public void NavigateToDeleteProductType(Guid productTypeId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminProductTypeDeleteUrl}/{productTypeId}");

    public void NavigateToEditProductType(Guid productTypeId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminProductTypeUpdateUrl}/{productTypeId}");

    public void Dispose()
    {
        ProductTypeService.OnChange -= StateHasChanged;

        GC.SuppressFinalize(this);
    }
}
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductTypeDelete
{
    [Inject]
    private IProductTypeService ProductTypeService { get; set; } = default!;

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Parameter]
    public Guid ProductTypeId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authentificateRole = await AuthService.IsUserAuthenticatedWithRoleAdmin();
        if (!authentificateRole)
        {
            NavigationManager.NavigateTo(ClientApiEndpoints.BaseRegisterUrl);
        }

        var response = await ProductTypeService.DeleteProductType(ProductTypeId);
        if (response)
        {
            NavigationManager.NavigateTo(ClientApiEndpoints.AdminProductTypesUrl);
        }
    }
}
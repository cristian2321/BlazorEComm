using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductDelete
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Parameter]
    public Guid ProductId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authentificateRole = await AuthService.IsUserAuthenticatedWithRoleAdmin();
        if (!authentificateRole)
        {
            NavigationManager.NavigateTo(ClientApiEndpoints.BaseRegisterUrl);
        }

        var response = await ProductService.DeleteProduct(ProductId);
        if (response)
        {
            NavigationManager.NavigateTo(ClientApiEndpoints.AdminProductsUrl);
        }
    }
}
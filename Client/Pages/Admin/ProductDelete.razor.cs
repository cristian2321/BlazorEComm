using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductDelete
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    [Parameter]
    public Guid ProductId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            var response = await ProductService.DeleteProduct(ProductId);
            if (response)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.AdminProductsUrl);
            }
        }
    }
}
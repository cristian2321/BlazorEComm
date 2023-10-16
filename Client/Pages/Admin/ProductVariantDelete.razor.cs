using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductVariantDelete
{
    [Inject]
    private IProductVariantService ProductVariantService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;
  
    [Parameter]
    public Guid ProductId { get; set; }

    [Parameter]
    public Guid ProductTypeId { get; set; }
 
    private string _messageError = string.Empty;
   
    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            var response = await ProductVariantService.DeleteProductVariant(ProductId, ProductTypeId);
            if (response)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.AdminProductVariantsUrl);
            }
            else
            {
                _messageError = MessagesClientPages.MessageDeleteNotWork;
            }
        }
    }
}
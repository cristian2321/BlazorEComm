using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductTypeDelete
{ 
    [Inject]
    private IProductTypeService ProductTypeService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    [Parameter]
    public Guid ProductTypeId { get; set; }
    
    private string _messageError = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            var response = await ProductTypeService.DeleteProductType(ProductTypeId);
            if (response)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.AdminProductTypesUrl);
            }
            else
            {
                _messageError = MessagesClientPages.MessageDeleteNotWork;
            }
        }
    }
}
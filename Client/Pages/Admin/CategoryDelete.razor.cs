using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class CategoryDelete
{
    [Inject]
    private ICategoryService CategoryService { get; set; } = default !;
    
    [Inject]
    private IAdminService AdminService { get; set; } = default!;
    
    [Inject]
    private IRedirectService RedirectService { get; set; } = default !;
    
    [Parameter]
    public Guid CategoryId { get; set; }

    private string _messageError = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            var response = await CategoryService.DeleteCategory(CategoryId);
            if (response)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.AdminCategoriesUrl);
            }
            else
            {
                _messageError = MessagesClientPages.MessageDeleteNotWork;
            }
        } 
    }
}
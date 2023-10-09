using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class CategoryDelete
{
    [Inject]
    private ICategoryService CategoryService { get; set; } = default !;

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default !;
    
    [Parameter]
    public Guid CategoryId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authentificateRole = await AuthService.IsUserAuthenticatedWithRoleAdmin();
        if (!authentificateRole)
        {
            NavigationManager.NavigateTo(ClientApiEndpoints.BaseRegisterUrl);
        }

        var response = await CategoryService.DeleteCategory(CategoryId);
        if (response)
        {
            NavigationManager.NavigateTo(ClientApiEndpoints.AdminCategoriesUrl);
        }
    }
}
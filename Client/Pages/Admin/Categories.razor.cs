using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class Categories : IDisposable
{
    [Inject]
    private ICategoryService CategoryService { get; set; } = default!;
    
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;
    
    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        var authentificateRole = await AuthService.IsUserAuthenticatedWithRoleAdmin();
        if (authentificateRole)
        {
            await CategoryService.GetAdminCategories();

            CategoryService.OnChange += StateHasChanged;
        }
        else
        {
            NavigationManager.NavigateTo(NavigationManager.BaseUri);
        } 
    }

    public void NavigateToAddCategory() =>
        NavigationManager.NavigateTo(ClientApiEndpoints.AdminCategoryAddUrl);

    public void NavigateToDeleteCategory(Guid categoryId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AdminCategoryDeleteUrl}/{categoryId}");

    public void NavigateToEditCategory(Guid categoryId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AdminCategoryUpdateUrl}/{categoryId}");

    public void Dispose() => 
        CategoryService.OnChange -= StateHasChanged;
}
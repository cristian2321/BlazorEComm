using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class Categories : IDisposable
{
    [Inject]
    private ICategoryService CategoryService { get; set; } = default!;
    
    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            await CategoryService.GetAdminCategories();

            CategoryService.OnChange += StateHasChanged;
        }
    }

    public void NavigateToAddCategory() =>
        RedirectService.NavigateTo(ClientApiEndpoints.AdminCategoryAddUrl);

    public void NavigateToDeleteCategory(Guid categoryId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminCategoryDeleteUrl}/{categoryId}");

    public void NavigateToEditCategory(Guid categoryId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminCategoryUpdateUrl}/{categoryId}");

    public void Dispose()
    {
        CategoryService.OnChange -= StateHasChanged;
    
        GC.SuppressFinalize(this);
    }
}
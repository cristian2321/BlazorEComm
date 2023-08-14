using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class EcommNavMenu
{
    [Inject]
    public ICategoryService CategoryService { get; set; } = default!;

    private bool collapseNavMenu = true;
    
    private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected override async Task OnInitializedAsync()
    {
        await CategoryService.GetCategories();
    }
}
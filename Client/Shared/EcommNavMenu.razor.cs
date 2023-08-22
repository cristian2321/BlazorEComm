using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class EcommNavMenu
{
    [Inject]
    private ICategoryService CategoryService { get; set; } = default!;

    private bool _collapseNavMenu = true;

 
    private string? NavMenuCssClass => 
        _collapseNavMenu ? ClientCssConstants.Collaspe : null;

    private void ToggleNavMenu() =>
        _collapseNavMenu = !_collapseNavMenu;

    protected override async Task OnInitializedAsync() =>
        await CategoryService.GetCategories();
}
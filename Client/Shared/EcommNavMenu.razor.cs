using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class EcommNavMenu : IDisposable
{
    [Inject]
    private  ICategoryService CategoryService { get; set; } = default!;

    [Inject]
    private IConfigurationAppService ConfigurationAppService { get; set; } = default!;

    private bool _collapseNavMenu = true;
    private string? NavMenuCssClass => 
        _collapseNavMenu ? ClientCssConstants.Collaspe : null;

    private void ToggleNavMenu() =>
        _collapseNavMenu = !_collapseNavMenu;

    protected override async Task OnInitializedAsync()
    {
        await ConfigurationAppService.ConfigurationAppIntialize();

        await CategoryService.GetCategories();
        CategoryService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        CategoryService.OnChange -= StateHasChanged;

        GC.SuppressFinalize(this);
    }
}
using BlazorEComm.Shared.Dtos;
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

    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;
    
    private string? _titlePage = string.Empty;

    private List<ConfigurationDto>? _configurationsCategory = new();

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            await CategoryService.GetAdminCategories();

            CategoryService.OnChange += StateHasChanged;

            await ConfigurationService.AddConfigurationsKeys(ClientConstants.CategoryConfigurationPageTitleKey);
            
            _configurationsCategory = await ConfigurationService.GetConfigurationsByKeysAndType
                (ClientConstants.CategoryConfigurationType);

            _titlePage = GetConfigurationValue(ClientConstants.CategoryConfigurationPageTitleKey);
        }
    }

    private void NavigateToAddCategory() =>
        RedirectService.NavigateTo(ClientApiEndpoints.AdminCategoryAddUrl);

    private void NavigateToDeleteCategory(Guid categoryId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminCategoryDeleteUrl}/{categoryId}");

    private void NavigateToEditCategory(Guid categoryId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminCategoryUpdateUrl}/{categoryId}");

    private string? GetConfigurationValue(string configurationKey) => 
        _configurationsCategory is null || !_configurationsCategory.Any() ?
            default :
            _configurationsCategory.Where(x => x.Key.ToLower() == configurationKey.ToLower())
                .Select(x => x.Value)
                .FirstOrDefault();

    public void Dispose()
    {
        CategoryService.OnChange -= StateHasChanged;
    
        GC.SuppressFinalize(this);
    }
}
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

    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    [Parameter]
    public Guid CategoryId { get; set; }

    private string? _titlePage = string.Empty;

    private string? _messageError = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            await ConfigurationService.AddConfigurationsKeys(ClientConstants.CategoryDeleteConfigurationPageTitleKey);

            _titlePage = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.CategoryConfigurationType))!
                .Where(x => x.Key == ClientConstants.CategoryDeleteConfigurationPageTitleKey)
                .Select(x => x.Value)
                .FirstOrDefault();

            var response = await CategoryService.DeleteCategory(CategoryId);
            if (response)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.AdminCategoriesUrl);
            }
            else
            {
                _messageError = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.CategoryConfigurationType))!
                    .Where(x => x.Key == ClientConstants.CategoryDeleteConfigurationDeleteError)
                    .Select(x => x.Value)
                    .FirstOrDefault();
            }
        } 
    }
}
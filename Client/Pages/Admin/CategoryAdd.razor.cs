using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class CategoryAdd
{
    [Inject]
    private IAdminService AdminService { get; set; } = default!;
  
    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    private string? _titlePage = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        var isUserAdmin = await AdminService.IsUserWithAdminRole();
        if (isUserAdmin)
        {
            await ConfigurationService.AddConfigurationsKeys(ClientConstants.CategoryAddConfigurationPageTitleKey);

            _titlePage = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.CategoryConfigurationType))!
                .Where(x => x.Key == ClientConstants.CategoryAddConfigurationPageTitleKey)
                .Select(x => x.Value)
                .FirstOrDefault();
        }
    }
}
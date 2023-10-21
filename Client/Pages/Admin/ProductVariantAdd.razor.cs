using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductVariantAdd
{
    [Inject]
    private IAdminService AdminService { get; set; } = default !;

    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    private string? _titlePage = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        var isUserAdmin = await AdminService.IsUserWithAdminRole();
        if (isUserAdmin)
        {
            await ConfigurationService.AddConfigurationsKeys(ClientConstants.ProductVariantAddConfigurationPageTitleKey);

            _titlePage = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.ProductVariantConfigurationType))!
                .Where(x => x.Key == ClientConstants.ProductVariantAddConfigurationPageTitleKey)
                .Select(x => x.Value)
                .FirstOrDefault();
        } 
    }
}
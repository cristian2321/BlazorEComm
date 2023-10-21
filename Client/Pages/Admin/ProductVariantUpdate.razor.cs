using BlazorEComm.Client.Services.AdminService;
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductVariantUpdate
{
    [Parameter]
    public Guid ProductId { get; set; }

    [Parameter]
    public Guid ProductTypeId { get; set; }

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
            await ConfigurationService.AddConfigurationsKeys(ClientConstants.ProductVariantUpdateConfigurationPageTitleKey);

            _titlePage = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.ProductVariantConfigurationType))!
                .Where(x => x.Key == ClientConstants.ProductVariantUpdateConfigurationPageTitleKey)
                .Select(x => x.Value)
                .FirstOrDefault();
        }   
    }
}
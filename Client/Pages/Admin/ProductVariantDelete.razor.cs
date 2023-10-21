using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class ProductVariantDelete
{
    [Inject]
    private IProductVariantService ProductVariantService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    [Parameter]
    public Guid ProductId { get; set; }

    [Parameter]
    public Guid ProductTypeId { get; set; }

    private string? _titlePage = string.Empty;
    private string? _messageError = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            await ConfigurationService.AddConfigurationsKeys(ClientConstants.ProductVariantDeleteConfigurationPageTitleKey);

            _titlePage = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.ProductVariantConfigurationType))!
                .Where(x => x.Key == ClientConstants.ProductVariantDeleteConfigurationPageTitleKey)
                .Select(x => x.Value)
                .FirstOrDefault();

            var response = await ProductVariantService.DeleteProductVariant(ProductId, ProductTypeId);
            if (response)
            {
                RedirectService.NavigateTo(ClientApiEndpoints.AdminProductVariantsUrl);
            }
            else
            {
                _messageError = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.ProductVariantConfigurationType))!
                    .Where(x => x.Key == ClientConstants.ProductVariantDeleteConfigurationDeleteError)
                    .Select(x => x.Value)
                    .FirstOrDefault();
            }
        }
    }
}
using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class FeaturedProducts : IDisposable
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;
    
    [Inject]
    private IConfigurationAppService ConfigurationAppService { get; set; } = default!;

    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    private string _title = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        ProductService.ProductsChanged += StateHasChanged;

        await ConfigurationAppService.ConfigurationAppIntialize();

        _title = await ConfigurationService.GetConfigurationValue(ClientConstants.TitleFeaturedProducts) ?? string.Empty; 
    }

    public void Dispose()
    {
        ProductService.ProductsChanged -= StateHasChanged;

        GC.SuppressFinalize(this);
    }
}
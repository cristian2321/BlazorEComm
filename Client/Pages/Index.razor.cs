using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Index
{  
    [Inject]
    IProductService ProductService { get; set; } = default!;

    [Inject]
    IConfigurationService ConfigurationService { get; set; } = default!;

    [Inject]
    IConfigurationAppService ConfigurationAppService { get; set; } = default!;

    [Parameter]
    public string? SearchText { get; set; } = null;

    [Parameter]
    public string? CategoryUrl { get; set; } = null;

    [Parameter]
    public int Page { get; set; } = ClientConstants.DefaultPage;
    
    private string _companyName = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        await ConfigurationAppService.ConfigurationAppIntialize();

        _companyName = await ConfigurationService.GetConfigurationValue(ClientConstants.CompanyName) ?? ClientConstants.DefaultCompanyName;
    }

    protected async override Task OnParametersSetAsync()
    {
        switch (SearchText)
        {
            case not null:
                await ProductService.SearchProducts(SearchText, Page);
                break;
            default:
                await ProductService.GetProducts(CategoryUrl);
                break;
        }
    }
}
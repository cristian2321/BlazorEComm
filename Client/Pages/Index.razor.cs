using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages;

public partial class Index
{       
    [Inject]
    IProductService ProductService { get; set; } = default!;

    [Parameter]
    public string? SearchText { get; set; } = null;

    [Parameter]
    public string? CategoryUrl { get; set; } = null;

    [Parameter]
    public int Page { get; set; } = ClientConstants.DefaultPage;
   
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
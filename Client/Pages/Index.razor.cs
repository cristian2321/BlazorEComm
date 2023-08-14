using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages
{
    public partial class Index
    {
        [Inject]
        IProductService ProductService { get; set; } = default!;

        [Parameter]
        public string? SearchText { get; set; } = null;

        [Parameter]
        public string? CategoryUrl { get; set; } = null;

        [Parameter]
        public int Page { get; set; } = 1;

        protected async override Task OnParametersSetAsync()
        {
            if (SearchText is not null)
            {
                await ProductService.SearchProducts(SearchText, Page);
            }
            else
            {
                await ProductService.GetProducts(CategoryUrl);
            }
        }
    }
}
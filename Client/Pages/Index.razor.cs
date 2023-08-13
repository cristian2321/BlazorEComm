using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages
{
    public partial class Index
    {
        [Inject]
        IProductService ProductService { get; set; } = default!;
       
        [Parameter]
        public string? CategoryUrl { get; set; } = null;

        protected async override Task OnParametersSetAsync()
        {
            await ProductService.GetProducts(CategoryUrl);
        }
    }
}
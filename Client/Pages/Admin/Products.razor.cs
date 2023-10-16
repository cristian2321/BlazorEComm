using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class Products : IDisposable
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;
  
    [Inject]
    private IRedirectService RedirectService { get; set; } = default!;

    [Inject]
    private IAdminService AdminService { get; set; } = default!;

    private const int DefaultPage = 0;

    private int _productsCount;
    
    protected override async Task OnInitializedAsync()
    {
        if (await AdminService.IsUserWithAdminRole())
        {
            ProductService.PageProductsAdmin = DefaultPage;

            await GetProducts();

            _productsCount = ProductService.AdminProducts.Count;
        }
    }

    public void NavigateToAddProduct() =>
        RedirectService.NavigateTo(ClientApiEndpoints.AdminProductAddUrl);

    public void NavigateToDeleteProduct(Guid productId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminProductDeleteUrl}/{productId}");

    public void NavigateToEditProduct(Guid productId) =>
        RedirectService.NavigateTo($"{ClientApiEndpoints.AdminProductUpdateUrl}/{productId}");

    public void Dispose() 
    {
        ProductService.ProductsChanged -= StateHasChanged;
        
        GC.SuppressFinalize(this);
    }

    private async Task GetProducts()
    {
        await ProductService.GetAdminProducts();

        ProductService.ProductsChanged += StateHasChanged;
    }

    public async Task GoToPreviousPage()
    {
        ProductService.PageProductsAdmin = GetPreviousPage();

        await GetProducts();
    }

    public async Task GoToNextPage()
    {
        ProductService.PageProductsAdmin = GetNextPage();

        await GetProducts();
    }

    private int GetPreviousPage() =>
        ProductService.PageProductsAdmin - 1;

    private int GetPreviousBoutonPage() =>
        GetPreviousPage() + 1;

    private int GetNextPage() =>
      ProductService.PageProductsAdmin + 1;

    private int GetNextBoutonPage() =>
        GetNextPage() + 1;
}
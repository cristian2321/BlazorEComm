using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Pages.Admin;

public partial class Products : IDisposable
{
    [Inject]
    private IProductService ProductService { get; set; } = default!;
  
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private IAuthService AuthService { get; set; } = default!;

    private const int DefaultPage = 0;

    private int _productsCount;
    
    protected override async Task OnInitializedAsync()
    {
        var authentificateRole = await AuthService.IsUserAuthenticatedWithRoleAdmin();
        if (authentificateRole)
        {
            ProductService.PageProductsAdmin = DefaultPage;

            await GetProducts();

            _productsCount = ProductService.AdminProducts.Count;
        }
        else
        {
            NavigationManager.NavigateTo(NavigationManager.BaseUri);
        }
    }

    public void NavigateToAddProduct() =>
        NavigationManager.NavigateTo(ClientApiEndpoints.AdminProductAddUrl);

    public void NavigateToDeleteProduct(Guid productId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AdminProductDeleteUrl}/{productId}");

    public void NavigateToEditProduct(Guid productId) =>
        NavigationManager.NavigateTo($"{ClientApiEndpoints.AdminProductUpdateUrl}/{productId}");

    public void Dispose() =>
        ProductService.ProductsChanged -= StateHasChanged;

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
using BlazorEComm.Shared.Dtos;
using BlazorEComm.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;

namespace BlazorEComm.Client.Shared.Admin;

public partial class ProductForm
{ 
    [Inject]
    public IProductService ProductService { get; set; } = default!;

    [Inject]
    public ICategoryService CategoryService { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [Parameter, EditorRequired]
    public bool Add { get; set; }

    [Parameter]
    public Guid ProductId { get; set; } = default!;

    private string _submitText = string.Empty;
    private string _categoryNameSelect = string.Empty;
    private List<string> _categoriesNames = new ();
    private ProductDto _product = new();

    private const int IndexZero = 0;

    protected override async Task OnInitializedAsync()
    {
        _categoriesNames = await CategoryService.GetAdminCategoriesName();
      
        if (Add)
        {
            _submitText = MessagesClientSharedComponements.AddProductSubmit;
        }
        else
        {
            _submitText = MessagesClientSharedComponements.UpdateProductSubmit;

            var product = await ProductService.GetAdminProduct(ProductId);
            if (product is not null)
            { 
                UpdateCategoryNames(product.Category!.Name);
                
                _product = product.GetProductDtoFromProduct();
            }
        }
    }

    private void UpdateCategoryNames(string categoryName)
    {
        if (_categoriesNames.IndexOf(categoryName) != -1)
        {
            _categoriesNames.Remove(categoryName);
        }

        _categoriesNames.Insert(IndexZero, categoryName);
    }

    private async Task HandleAddOrUpdateProduct()
    {
        if (Add)
        {
            SetSelectedCategoryName();

            await ProductService.AddProduct(_product!);
        }
        else
        { 
            await ProductService.UpdateProduct(_product!);
        }

        NavigationManager.NavigateTo(ClientApiEndpoints.AdminProductsUrl);
    }

    private void SetSelectedCategoryName()
    {
        if (string.IsNullOrWhiteSpace(_categoryNameSelect))
        {
            _categoryNameSelect = _categoriesNames.First();    
        }

        _product.CategoryName = _categoryNameSelect;
    }

    private async Task OnFileChange(InputFileChangeEventArgs e) 
    {
        var format = "image/png";
        foreach (var image in e.GetMultipleFiles(int.MaxValue))
        {
            var resizedImage = await image.RequestImageFileAsync(format, 200, 200);
            var buffer = new byte[resizedImage.Size];
            await resizedImage.OpenReadStream().ReadAsync(buffer);
            var imageData = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
            
            _product.Images.Add(new Image { Data = imageData });
        }
    }

    void RemoveImage(Guid idImage) 
    {
        var image = _product.Images.FirstOrDefault(x => x.Id == idImage); ;
        if (image is not null)
        {
            _product.Images.Remove(image);
        }
    }
}
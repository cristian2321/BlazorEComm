using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared.Admin;

public partial class ProductTypeForm
{
    [Inject]
    public IProductTypeService ProductTypeService { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [Parameter, EditorRequired]
    public bool Add { get; set; }

    [Parameter]
    public Guid ProductTypeId { get; set; } = default!;

    private string _submitText = string.Empty;
    private ProductType _productType = new();

    protected override async Task OnInitializedAsync()
    {
        if (Add)
        {
            _submitText = MessagesClientSharedComponements.AddProductTypeSubmit;
        }
        else
        {
            _submitText = MessagesClientSharedComponements.UpdateProductTypeSubmit;

            var productType = await ProductTypeService.GetAdminProductType(ProductTypeId);
            if (productType is not null)
            {
                _productType = productType;
            }
        }
    }


    private async Task HandleAddOrUpdateProductType()
    {
        if (Add)
        {
            await ProductTypeService.AddProductType(_productType!);
        }
        else
        {
            await ProductTypeService.UpdateProductType(_productType!);
        }

        NavigationManager.NavigateTo(ClientApiEndpoints.AdminProductTypesUrl);
    }
}
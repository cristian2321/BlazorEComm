using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared.Admin;

public partial class CategoryForm
{
    [Inject]
    public ICategoryService CategoryService { get; set; } = default!;

    [Inject]
    public IRedirectService RedirectService { get; set; } = default!;

    [Parameter, EditorRequired]
    public bool Add { get; set; }

    [Parameter]
    public Guid CategoryId { get; set; } = default!;
 
    private string _submitText = string.Empty;
    private Category _category = new();

    protected override async Task OnInitializedAsync()
    {
        if (Add)
        {
            _submitText = MessagesClientSharedComponements.AddCategorySubmit;
        }
        else
        {
            _submitText = MessagesClientSharedComponements.UpdateCategorySubmit;

            var category = await CategoryService.GetAdminCategory(CategoryId);
            if (category is not null) 
            {
                _category = category;
            }
        }
    }

    private async Task HandleAddOrUpdateCategory()
    {
        if (Add)
        {
            await CategoryService.AddCategory(_category!);
        }
        else
        {
            await CategoryService.UpdateCategory(_category!);
        }

        RedirectService.NavigateTo(ClientApiEndpoints.AdminCategoriesUrl);
    }
}
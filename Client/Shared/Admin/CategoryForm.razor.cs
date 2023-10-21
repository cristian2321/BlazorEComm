using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared.Admin;

public partial class CategoryForm
{
    [Inject]
    public ICategoryService CategoryService { get; set; } = default!;

    [Inject]
    public IRedirectService RedirectService { get; set; } = default!;

    [Inject]
    private IConfigurationService ConfigurationService { get; set; } = default!;

    [Parameter, EditorRequired]
    public bool Add { get; set; }

    [Parameter]
    public Guid CategoryId { get; set; } = default!;
 
    private string? _submitText = string.Empty;
    private Category _category = new();

    protected override async Task OnInitializedAsync()
    {
        if (Add)
        {
            _submitText = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.CategoryConfigurationType))!
                .Where(x => x.Key == ClientConstants.AddButtonTitle)
                .Select(x => x.Value)
                .FirstOrDefault();
        }
        else
        {
            _submitText = (await ConfigurationService.GetConfigurationsByKeysAndType(ClientConstants.CategoryConfigurationType))!
                       .Where(x => x.Key == ClientConstants.UpdateButtonTitle)
                       .Select(x => x.Value)
                       .FirstOrDefault();

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
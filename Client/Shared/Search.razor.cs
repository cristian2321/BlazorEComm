using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorEComm.Client.Shared;

public partial class Search
{
    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    public IProductService ProductService { get; set; } = default!;

    private string _searchText = string.Empty;
    private List<string> _suggestions = new ();
    protected ElementReference _searchInput;

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await _searchInput.FocusAsync();
        }
    }

    public void SearchProducts() 
    {
        NavigationManager.NavigateTo($"search/{_searchText}/1");
    }

    public async Task HandleSearch(KeyboardEventArgs args) 
    {
        if (args.Key is null || args.Key.Equals("Enter")) 
        {
            SearchProducts();
        }
        else if (_searchText.Length > 1)
        {
            _suggestions = await ProductService.GetProductsSearchSuggestions(_searchText);
        }
    }
}
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorEComm.Client.Shared;

public partial class Search
{
    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    [Inject]
    private IProductService ProductService { get; set; } = default!;

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
        string uri = $"{ClientApiEndpoints.BaseSearchUrl}/{_searchText}/{ClientConstants.DefaultPage}";
        NavigationManager.NavigateTo(uri);
    }

    public async Task HandleSearch(KeyboardEventArgs args) 
    {
        switch (args.Key)
        {
            case not null when !args.Key.Equals(MessagesClientSharedComponements.EnterValue):
                if (_searchText.Length > 1)
                {
                    _suggestions = await ProductService.GetProductsSearchSuggestions(_searchText);
                }
                break;
            default:
                SearchProducts();
                break;
        }
    }
}
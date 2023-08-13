using BlazorEComm.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorEComm.Client.Shared;

public partial class ProductList
{
    [Inject]
    private HttpClient HttpClient { get; set; } = default!;

    private List<Product> _products = new();

    protected override async Task OnInitializedAsync()
    {
        var result = await HttpClient.GetFromJsonAsync<List<Product>>("api/product");
        if (result is not null) 
        {
            _products = result; 
        }
    }
}
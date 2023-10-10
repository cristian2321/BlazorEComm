using Microsoft.AspNetCore.Components;

namespace BlazorEComm.Client.Shared;

public partial class ProductImages
{
    [Parameter, EditorRequired]
    public Guid ProductId { get; set; }

    [Parameter, EditorRequired]
    public string Title { get; set; } = string.Empty;

    [Parameter, EditorRequired]
    public int ImageCount { get; set; }

    [Parameter]
    public string Data { get; set; } = string.Empty;

    [Parameter]
    public string ImageUrl { get; set; } = string.Empty;
}
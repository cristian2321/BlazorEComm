namespace BlazorEComm.Shared.Models;

public class Category
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;
}
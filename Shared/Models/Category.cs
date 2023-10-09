namespace BlazorEComm.Shared.Models;

public class Category: Entity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public bool Visible { get; set; } = true;

    public bool Deleted { get; set; } = false;
}
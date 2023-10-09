namespace BlazorEComm.Shared.Models;

public class ProductType : Entity
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;

    public bool Visible { get; set; } = true;

    public bool Deleted { get; set; } = false;
}
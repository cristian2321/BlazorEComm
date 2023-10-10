using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEComm.Shared.Models;

public class Product: Entity
{
    public Guid Id { get; set; }
   
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public List<Image> Images { get; set; } = new List<Image>();

    public bool Featured { get; set; } = false;
    
    public bool Visible { get; set; } = true;

    public bool Deleted { get; set; } = false;

    public Guid CategoryId { get; set; }
   
    [ForeignKey(nameof(CategoryId))]
    public Category? Category { get; set; }

    public List<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
}
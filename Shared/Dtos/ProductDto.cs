using BlazorEComm.Shared.Models;

namespace BlazorEComm.Shared.Dtos;

public class ProductDto
{
    public Guid Id { get; set; }

    public string Title{ get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    
    public string ImageUrl { get; set; } = string.Empty;

    public string CategoryName { get; set; } = string.Empty;

    public bool Featured { get; set; } = false;

    public bool Visible { get; set; } = true;

    public bool Deleted { get; set; } = false;

    public List<Image> Images { get; set; } = new List<Image>();
}

public static class ProductExtension
{
    public static Product GetProductFromProductDto(this ProductDto product) =>
        new()
        {
            Deleted = product.Deleted,
            Visible = product.Visible,
            Title = product.Title,
            ImageUrl = product.ImageUrl,
            Featured = product.Featured,
            Description = product.Description,
            Id = product.Id,
            Images = product.Images
        };

    public static ProductDto GetProductDtoFromProduct(this Product product) =>
        new()
        {
            Deleted = product.Deleted,
            Visible = product.Visible,
            Title = product.Title,
            ImageUrl = product.ImageUrl,
            Featured = product.Featured,
            Description = product.Description,
            Id = product.Id,
            CategoryName = product.Category!.Name,
            Images = product.Images
        };
}
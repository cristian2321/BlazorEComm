namespace BlazorEComm.Shared.Dtos;

public class CartProductDto
{
    public Guid ProductId { get; set; }
    
    public Guid ProductTypeId { get; set; }

    public string Title { get; set; } = default!;

    public string ProductType { get; set; } = default!;

    public string ImageUrl { get; set; } = default!;

    public decimal Price { get; set; }
}

namespace BlazorEComm.Shared.Dtos;

public class ProductTypeCartDto
{
    public Guid ProductTypeId { get; set; }

    public decimal Price { get; set; }

    public string ProductTypeName { get; set; } = string.Empty;
}
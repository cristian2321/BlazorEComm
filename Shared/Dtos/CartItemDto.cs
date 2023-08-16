namespace BlazorEComm.Shared.Dtos;

public class CartItemDto
{
    public Guid ProductId { get; set; }

    public Guid ProductTypeId { get; set; }

    public int Quantity { get; set; } = 1;
}
namespace BlazorEComm.Shared.Dtos;

public class ProductCartDto
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;
}
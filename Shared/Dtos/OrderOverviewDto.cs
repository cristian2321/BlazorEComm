namespace BlazorEComm.Shared.Dtos;

public class OrderOverviewDto
{
    public Guid Id { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal TotalPrice { get; set; }

    public string ProductName { get; set; } = string.Empty;

    public string ProductImageUrl { get; set; } = string.Empty;

    public bool IsPayment { get; set; } = false;
}
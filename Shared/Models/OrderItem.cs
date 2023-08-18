using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEComm.Shared.Models;

public class OrderItem
{
    public Order Order { get; set; } = default!;

    public Guid OrderId { get; set; }

    public Product Product { get; set; } = default!;

    public Guid ProductId { get; set; }

    public ProductType ProductType { get; set; } = default!;

    public Guid ProductTypeId { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalPrice { get; set; }
}
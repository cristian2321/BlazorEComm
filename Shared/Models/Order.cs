using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorEComm.Shared.Models;

public class Order
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.Now;

    public bool IsPayment { get; set; } = false;

    [Column(TypeName = "decimal(18,2)")]
    public decimal TotalPrice { get; set; }

    public List<OrderItem> OrderItems { get; set; } = new();
}
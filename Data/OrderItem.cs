using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiStoreApi.Data;

public class OrderItem
{
    [Key] [Column(Order = 0)] public int Id { get; set; }
    [Key] [Column(Order = 1)] public Guid OrderItemId { get; set; } = Guid.NewGuid();
    [ForeignKey("Order")]
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }
    [ForeignKey("Product")]
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
}
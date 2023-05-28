using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiStoreApi.Data;

public class Stock:Base
{
    [Key] [Column(Order = 0)] public int Id { get; set; }
    [Key] [Column(Order = 1)] public Guid StockId { get; set; } = Guid.NewGuid();
    public string? Vendor { get; set; }
    public int StockQuantity { get; set; }
    [ForeignKey("Product")]
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
}
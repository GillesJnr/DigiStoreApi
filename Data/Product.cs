using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiStoreApi.Data;

public class Product:Base
{
    [Key]  [Column(Order = 0)] public int Id { get; set; }
    [Key] [Column(Order = 1)] public Guid ProductId { get; set; } = Guid.NewGuid();
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Brand { get; set; }
    public int CurrentQuantity { get; set; }
    public int SafetyStock { get; set; }
    [Required]
    public int ActualStock { get; set; }
    [Required]
    public int OrderQuantity { get; set; }
    [ForeignKey("Category")]
    [Required]
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    [ForeignKey("Unit")]
    [Required]
    public int UnitId { get; set; }
    public Unit? Unit { get; set; }
    [ForeignKey("ReorderLevel")]
    [Required]
    public int LevelId { get; set; }
    public ReorderLevel? Level { get; set; }
    public Guid BulkId { get; set; }
    
}
using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Data;

public class Category:Base
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Product>? Products { get; set; }
}
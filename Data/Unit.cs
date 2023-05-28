using System.ComponentModel.DataAnnotations.Schema;

namespace DigiStoreApi.Data;
[Table("Unit")]
public class Unit : Base
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Product>? Products { get; set; }
}
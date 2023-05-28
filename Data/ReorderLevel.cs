using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Data;

public class ReorderLevel : Base
{
    [Key]
    public int Id { get; set; }
    public string? Level { get; set; }
}
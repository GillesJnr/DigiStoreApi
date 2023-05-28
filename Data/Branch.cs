using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Data;

public class Branch: Base
{
    public int Id { get; set; }
    public string? BranchName { get; set; }
    [Key]
    [MaxLength(3)]
    public string? BranchCode { get; set; }
    public string? Location { get; set; }
}
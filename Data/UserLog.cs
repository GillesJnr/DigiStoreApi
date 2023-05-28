using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Data;

public class UserLog
{
    [Key]
    public int Id { get; set; }
    public string? Function { get; set; }
    public string? Request { get; set; }
    public string? Response { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
}
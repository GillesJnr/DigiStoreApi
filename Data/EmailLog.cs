using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Data;

public class EmailLog
{
    [Key]
    public int Id { get; set; }
    public string? Request { get; set; }
    public bool Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime Date { get; set; }
}
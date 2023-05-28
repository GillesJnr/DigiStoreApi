using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Data;

public class History
{
    [Key]
    public int Id { get; set; }
    public int LogId { get; set; }
    public string? Table { get; set; }
    public string? PreviousData { get; set; }
    public string? EditedData { get; set; }
    public string? CreatedBy { get; set; }
    public string? CreatedDate { get; set; }
}
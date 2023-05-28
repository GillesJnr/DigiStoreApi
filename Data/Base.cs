using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Data;

public class Base
{
    [Required]
    public int Status { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? AuthorizedBy { get; set; }
    public DateTime AuthorizedDate { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
}
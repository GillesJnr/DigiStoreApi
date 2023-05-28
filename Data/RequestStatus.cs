using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Data;

public class RequestStatus
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    
}
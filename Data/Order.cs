using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace DigiStoreApi.Data;

public class Order:Base
{
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key] [Column(Order = 0)] public int Id { get; set; }
    [Key] [Column(Order = 1)] public Guid OrderId { get; set; } = Guid.NewGuid();
    public string? RequestorEmail { get; set; }
    public string? RequestFrom { get; set; }
    public string? HeadAuthorizerEmail { get; set; }
    [ForeignKey("Branch")]
    public string BranchCode { get; set; }
    public Branch? Branch { get; set; }
    public List<OrderItem>? OrderItems { get; set; }
}
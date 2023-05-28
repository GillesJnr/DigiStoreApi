using System.Security.Cryptography.Xml;
using DigiStoreApi.Data;
using DigiStoreApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DigiStoreApi.Core;

public class ApiDbContext : DbContext
{
    public DbSet<Unit>? Unit { get; set; }
    public DbSet<Branch>? Branch { get; set; }
    public DbSet<Category>? Category { get; set; }
    public DbSet<History>? History { get; set; }
    public DbSet<Product>? Product { get; set; }
    public DbSet<Order>? Order { get; set; }
    public DbSet<Stock>? Stock { get; set; }
    public DbSet<OrderItem>? OrderItem { get; set; }
    public DbSet<ReorderLevel>? ReorderLevel { get; set; }
    // public DbSet<RequestStatus>? RequestStatus { get; set; }
    public DbSet<UserLog>? UserLog { get; set; }
    public DbSet<EmailLog>? EmailLog { get; set; }

    public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<History>().HasIndex("CreatedBy");
        modelBuilder.Entity<UserLog>().HasIndex("CreatedBy");
        modelBuilder.Entity<Product>(b =>
        {
            b.HasIndex(x => x.CreatedBy);
            b.HasIndex(x => x.ModifiedBy);
            b.HasIndex(x => x.AuthorizedBy);
            b.HasIndex(x => x.Brand);
            b.HasIndex(x => x.Name);
            b.HasIndex(x => x.BulkId);
        });
        modelBuilder.Entity<OrderItem>(x =>
        {
            x.HasIndex(z => z.ProductId);
            x.HasIndex(z => z.OrderId);
        });
        modelBuilder.Entity<Order>(x =>
        {
            x.HasIndex(z => z.CreatedBy);
            x.HasIndex(z => z.AuthorizedBy);
            x.HasIndex(z => z.ModifiedBy);
            x.HasIndex(z => z.HeadAuthorizerEmail);
            x.HasIndex(z => z.RequestorEmail);
            x.HasIndex(z => z.BranchCode);
        });
    } 
    
    
}
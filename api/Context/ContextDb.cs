using Microsoft.EntityFrameworkCore;

namespace api;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options)
        : base(options)
    {

    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<ProductItem> ProductItems { get; set; }
    public DbSet<OrderMaster> OrderMasters { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
}
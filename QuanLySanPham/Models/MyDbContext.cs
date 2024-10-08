using Microsoft.EntityFrameworkCore;

namespace QuanLySanPham.Models;

public class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Catalog> Catalogs { get; set; }
}
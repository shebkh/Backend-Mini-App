using Backend_Mini_App.Models;
using Microsoft.EntityFrameworkCore;

public class BackendMiniAppDbContext : DbContext
{
    public DbSet<Slider> Sliders { get; set; }
    public BackendMiniAppDbContext(DbContextOptions<BackendMiniAppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
}
using Microsoft.EntityFrameworkCore;

namespace Food.Models
{
  public class FoodContext : DbContext
  {
    public DbSet<Cusisine> Cusisine { get; set; }
    public DbSet<Resturant> Resturant { get; set; }

    public FoodContext(DbContextOptions options) : base(options) { }
  }
}
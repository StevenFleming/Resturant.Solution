using Microsoft.EntityFrameworkCore;

namespace NonProfitTracker.Models
{
  public class FoodContext : DbContext
  {
    public DbSet<Cusisine> Cusisine { get; set; }
    public DbSet<Bo> Resturant { get; set; }

    public NonProfitTrackerContext(DbContextOptions options) : base(options) { }
  }
}
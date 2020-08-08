using Microsoft.EntityFrameworkCore;

namespace alibaba.Models
{
  public class AlibabaContext : DbContext
  {
    public AlibabaContext(DbContextOptions<AlibabaContext> options)
            : base(options)
    {
    }

    public DbSet<User> User { get; set; }

    public DbSet<Hotel> Hotel { get; set; }

    public DbSet<Room> Room { get; set; }

    public DbSet<Feature> Feature { get; set; }

    public DbSet<Pic> Pic { get; set; }

    public DbSet<Reserve> Reserve { get; set; }
  }
}

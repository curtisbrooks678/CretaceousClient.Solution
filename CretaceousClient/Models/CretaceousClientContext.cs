using Microsoft.EntityFrameworkCore;

namespace CretaceousClient.Models
{
  public class CretaceousClientContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public CretaceousClientContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
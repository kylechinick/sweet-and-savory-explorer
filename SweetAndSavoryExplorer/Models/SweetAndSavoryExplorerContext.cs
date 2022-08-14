using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetAndSavoryExplorer.Models
{
  public class SweetAndSavoryExplorerContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public SweetAndSavoryExplorerContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
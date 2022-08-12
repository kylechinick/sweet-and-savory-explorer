using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SweetAndSavoryExplorer.Models
{
  public class SweetAndSavoryExplorerContextFactory : IDesignTimeDbContextFactory<SweetAndSavoryExplorerContext>
  {

    SweetAndSavoryExplorerContext IDesignTimeDbContextFactory<SweetAndSavoryExplorerContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SweetAndSavoryExplorerContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new SweetAndSavoryExplorerContext(builder.Options);
    }
  }
}
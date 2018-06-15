using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    // public class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<ProjetoModeloContext>
    // {
    //     public ProjetoModeloContext CreateDbContext(string[] args)
    //     {
    //         IConfigurationRoot configuration = new ConfigurationBuilder()
    //             .SetBasePath(Directory.GetCurrentDirectory())
    //             .AddJsonFile("appsettings.json")
    //             .Build();
    //         var builder = new DbContextOptionsBuilder<ProjetoModeloContext>();
    //         var connectionString = configuration.GetConnectionString("DefaultConnection");
    //         builder.UseSqlServer(connectionString);
    //         return new ProjetoModeloContext(builder.Options);
    //     }
    // }
}
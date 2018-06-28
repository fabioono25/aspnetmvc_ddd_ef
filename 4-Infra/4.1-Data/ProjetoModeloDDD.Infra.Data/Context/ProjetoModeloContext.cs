using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext(){}
        
        public ProjetoModeloContext(DbContextOptions<ProjetoModeloContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Produto> Produtos {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //modelBuilder.ApplyConfiguration()

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            //  Configuration.ValidateOnSaveEnabled = false;
            //  Configuration.LazyLoadingEnabled = true;

            modelBuilder.Entity<Produto>()
                .HasOne(c => c.Cliente)
                .WithMany(p => p.Produtos)
                .HasForeignKey(p => p.ClienteId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
                

            // base.OnConfiguring(optionsBuilder);
            // var builder = new ConfigurationBuilder().AddConfiguration()
            //     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            // IConfigurationRoot config = builder.Build();
            // optionsBuilder.UseSqlServer(config.GetConnectionString("LibraryDemo1"));
        }

        // public override int SaveChanges(){
            
        //     foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("DataCadastro") != null))
        //     {
        //         if (entry.State == EntityState.Added)
        //             entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                
        //         if (entry.State == EntityState.Modified)
        //             entry.Property("DataCadastro").IsModified = false;
        //     }

        //     return 1;
        // }
    }
}
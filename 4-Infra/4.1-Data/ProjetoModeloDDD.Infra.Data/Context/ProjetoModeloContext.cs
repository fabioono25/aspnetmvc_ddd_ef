using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext(DbContextOptions<ProjetoModeloContext> options) : base(options)
        {
        }

        DbSet<Cliente> Clientes {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //modelBuilder.ApplyConfiguration()

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
        }

        // protected override void SaveChanges(){
            
        // }
    }
}
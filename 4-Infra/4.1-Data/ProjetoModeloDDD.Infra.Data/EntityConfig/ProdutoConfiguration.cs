using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(p => p.Valor)
                .IsRequired();
        }
    }
}
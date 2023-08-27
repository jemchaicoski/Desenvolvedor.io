using EfCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
                builder.ToTable("Pedidos");
                builder.HasKey(p => p.Id);
                builder.Property(p => p.IniciadoEm).HasColumnType("GETDATE()").ValueGeneratedOnAdd();
                builder.Property(p => p.Status).HasConversion<string>();
                builder.Property(p => p.TipoFrete).HasConversion<string>();

                builder.HasMany(p => p.Itens)
                    .WithOne(p => p.Pedido)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
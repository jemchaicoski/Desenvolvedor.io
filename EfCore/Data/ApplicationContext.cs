using EfCore.Data.Configurations;
using EfCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Data 
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedidos {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=CursoEfCore; Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //o codigo acomentado abaixo busca por entidades a serem mapeadas altomaticamente, desde que implementaram o IEntityTipeConfiguration
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly); 
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoItemConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        }
    }

}
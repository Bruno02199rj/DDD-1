using ECommerce.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;





namespace ECommerce.Infraestrutura.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplicar configurações Fluent API se houver
            //modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        }
    }
}

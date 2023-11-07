using DETALLE_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace DETALLE_CRUD.Data
{

    public class Startup
    {
    public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<ApplicationDbContext>();
    }
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Producto> Productos { get; set; } = null!;
        public DbSet<Pedido> Pedidos { get; set; } = null!;
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pedido>()
            .HasMany(p=>p.Detalles)
            .WithOne(d=>d.Pedido)
            .HasForeignKey(d=>d.PedidoId)
            .OnDelete(DeleteBehavior.Cascade);
            
        }
    }
}
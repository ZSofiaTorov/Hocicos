using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Sabor> Sabores { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<ItemDePedido> ItemsDePedido { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<Envio> Envios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuración de las relaciones (Opcional)
        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Cliente)
            .WithMany(c => c.Pedidos)
            .HasForeignKey(p => p.ClienteID);

        modelBuilder.Entity<Producto>()
            .HasOne(p => p.Proveedor)
            .WithMany(pr => pr.Productos)
            .HasForeignKey(p => p.ID_Proveedor);

        modelBuilder.Entity<ItemDePedido>()
            .HasOne(ip => ip.Pedido)
            .WithMany(p => p.ItemsDePedido)
            .HasForeignKey(ip => ip.PedidoID);

        modelBuilder.Entity<ItemDePedido>()
            .HasOne(ip => ip.Producto)
            .WithMany(p => p.Sabores)
            .HasForeignKey(ip => ip.ProductoID);

        modelBuilder.Entity<ItemDePedido>()
            .HasOne(ip => ip.Sabor)
            .WithMany(s => s.Producto)
            .HasForeignKey(ip => ip.SaborID);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Pago)
            .WithOne(pg => pg.Pedido)
            .HasForeignKey<Pago>(pg => pg.PedidoID);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Envio)
            .WithOne(e => e.Pedido)
            .HasForeignKey<Envio>(e => e.PedidoID);
    }
}

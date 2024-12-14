using Microsoft.EntityFrameworkCore;
using OlimpoBlazor.Models;

namespace OlimpoBlazor.Data
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) { }

        // DbSets para las tablas
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<MetricasProgreso> MetricasProgreso { get; set; }

        // Configuración del modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura la clave primaria para Inventario
            modelBuilder.Entity<Inventario>().HasKey(i => i.ItemID);

            // Configura la clave primaria para MetricasProgreso
            modelBuilder.Entity<MetricasProgreso>().HasKey(m => m.MetricaID);

            // Configura las relaciones de Reserva
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Usuario)
                .WithMany(u => u.Reservas)
                .HasForeignKey(r => r.UsuarioID)
                .OnDelete(DeleteBehavior.Restrict); // Evita eliminación en cascada

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Clase)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.ClaseID)
                .OnDelete(DeleteBehavior.Restrict); // Evita eliminación en cascada

            base.OnModelCreating(modelBuilder); // Llama al método base (solo una vez)
        }
    }
}

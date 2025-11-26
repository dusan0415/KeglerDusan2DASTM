using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class ConexionDatos : DbContext
    {
        public DbSet<Cliente> RegistroClientes { get; set; }
        public DbSet<CuentaCorriente> RegistroCuentas { get; set; }
        public DbSet<Movimiento> RegistroMovimientos { get; set; }

        private readonly string cadenaConexion =
            "Data Source=LocalHost;Initial Catalog=BancoDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer(cadenaConexion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- Cliente ---
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("RegistroClientes");
                entity.HasKey(c => c.UsuarioCodigo);

                entity.Property(c => c.UsuarioCodigo).HasColumnName("UsuarioCodigo");
                entity.Property(c => c.PrimerNombre).HasColumnName("PrimerNombre");
                entity.Property(c => c.SegundoNombre).HasColumnName("SegundoNombre");
                entity.Property(c => c.Documento).HasColumnName("Documento");
                entity.Property(c => c.NumeroContacto).HasColumnName("NumeroContacto");

                entity.HasMany(c => c.Bolsas)
                      .WithOne() // no hace falta nav inversa
                      .HasForeignKey(c => c.UsuarioCodigo)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // --- CuentaCorriente ---
            modelBuilder.Entity<CuentaCorriente>(entity =>
            {
                entity.ToTable("RegistroCuentas");
                entity.HasKey(c => c.BilleteraCodigo);

                entity.Property(c => c.BilleteraCodigo).HasColumnName("BilleteraCodigo");
                entity.Property(c => c.UsuarioCodigo).HasColumnName("UsuarioCodigo");
                entity.Property(c => c.MontoActual).HasColumnName("MontoActual");

                entity.HasMany(c => c.Registros)
                      .WithOne(m => m.CuentaCorriente)
                      .HasForeignKey(m => m.BilleteraCodigo)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // --- Movimiento ---
            modelBuilder.Entity<Movimiento>(entity =>
            {
                entity.ToTable("RegistroMovimientos");
                entity.HasKey(m => m.TransaccionCodigo);

                entity.Property(m => m.TransaccionCodigo).HasColumnName("TransaccionCodigo");
                entity.Property(m => m.BilleteraCodigo).HasColumnName("BilleteraCodigo");
                entity.Property(m => m.FechaOperacion).HasColumnName("FechaOperacion");
                entity.Property(m => m.Detalle).HasColumnName("Detalle");
                entity.Property(m => m.Valor).HasColumnName("Valor");
                entity.Property(m => m.Categoria).HasColumnName("Categoria");

                entity.HasOne(m => m.CuentaCorriente)
                      .WithMany(c => c.Registros)
                      .HasForeignKey(m => m.BilleteraCodigo)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}

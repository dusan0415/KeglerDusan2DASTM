using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
	public class Context : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<CuentaCorriente> Cuentas { get; set; }
		public DbSet<Movimiento> Movimientos { get; set; }

		public string Cadena = "Data Source=(localdb)\\Servidores;Initial Catalog=BancoDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=True;Command Timeout=0";
		protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(Cadena);
	}

}/*
 */
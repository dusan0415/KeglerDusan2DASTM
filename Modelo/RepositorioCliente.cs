using Entidades;
using Modelo;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using System.Linq;

namespace Modelo
{
	public class RepositorioCliente
	{
		private static RepositorioCliente _instancia;

		// Singleton
		private RepositorioCliente() { }

		public static RepositorioCliente Instancia
		{
			get
			{
				if (_instancia == null)
					_instancia = new RepositorioCliente();

				return _instancia;
			}
		}

		public void Agregar(Cliente cliente)
		{
			using (var context = new Context())
			{
				context.Clientes.Add(cliente);
				context.SaveChanges();
			}
		}

		public void Modificar(Cliente cliente)
		{
			using (var context = new Context())
			{
				var existente = context.Clientes.Find(cliente.ClienteId);
				if (existente != null)
				{
					existente.Nombre = cliente.Nombre;
					existente.Apellido = cliente.Apellido;
					existente.Dni = cliente.Dni;
					existente.Telefono = cliente.Telefono;
					context.SaveChanges();
				}
			}
		}

		public void Eliminar(int id)
		{
			using (var context = new Context())
			{
				var cliente = context.Clientes.Find(id);
				if (cliente != null)
				{
					context.Clientes.Remove(cliente);
					context.SaveChanges();
				}
			}
		}

		public Cliente ObtenerPorId(int id)
		{
			using (var context = new Context())
			{
				return context.Clientes.Find(id);
			}
		}

		public List<Cliente> ObtenerTodos()
		{
			using (var context = new Context())
			{
				return context.Clientes.ToList();
			}
		}
	}
}

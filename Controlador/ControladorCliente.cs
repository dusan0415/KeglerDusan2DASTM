using Entidades;
using Modelo;
using System.Collections.Generic;

namespace Controlador
{
	public class ControladorCliente
	{
		private static ControladorCliente _instancia;
		public static ControladorCliente Instancia
		{
			get
			{
				if (_instancia == null)
					_instancia = new ControladorCliente();
				return _instancia;
			}
		}

		private readonly RepositorioCliente repo = RepositorioCliente.Instancia;

		public void Agregar(Cliente c) => repo.Agregar(c);
		public void Modificar(Cliente c) => repo.Modificar(c);
		public void Eliminar(int id) => repo.Eliminar(id);
		public Cliente ObtenerPorId(int id) => repo.ObtenerPorId(id);
		public List<Cliente> Listar() => repo.ObtenerTodos();
	}
}

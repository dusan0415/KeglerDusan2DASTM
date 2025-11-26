using Entidades;
using Controlador;
using Modelo;
using System.Collections.Generic;

namespace Controlador
{
    public class GestorCliente
    {
        private static GestorCliente _instancia;

        public static GestorCliente Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new GestorCliente();
                return _instancia;
            }
        }

        private readonly ArchivoCliente repositorio = ArchivoCliente.Fuente;

        public void Registrar(Cliente cliente) => repositorio.Registrar(cliente);
        public void Actualizar(Cliente cliente) => repositorio.Actualizar(cliente);
        public void Remover(int codigo) => repositorio.Suprimir(codigo);
        public Cliente BuscarPorCodigo(int codigo) => repositorio.BuscarPorId(codigo);
        public List<Cliente> ListarTodos() => repositorio.ListarTodo();
    }
}

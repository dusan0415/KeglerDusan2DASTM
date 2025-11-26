using Entidades;
using Controlador;
using Modelo;
using System.Collections.Generic;

namespace Controlador
{
    public class GestorCuenta
    {
        private static GestorCuenta _instancia;

        public static GestorCuenta Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new GestorCuenta();
                return _instancia;
            }
        }

        private readonly ArchivoCuenta repositorio = ArchivoCuenta.Fuente;

        public void Registrar(CuentaCorriente cuenta) => repositorio.Registrar(cuenta);
        public void Actualizar(CuentaCorriente cuenta) => repositorio.Actualizar(cuenta);
        public void Remover(int codigo) => repositorio.Suprimir(codigo);
        public CuentaCorriente BuscarPorCodigo(int codigo) => repositorio.BuscarPorId(codigo);
        public List<CuentaCorriente> ListarTodas() => repositorio.ListarTodo();
    }
}

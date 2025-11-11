using Entidades;
using Modelo;
using System.Collections.Generic;

namespace Controlador
{
    public class ControladorCuenta
    {
        private static ControladorCuenta _instancia;
        

        public static ControladorCuenta Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ControladorCuenta();
                return _instancia;
            }
        }
       
        

        private readonly RepositorioCuenta repo = RepositorioCuenta.Instancia;

        public void Agregar(CuentaCorriente c) => repo.Agregar(c);
        public void Modificar(CuentaCorriente c) => repo.Modificar(c);
        public void Eliminar(int id) => repo.Eliminar(id);
        public CuentaCorriente ObtenerPorId(int id) => repo.ObtenerPorId(id);
        public List<CuentaCorriente> Listar() => repo.ObtenerTodas();
    }
}

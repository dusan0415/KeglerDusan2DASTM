using Entidades;
using Modelo;
using System;
using System.Collections.Generic;

namespace Banco.Controlador
{
    public class ControladorMovimiento
    {
        private static ControladorMovimiento _instancia;

        public static ControladorMovimiento Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ControladorMovimiento();
                return _instancia;
            }
        }

        private readonly RepositorioMovimiento repo = RepositorioMovimiento.Instancia;
        private readonly RepositorioCuenta repoCuenta = RepositorioCuenta.Instancia;

        public void Agregar(Movimiento m)
        {
            if (m.Monto <= 0)
                throw new Exception("El monto debe ser positivo.");

            repo.Agregar(m);

            var cuenta = repoCuenta.ObtenerPorId(m.CuentaCorrienteId);
            if (cuenta != null)
            {
                var totalCreditos = repo.ObtenerPorCuenta(cuenta.CuentaCorrienteId).Where(x => x.Tipo == "Crédito").Sum(x => x.Monto);
                var totalDebitos = repo.ObtenerPorCuenta(cuenta.CuentaCorrienteId).Where(x => x.Tipo == "Débito").Sum(x => x.Monto);
                cuenta.Saldo = totalCreditos - totalDebitos;
                repoCuenta.Modificar(cuenta);
            }
        }

        public void Modificar(Movimiento m) => repo.Modificar(m);
        public void Eliminar(int id) => repo.Eliminar(id);
        public Movimiento ObtenerPorId(int id) => repo.ObtenerPorId(id);
        public List<Movimiento> ObtenerPorCuenta(int idCuenta) => repo.ObtenerPorCuenta(idCuenta);
    }
}

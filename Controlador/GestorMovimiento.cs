using Entidades;
using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controlador
{
    public class GestorMovimiento
    {
        private static GestorMovimiento _instancia;

        public static GestorMovimiento Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new GestorMovimiento();
                return _instancia;
            }
        }

        private readonly ArchivoMovimiento repositorioMov = ArchivoMovimiento.Fuente;
        private readonly ArchivoCuenta repositorioCuenta = ArchivoCuenta.Fuente;

        public void Registrar(Movimiento m)
        {
            if (m.Valor <= 0)
                throw new Exception("El valor debe ser mayor que cero.");

            repositorioMov.Registrar(m);

            var cuenta = repositorioCuenta.BuscarPorId(m.BilleteraCodigo);
            if (cuenta != null)
            {
                var creditos = repositorioMov.ListarPorCuenta(cuenta.BilleteraCodigo)
                    .Where(x => x.Categoria == "Crédito")
                    .Sum(x => x.Valor);

                var debitos = repositorioMov.ListarPorCuenta(cuenta.BilleteraCodigo)
                    .Where(x => x.Categoria == "Débito")
                    .Sum(x => x.Valor);

                cuenta.MontoActual = creditos - debitos;
                repositorioCuenta.Actualizar(cuenta);
            }
        }

        public void Actualizar(Movimiento m) => repositorioMov.Actualizar(m);
        public void Remover(int codigo) => repositorioMov.Suprimir(codigo);
        public Movimiento BuscarPorCodigo(int codigo) => repositorioMov.BuscarPorId(codigo);
        public List<Movimiento> BuscarPorCuenta(int codigoCuenta) => repositorioMov.ListarPorCuenta(codigoCuenta);
    }
}

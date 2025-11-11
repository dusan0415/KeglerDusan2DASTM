using Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Modelo
{
    public class RepositorioMovimiento
    {
        private static RepositorioMovimiento _instancia;
        private RepositorioMovimiento() { }

        public static RepositorioMovimiento Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new RepositorioMovimiento();
                return _instancia;
            }
        }

        public void Agregar(Movimiento movimiento)
        {
            using (var context = new Context())
            {
                context.Movimientos.Add(movimiento);
                context.SaveChanges();
            }
        }

        public void Modificar(Movimiento movimiento)
        {
            using (var context = new Context())
            {
                var existente = context.Movimientos.Find(movimiento.MovimientoId);
                if (existente != null)
                {
                    existente.Fecha = movimiento.Fecha;
                    existente.Descripcion = movimiento.Descripcion;
                    existente.Monto = movimiento.Monto;
                    existente.Tipo = movimiento.Tipo;
                    context.SaveChanges();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var context = new Context())
            {
                var mov = context.Movimientos.Find(id);
                if (mov != null)
                {
                    context.Movimientos.Remove(mov);
                    context.SaveChanges();
                }
            }
        }

        public Movimiento ObtenerPorId(int id)
        {
            using (var context = new Context())
                return context.Movimientos.Include("CuentaCorriente").FirstOrDefault(m => m.MovimientoId == id);
        }

        public List<Movimiento> ObtenerPorCuenta(int cuentaId)
        {
            using (var context = new Context())
                return context.Movimientos.Where(m => m.CuentaCorrienteId == cuentaId).ToList();
        }

    }
}

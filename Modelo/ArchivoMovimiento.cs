using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Modelo
{
    public class ArchivoMovimiento
    {
        private static ArchivoMovimiento _fuente;
        private ArchivoMovimiento() { }

        public static ArchivoMovimiento Fuente
        {
            get
            {
                if (_fuente == null)
                    _fuente = new ArchivoMovimiento();
                return _fuente;
            }
        }

        public void Registrar(Movimiento transaccion)
        {
            using (var db = new ConexionDatos())
            {
                db.RegistroMovimientos.Add(transaccion);
                db.SaveChanges();
            }
        }

        public void Actualizar(Movimiento transaccion)
        {
            using (var db = new ConexionDatos())
            {
                var existente = db.RegistroMovimientos.Find(transaccion.TransaccionCodigo);
                if (existente != null)
                {
                    existente.FechaOperacion = transaccion.FechaOperacion;
                    existente.Detalle = transaccion.Detalle;
                    existente.Valor = transaccion.Valor;
                    existente.Categoria = transaccion.Categoria;
                    db.SaveChanges();
                }
            }
        }

        public void Suprimir(int id)
        {
            using (var db = new ConexionDatos())
            {
                var mov = db.RegistroMovimientos.Find(id);
                if (mov != null)
                {
                    db.RegistroMovimientos.Remove(mov);
                    db.SaveChanges();
                }
            }
        }

        public Movimiento BuscarPorId(int id)
        {
            using (var db = new ConexionDatos())
                return db.RegistroMovimientos
                    .Include("CuentaCorriente")
                    .FirstOrDefault(m => m.TransaccionCodigo == id);
        }

        public List<Movimiento> ListarPorCuenta(int billeteraId)
        {
            using (var db = new ConexionDatos())
                return db.RegistroMovimientos
                    .Where(m => m.BilleteraCodigo == billeteraId)
                    .ToList();
        }
    }
}

using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Modelo
{
    public class ArchivoCuenta
    {
        private static ArchivoCuenta _fuente;
        private ArchivoCuenta() { }

        public static ArchivoCuenta Fuente
        {
            get
            {
                if (_fuente == null)
                    _fuente = new ArchivoCuenta();
                return _fuente;
            }
        }

        public void Registrar(CuentaCorriente billetera)
        {
            using (var db = new ConexionDatos())
            {
                db.RegistroCuentas.Add(billetera);
                db.SaveChanges();
            }
        }

        public void Actualizar(CuentaCorriente billetera)
        {
            using (var db = new ConexionDatos())
            {
                var existente = db.RegistroCuentas.Find(billetera.BilleteraCodigo);
                if (existente != null)
                {
                    existente.MontoActual = billetera.MontoActual;
                    existente.UsuarioCodigo = billetera.UsuarioCodigo;
                    db.SaveChanges();
                }
            }
        }

        public void Suprimir(int id)
        {
            using (var db = new ConexionDatos())
            {
                var cuenta = db.RegistroCuentas.Find(id);
                if (cuenta != null)
                {
                    db.RegistroCuentas.Remove(cuenta);
                    db.SaveChanges();
                }
            }
        }

        public CuentaCorriente BuscarPorId(int id)
        {
            using (var db = new ConexionDatos())
                return db.RegistroCuentas.Find(id);
        }

        public List<CuentaCorriente> ListarTodo()
        {
            using (var db = new ConexionDatos())
                return db.RegistroCuentas.ToList();
        }

        public bool GenerarInforme(int billeteraId, out string mensaje)
        {
            try
            {
                var billetera = Fuente.BuscarPorId(billeteraId);
                if (billetera == null)
                {
                    mensaje = "No se halló la cuenta indicada.";
                    return false;
                }

                string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "Cuentas");
                if (!Directory.Exists(rutaCarpeta))
                    Directory.CreateDirectory(rutaCarpeta);

                string nombreArchivo = $"Billetera_{billetera.BilleteraCodigo}.txt";
                string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);

                using (StreamWriter pluma = new StreamWriter(rutaArchivo, false))
                {
                    pluma.WriteLine("========================================");
                    pluma.WriteLine("        REPORTE DE BILLETERA");
                    pluma.WriteLine("========================================");
                    pluma.WriteLine($"Fecha del reporte: {DateTime.Now}");
                    pluma.WriteLine($"Código: {billetera.BilleteraCodigo}");
                    pluma.WriteLine($"Propietario: {billetera.UsuarioCodigo}");
                    pluma.WriteLine($"Saldo actual: ${billetera.MontoActual:F2}");
                    pluma.WriteLine("========================================");
                    pluma.WriteLine();
                    pluma.WriteLine("🔹 REGISTROS DE MOVIMIENTOS:");
                    pluma.WriteLine("----------------------------------------");

                    if (billetera.Registros == null || billetera.Registros.Count == 0)
                        pluma.WriteLine("Sin registros.");
                    else
                        foreach (var mov in billetera.Registros)
                            pluma.WriteLine($"[{mov.FechaOperacion}] {mov.Detalle} - Valor: ${mov.Valor:F2} - {mov.Categoria}");

                    pluma.WriteLine("----------------------------------------");
                    pluma.WriteLine("Fin del informe");
                }

                mensaje = $"Informe creado correctamente en: {rutaArchivo}";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "Error al crear el informe: " + ex.Message;
                return false;
            }
        }
    }
}

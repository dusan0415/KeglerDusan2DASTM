using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioCuenta
    {
        private static RepositorioCuenta _instancia;
        private RepositorioCuenta() { }

        public static RepositorioCuenta Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new RepositorioCuenta();
                return _instancia;
            }
        }

        public void Agregar(CuentaCorriente cuenta)
        {
            using (var context = new Context())
            {
                context.Cuentas.Add(cuenta);
                context.SaveChanges();
            }
        }

        public void Modificar(CuentaCorriente cuenta)
        {
            using (var context = new Context())
            {
                var existente = context.Cuentas.Find(cuenta.CuentaCorrienteId);
                if (existente != null)
                {
                    existente.Saldo = cuenta.Saldo;
                    existente.ClienteId = cuenta.ClienteId;
                    context.SaveChanges();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var context = new Context())
            {
                var cuenta = context.Cuentas.Find(id);
                if (cuenta != null)
                {
                    context.Cuentas.Remove(cuenta);
                    context.SaveChanges();
                }
            }
        }

        public CuentaCorriente ObtenerPorId(int id)
        {
            using (var context = new Context())
                return context.Cuentas.Find(id);
        }

        public List<CuentaCorriente> ObtenerTodas()
        {
            using (var context = new Context())
                return context.Cuentas.ToList();
        }
        public bool ImprimirInforme(int cuentaId, out string mensaje)
        {
            try
            {
                var cuenta = _instancia.ObtenerPorId(cuentaId);
                if (cuenta == null)
                {
                    mensaje = "No se encontró la cuenta especificada.";
                    return false;
                }

                string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "Cuentas");
                if (!Directory.Exists(rutaCarpeta))
                    Directory.CreateDirectory(rutaCarpeta);

                string nombreArchivo = $"Cuenta_{cuenta.CuentaCorrienteId}.txt";
                string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);

                using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
                {
                    writer.WriteLine("========================================");
                    writer.WriteLine("          INFORME DE CUENTA");
                    writer.WriteLine("========================================");
                    writer.WriteLine($"Fecha del informe: {DateTime.Now}");
                    writer.WriteLine($"ID Cuenta: {cuenta.CuentaCorrienteId}");
                    writer.WriteLine($"ID Cliente: {cuenta.ClienteId}");
                    writer.WriteLine($"Saldo actual: ${cuenta.Saldo:F2}");
                    writer.WriteLine("========================================");
                    writer.WriteLine();
                    writer.WriteLine("🔹 HISTORIAL DE MOVIMIENTOS:");
                    writer.WriteLine("----------------------------------------");

                    if (cuenta.Movimientos == null || cuenta.Movimientos.Count == 0)
                    {
                        writer.WriteLine("Sin movimientos registrados.");
                    }
                    else
                    {
                        foreach (var mov in cuenta.Movimientos)
                            writer.WriteLine($"[{mov.Fecha}] {mov.Descripcion} - Monto: ${mov.Monto:F2}");
                    }

                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine("Fin del informe");
                }

                mensaje = "Informe generado correctamente en: " + rutaArchivo;
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "Error al generar el informe: " + ex.Message;
                return false;
            }
        }
    }
}


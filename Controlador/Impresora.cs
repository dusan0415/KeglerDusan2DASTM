using Banco.Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Impresora
    {
        ControladorMovimiento controladorMovimiento = new();
        ControladorCuenta controladorCuenta = new();
        public bool ImprimirInforme(int cuentaId, out string mensaje)
        {
            try
            {
                var cuenta = controladorCuenta.ObtenerPorId(cuentaId);
                if (cuenta == null)
                {
                    mensaje = "No se encontró la cuenta especificada.";
                    return false;
                }
                List<Movimiento> listaMov = controladorMovimiento.ObtenerPorCuenta(cuenta.CuentaCorrienteId);

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

                    if (listaMov == null || listaMov.Count == 0)
                    {
                        writer.WriteLine("Sin movimientos registrados.");
                    }
                    else
                    {
                        foreach (var mov in listaMov)
                            writer.WriteLine($"[{mov.Fecha}] {mov.Descripcion} - Monto: ${mov.Monto:F2} - Monto: {mov.Tipo}\"");
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

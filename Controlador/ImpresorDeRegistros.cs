using Entidades;
using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.IO;

namespace Controlador
{
    public class ImpresorDeRegistros
    {
        private readonly GestorMovimiento gestorMovimiento = GestorMovimiento.Instancia;
        private readonly GestorCuenta gestorCuenta = GestorCuenta.Instancia;

        public bool GenerarInforme(int codigoCuenta, out string resultado)
        {
            try
            {
                var cuenta = gestorCuenta.BuscarPorCodigo(codigoCuenta);
                if (cuenta == null)
                {
                    resultado = "La cuenta solicitada no existe.";
                    return false;
                }

                List<Movimiento> movimientos = gestorMovimiento.BuscarPorCuenta(cuenta.BilleteraCodigo);

                string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documentos", "Cuentas");
                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                string nombreArchivo = $"Registro_{cuenta.BilleteraCodigo}.txt";
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                using (StreamWriter escritor = new StreamWriter(rutaDestino, false))
                {
                    escritor.WriteLine("========================================");
                    escritor.WriteLine("           REPORTE DE CUENTA");
                    escritor.WriteLine("========================================");
                    escritor.WriteLine($"Fecha de emisión: {DateTime.Now}");
                    escritor.WriteLine($"Código de Cuenta: {cuenta.BilleteraCodigo}");
                    escritor.WriteLine($"Código de Cliente: {cuenta.UsuarioCodigo}");
                    escritor.WriteLine($"Saldo actual: ${cuenta.MontoActual:F2}");
                    escritor.WriteLine("========================================");
                    escritor.WriteLine();
                    escritor.WriteLine("  REGISTRO DE MOVIMIENTOS:");
                    escritor.WriteLine("----------------------------------------");

                    if (movimientos == null || movimientos.Count == 0)
                        escritor.WriteLine("No se hallaron movimientos registrados.");
                    else
                        foreach (var mov in movimientos)
                            escritor.WriteLine($"[{mov.FechaOperacion}] {mov.Detalle} - Valor: ${mov.Valor:F2} - Tipo: {mov.Categoria}");

                    escritor.WriteLine("----------------------------------------");
                    escritor.WriteLine("Fin del reporte");
                }

                resultado = "El informe fue creado exitosamente en: " + rutaDestino;
                return true;
            }
            catch (Exception ex)
            {
                resultado = "Error durante la generación del informe: " + ex.Message;
                return false;
            }
        }
    }
}

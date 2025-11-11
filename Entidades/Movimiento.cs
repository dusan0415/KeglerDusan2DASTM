using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Movimiento
    {
        public int MovimientoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public string Tipo { get; set; } // "Débito" o "Crédito"

        public int CuentaCorrienteId { get; set; }
        public virtual CuentaCorriente CuentaCorriente { get; set; }
    }
}

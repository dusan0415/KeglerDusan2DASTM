using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente
    {
        public int CuentaCorrienteId { get; set; }
        public decimal Saldo { get; set; }

        public int ClienteId { get; set; }

        public virtual List<Movimiento> Movimientos { get; set; } = new();

    }
}

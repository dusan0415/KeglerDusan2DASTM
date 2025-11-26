using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Entidades
{
    public class CuentaCorriente
    {
        [Key]
        public int BilleteraCodigo { get; set; }
        public decimal MontoActual { get; set; }

        public int UsuarioCodigo { get; set; }
        public virtual List<Movimiento> Registros { get; set; } = new();
    }


}


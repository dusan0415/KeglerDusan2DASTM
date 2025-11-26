using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Movimiento
    {
        [Key]
        public int TransaccionCodigo { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string Detalle { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; }

        public int BilleteraCodigo { get; set; }
        public virtual CuentaCorriente CuentaCorriente { get; set; }
    }
}

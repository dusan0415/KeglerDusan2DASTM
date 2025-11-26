using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Socios
{
    public class Socios
    {
        public int NumeroSocio {  get; set; }
        public string Nombre {  get; set; }
        public string Apellido {  get; set; }
        public int Dni {  get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Cuota {  get; set; } //true = pagado - 1   false = pendiente - 0


    }
}

using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Cliente
    {
        [Key] 
        public int UsuarioCodigo { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Documento { get; set; }
        public string NumeroContacto { get; set; }

        public virtual List<CuentaCorriente> Bolsas { get; set; } = new();
    }
}

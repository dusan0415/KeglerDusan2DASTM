namespace Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }

        public virtual List<CuentaCorriente> Cuentas { get; set; } = new();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
  /*  public sealed class RepositorioSocios
    {
        private static readonly RepositorioSocios instancia = new RepositorioSocios();
        public static RepositorioSocios Instancia
        {
            get { return instancia; }
        }
        private RepositorioSocios()
        {
        }
        public void AgregarSocio(Entidades.Movimiento socio)
        {
            using (var context = new Context())
            {
                context.Socios.Add(socio);
                context.SaveChanges();
            }
        }
        public void EliminarSocio(Entidades.Movimiento socio)
        {
            using (var context = new Context())
            {
                context.Socios.Remove(socio);
                context.SaveChanges();
            }
        }
        public void ModificarSocio(Entidades.Movimiento socio)
        {
            using (var context = new Context())
            {
                context.Socios.Update(socio);
                context.SaveChanges();
            }
        }
        public IReadOnlyCollection<Entidades.Movimiento> ListarSocios()
        {
            using (var context = new Context())
            {
                return context.Socios.ToList().AsReadOnly();
            }
        }
    }*/
}

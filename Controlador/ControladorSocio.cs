using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{/*
    public class ControladorSocio
    {
        private RepositorioSocios repoSocio;

        public ControladorSocio()
        {
            repoSocio = RepositorioSocios.Instancia;
        }

        public string AgregarSocio(Socio socio)
        {
            var socioExistente = repoSocio.ListarSocios()
                .FirstOrDefault(a => a.SocioId == socio.SocioId && a.NombreCompleto.Equals(socio.NombreCompleto, StringComparison.OrdinalIgnoreCase));
            if (socioExistente == null)
            {
                repoSocio.AgregarSocio(socio);
                return "Socio agregado";
            }

            return "El Socio ya existe";
        }

        public IReadOnlyCollection<Socio> ListarSocios()
        {
            return repoSocio.ListarSocios();
        }

        public bool ModificarSocio(Socio socio)
        {
            repoSocio.ModificarSocio(socio);
            return true;
        }

        public void EliminarSocio(Socio socio)
        {
            repoSocio.EliminarSocio(socio);
        }
    }*/
}

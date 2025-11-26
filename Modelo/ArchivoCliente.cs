using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Modelo
{
    public class ArchivoCliente
    {
        private static ArchivoCliente _fuente;
        private ArchivoCliente() { }

        public static ArchivoCliente Fuente
        {
            get
            {
                if (_fuente == null)
                    _fuente = new ArchivoCliente();
                return _fuente;
            }
        }

        public void Registrar(Cliente usuario)
        {
            using (var db = new ConexionDatos())
            {
                db.RegistroClientes.Add(usuario);
                db.SaveChanges();
            }
        }

        public void Actualizar(Cliente usuario)
        {
            using (var db = new ConexionDatos())
            {
                var existente = db.RegistroClientes.Find(usuario.UsuarioCodigo);
                if (existente != null)
                {
                    existente.PrimerNombre = usuario.PrimerNombre;
                    existente.SegundoNombre = usuario.SegundoNombre;
                    existente.Documento = usuario.Documento;
                    existente.NumeroContacto = usuario.NumeroContacto;
                    db.SaveChanges();
                }
            }
        }

        public void Suprimir(int id)
        {
            using (var db = new ConexionDatos())
            {
                var usuario = db.RegistroClientes.Find(id);
                if (usuario != null)
                {
                    db.RegistroClientes.Remove(usuario);
                    db.SaveChanges();
                }
            }
        }

        public Cliente BuscarPorId(int id)
        {
            using (var db = new ConexionDatos())
                return db.RegistroClientes.Find(id);
        }

        public List<Cliente> ListarTodo()
        {
            using (var db = new ConexionDatos())
                return db.RegistroClientes.ToList();
        }
    }
}

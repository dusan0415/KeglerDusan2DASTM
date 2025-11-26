using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica_Programacion_Club
{
    public class Repositorio
    {
        private string CadenaConexion = "Data Source=Hp;Initial Catalog=club;Integrated Security=True;TrustServerCertificate=True";
        private List<Socio> listaSocios;

        public Repositorio()
        {
            listaSocios = new List<Socio>();
        }

        public List<Socio> Listar(List<Socio> listaSocios) 
        {
            string sql = "select * from Socios";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Socio socio = new Socio();

                        socio.Id = Convert.ToInt32(reader["id"]);
                        socio.Nombre = reader["nombre"].ToString();
                        socio.Apellido = reader["apellido"].ToString();
                        socio.Dni = reader["dni"].ToString();
                        socio.FechaNacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]);
                        socio.CuotaAlDia = Convert.ToBoolean(reader["cuota_al_dia"]);

                        listaSocios.Add(socio);
                    }
                }
            }
                return listaSocios;
        }

        public void AgregarSocio(Socio socio)
        {
            string sql = "insert into Socios (nombre, apellido, dni, fecha_nacimiento, cuota_al_dia) " +
                "values (@nombre, @apellido, @dni, @fecha_nacimiento, @cuota_al_dia)";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@nombre", socio.Nombre).ToString();
                    comando.Parameters.AddWithValue("@apellido", socio.Apellido).ToString();
                    comando.Parameters.AddWithValue("@dni", socio.Dni).ToString();
                    comando.Parameters.AddWithValue("@fecha_nacimiento", Convert.ToDateTime(socio.FechaNacimiento));
                    comando.Parameters.AddWithValue("@cuota_al_dia", Convert.ToBoolean(socio.CuotaAlDia));
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Socio Agregado");

                }

            }

        }
        public void EliminarSocio(Socio socio) 
        {
            string sql = "delete from Socios where id = @id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open() ;
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", socio.Id).ToString();
                    comando.ExecuteNonQuery() ;
                    MessageBox.Show("Socio Eliminado");

                }
            }
        }

        public void ModificarSocio(Socio socio)
        {
            string sql = "update Socios set nombre = @nombre, apellido = @apellido, " +
                "dni = @dni, fecha_nacimiento = @fecha_nacimiento, cuota_al_dia = @cuota_al_dia where id = @id";

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@id", socio.Id);
                    comando.Parameters.AddWithValue("@nombre", socio.Nombre);
                    comando.Parameters.AddWithValue("@apellido", socio.Apellido);
                    comando.Parameters.AddWithValue("@dni", socio.Dni);
                    comando.Parameters.AddWithValue("@fecha_nacimiento", socio.FechaNacimiento);
                    comando.Parameters.AddWithValue("@cuota_al_dia", socio.CuotaAlDia);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("socio modificado");


                }
            }



        }






    }
}

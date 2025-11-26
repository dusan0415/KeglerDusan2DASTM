using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Club_Socios
{
    public class Repositorio
    {
        private string CadenaConexion = "Data Source=Hp;Initial Catalog=club;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        private List<Socios> listaSocios;

        public Repositorio()
        {
            listaSocios = new List<Socios>();
        }



        public IReadOnlyCollection<Socios> ListarSocios()
        {
            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string sql = "select * from Socios";

                using (SqlCommand comando = new SqlCommand(sql, conn))
                using (SqlDataReader reader = comando.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        listaSocios.Add(new Socios
                        {
                            NumeroSocio = Convert.ToInt32(reader["id"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Dni = Convert.ToInt32(reader["dni"]),
                            FechaNacimiento = (DateTime)reader["fecha_nacimiento"],
                            Cuota = (bool)reader["cuota_al_dia"]
                        }
                            );
                    }
                }
            }
            return listaSocios;
        }

        public void AltaSocio(Socios socio)
        {

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string sql = "insert into Socios (nombre, apellido, dni, fecha_nacimiento, cuota_al_dia) values" +
                    "(@nombre, @apellido, @dni, @fecha_nacimiento, @cuota_al_dia)";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@nombre", socio.Nombre);
                    comando.Parameters.AddWithValue("@apellido", socio.Apellido);
                    comando.Parameters.AddWithValue("@dni", socio.Dni);
                    comando.Parameters.AddWithValue("@fecha_nacimiento", socio.FechaNacimiento);
                    comando.Parameters.AddWithValue("@cuota_al_dia", socio.Cuota);

                    comando.ExecuteNonQuery();

                }

            }

        }

        public void ModificarSocio(Socios socio)
        {

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string sql = "update Socios set " +
                    "nombre = @nombre, " +
                    "apellido = @apellido, " +
                    "dni = @dni, " +
                    "fecha_nacimiento = @fecha_nacimiento, " +
                    "cuota_al_dia = @cuota_al_dia " +
                    "where id = @id";

                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@id", socio.NumeroSocio);
                    comando.Parameters.AddWithValue("@nombre", socio.Nombre);
                    comando.Parameters.AddWithValue("@apellido", socio.Apellido);
                    comando.Parameters.AddWithValue("@dni", socio.Dni);
                    comando.Parameters.AddWithValue("@fecha_nacimiento", socio.FechaNacimiento);
                    comando.Parameters.AddWithValue("@cuota_al_dia", socio.Cuota);

                    comando.ExecuteNonQuery();

                }

            }

        }

        public void BajaSocio(Socios socio)
        {

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            {
                conn.Open();
                string sql = "delete from Socios where id = @id"; 

                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@id", socio.NumeroSocio);

                    comando.ExecuteNonQuery();

                }

            }

        }


















    }
}


//Alta: agregar un nuevo socio al sistema.
//Baja: eliminar un socio existente.
//Modificación: actualizar los datos de un socio.
//Listado: mostrar todos los socios registrados.

//Un método que permita calcular la cantidad de socios con la cuota al día.
//Un método que, dada una edad ingresada por el usuario, muestre todos los socios mayores a esa edad.

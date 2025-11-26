using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Club_Socios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Repositorio repositorio = new Repositorio();


        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void btn_AltaSocio_Click(object sender, EventArgs e)
        {
            string nombre = txt_Nombre.Text.ToUpper();
            string apellido = txt_Apellido.Text.ToUpper();
            int dni = int.Parse(txt_Dni.Text);
            DateTime fechaNacimiento = dtp_FechaNacimiento.Value;
            bool cuota;
            cuota = rb_Si.Checked;

            Socios nuevoSocio = new Socios()
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                FechaNacimiento = fechaNacimiento,
                Cuota = cuota
            };

            repositorio.AltaSocio(nuevoSocio);
            MessageBox.Show("Socio creado exitosamente!! :D");


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            IReadOnlyCollection<Socios> todosLosSocios = repositorio.ListarSocios();
            Socios buscado = todosLosSocios.FirstOrDefault(s => s.NumeroSocio == int.Parse(txt_Id.Text));

            if (buscado != null)
            {
                string nombre = txt_Nombre.Text.ToUpper();
                string apellido = txt_Apellido.Text.ToUpper();
                int dni = int.Parse(txt_Dni.Text);
                DateTime fechaNacimiento = dtp_FechaNacimiento.Value;
                bool cuota;
                cuota = rb_Si.Checked;

                Socios socioModificado = new Socios()
                {
                    NumeroSocio = int.Parse(txt_Id.Text),
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    FechaNacimiento = fechaNacimiento,
                    Cuota = cuota
                };

                repositorio.ModificarSocio(socioModificado);
                MessageBox.Show("Socio modificado exitosamente!! :D");
            }
        }

        private void btn_BajaSocio_Click(object sender, EventArgs e)
        {
            IReadOnlyCollection<Socios> todosLosSocios = repositorio.ListarSocios();
            Socios buscado = todosLosSocios.FirstOrDefault(s => s.NumeroSocio == int.Parse(txt_Id.Text));

            if (buscado != null)
            {
                if (MessageBox.Show("¿Desea eliminar este socio?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Socios socioModificado = new Socios()
                    {
                        NumeroSocio = int.Parse(txt_Id.Text),
                    };

                    repositorio.BajaSocio(socioModificado);
                    MessageBox.Show("Socio eliminado exitosamente!! :D");
                }
            }
        }

        private void btn_VistaSocios_Click(object sender, EventArgs e)
        {
            repositorio.VistaSocios();
        }
    }
}





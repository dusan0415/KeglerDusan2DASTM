namespace Practica_Programacion_Club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Repositorio repositorio = new Repositorio();
        List<Socio> listaSocios = new List<Socio>();


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Socio socio = new Socio();

            socio.Nombre = txt_Nombre.Text.ToUpper();
            socio.Apellido = txt_Apellido.Text.ToUpper();
            socio.Dni = txt_Dni.Text.ToUpper();
            socio.FechaNacimiento = dtp_FechaNacimiento.Value;
            if (cb_Cuota.Checked) { socio.CuotaAlDia = true; }

            repositorio.AgregarSocio(socio);

        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            listaSocios.Clear();

            repositorio.Listar(listaSocios);

            foreach (var socio in listaSocios)
            {
                MessageBox.Show($"Id: {socio.Id}\n" +
                                $"Nombre: {socio.Nombre}\n" +
                                $"Apellido: {socio.Apellido}\n" +
                                $"Dni: {socio.Dni}\n" +
                                $"Nacimiento: {socio.FechaNacimiento} \n" +
                                $"Cuota al día: {socio.CuotaAlDia} \n");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Socio nuevoSocio = new Socio();

            nuevoSocio.Id = int.Parse(txt_Id.Text);

            repositorio.Listar(listaSocios);

            var buscado = listaSocios.FirstOrDefault(s => s.Id == nuevoSocio.Id);

            if (buscado != null)
            {
                repositorio.EliminarSocio(buscado);
            }



        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Socio nuevoSocio = new Socio();

            nuevoSocio.Id = int.Parse(txt_Id.Text);
            nuevoSocio.Nombre = txt_Nombre.Text.ToUpper();
            nuevoSocio.Apellido = txt_Apellido.Text.ToUpper();
            nuevoSocio.Dni = txt_Dni.Text.ToUpper();
            nuevoSocio.FechaNacimiento = dtp_FechaNacimiento.Value;
            if (cb_Cuota.Checked) { nuevoSocio.CuotaAlDia = true; }

            repositorio.Listar(listaSocios);

            var buscado = listaSocios.FirstOrDefault(s => s.Id == nuevoSocio.Id);

            if (buscado != null) { repositorio.ModificarSocio(nuevoSocio); }


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_01_CRUD
{
    public partial class FrmGentes : Form
    {
        public FrmGentes()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            cdPeopleTableAdapters.DataTable1TableAdapter tablita = new cdPeopleTableAdapters.DataTable1TableAdapter();

            tablita.Agregar( (int)nud_id.Value, txt_Nombre.Text.Trim(), (int)nud_edad.Value);
        }
    }
}

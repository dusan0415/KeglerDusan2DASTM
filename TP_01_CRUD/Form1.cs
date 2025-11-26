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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar() 
        {
            cdPeopleTableAdapters.DataTable1TableAdapter tablita = new cdPeopleTableAdapters.DataTable1TableAdapter();
            cdPeople.DataTable1DataTable dt = tablita.GetData();
            dataGridView1.DataSource = dt;

        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            FrmGentes form = new FrmGentes(); 
            form.ShowDialog();
        }
    }
}

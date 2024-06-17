using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoV3
{
    public partial class FrmActualizarPapeles : Form
    {
        public FrmActualizarPapeles()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            FrmMotos Fm = new FrmMotos();
            Fm.Show();
        }

        private void FrmActualizarPapeles_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Calendario.Visible = true;
            }
            else
            {
                Calendario.Visible = false;
                TxtSoat.Text = Calendario.Value.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Calendario2.Visible = true;
            }
            else
            {
                Calendario2.Visible = false;
                TxtTecno.Text = Calendario2.Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}

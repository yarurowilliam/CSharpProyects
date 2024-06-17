using BLL;
using ENTITY;
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
    public partial class FrmAgregarMoto : Form
    {
        MotocicletasServiceDB servicio = new MotocicletasServiceDB();
        Motocicleta motocicleta;
        public FrmAgregarMoto()
        {        
            InitializeComponent();
            motocicleta = new Motocicleta();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            try
            {
                if (TxtCedula.Text.Trim().Equals("") || (TxtCilindraje.Text.Trim().Equals("")) || (TxtModelo.Text.Trim().Equals("")) || (TxtPapeles.Text.Trim().Equals(""))|| (TxtPapeles.Text.Trim().Equals("")))
                {
                    string Mensaje = "ATENCION\nVERIFIQUE QUE NO HAY ESPACIOS EN BLANCO";
                    MessageBox.Show(Mensaje, "ERROR INGRESO DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    motocicleta = servicio.Crear();
                    Mapear();
                    string Mensaje = servicio.Guardar(motocicleta);
                    MessageBox.Show(Mensaje, "Mensaje al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }

        }
            catch (Exception)
            {
                string Mensaje = "Error";
        MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

}

        public void Mapear()
        {
            motocicleta.Placa = TxtCedula.Text;
            motocicleta.Cilindraje = TxtCilindraje.Text;
            motocicleta.Modelo = TxtModelo.Text;
            motocicleta.DateSOAT = Calendario.Value;
            motocicleta.DateTecnicoMecanica = Calendario2.Value;
        }

        public void Limpiar()
        {
            TxtCedula.Text = "";
            TxtCilindraje.Text = "";
            TxtModelo.Text = "";
            TxtPapeles.Text = "";
            TxtTecno.Text = "";
        }



        private void FrmAgregarMoto_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Calendario.Visible = true;
            } else
            {
                Calendario.Visible = false;
                TxtPapeles.Text = Calendario.Value.ToString();
                //TxtPapeles.Text = Calendario.Value.Month.ToString();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Calendario2.Visible = true;

            }
            else
            {
                Calendario2.Visible = false;
                TxtTecno.Text = Calendario2.Value.ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtPapeles_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

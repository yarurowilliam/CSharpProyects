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
    public partial class FrmAgregarConductor : Form
    {
        ConductoresServiceDB servicio = new ConductoresServiceDB();
        Conductor conductor;
        public FrmAgregarConductor()
        {
            InitializeComponent();
        }

        private void FrmAgregarConductor_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//AGREGAR
        {
            Guardare();
        }

        public void Guardare()
        {
            try
            {
                if (TxtCedula.Text.Trim().Equals("") || (TxtNombre.Text.Trim().Equals("")) || (TxtTelefono.Text.Trim().Equals("")) || (TxtDireccion.Text.Trim().Equals("")))
                {
                    string Mensaje = "ATENCION\nVERIFIQUE QUE NO HAY ESPACIOS EN BLANCO";
                    MessageBox.Show(Mensaje, "ERROR INGRESO DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conductor = servicio.CrearConductor();
                    Mapear();
                    string Mensaje = servicio.Guardar(conductor);
                    MessageBox.Show(Mensaje, "Mensaje al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
            catch (Exception)
            {
                string Mensaje = "Error";
                MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  throw;
            }
        }

        public void Mapear()
        {
            conductor.Identificacion = TxtCedula.Text;
            conductor.Nombre = TxtNombre.Text;
            conductor.Telefono = TxtTelefono.Text;
            conductor.Direccion = TxtDireccion.Text;
        }

        public void Limpiar()
        {
            TxtCedula.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                string Mensaje = "¡SOLO NUMEROS EN EL CAMPO IDENTIFICACION!";
                MessageBox.Show(Mensaje, "[E-110] Ingreso de datos fallido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                string Mensaje = "¡SOLO LETRAS EN EL CAMPO NOMBRE!";
                MessageBox.Show(Mensaje, "[E-110] Ingreso de datos fallido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                string Mensaje = "¡SOLO NUMEROS EN EL CAMPO TELEFONO!";
                MessageBox.Show(Mensaje, "[E-110] Ingreso de datos fallido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

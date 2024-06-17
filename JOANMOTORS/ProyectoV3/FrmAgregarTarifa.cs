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
    public partial class FrmAgregarTarifa : Form
    {

        TarifaServiceDB servicio = new TarifaServiceDB();

        public FrmAgregarTarifa()
        {
            InitializeComponent();
        }


        private void FrmAgregarTarifa_Load(object sender, EventArgs e)
        {

        }

        private void CheckBuscar_CheckedChanged(object sender, EventArgs e)
        {
            FrmMotos Fm = new FrmMotos();
            Fm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregare();
        }

        private void Agregare()
        {
            Tarifa tarifa = new Tarifa();
            tarifa.Valor = Convert.ToDouble(TxtTarifa.Text);
            if (servicio.Buscar() == null)
            {
                string Mensaje = servicio.Guardar(tarifa);
                MessageBox.Show(Mensaje, "Mensaje al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Mensaje = servicio.Modificar(tarifa);
                MessageBox.Show(Mensaje, "Mensaje al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Key();
        }

        private void Key()
        {
            string comprobar = txtKeyMaster.Text;
            if (comprobar.Equals("joan04"))
            {
                string Mensaje = "¡UTILIZASTE LA KEY MASTER!\nTARIFA GLOBAL HABILITADA\n¡OJO AL DATO!";
                MessageBox.Show(Mensaje, "KEYMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTarifa.Visible = true;
                TxtTarifa.Visible = true;
                BtnAgregar.Visible = true;
                btnKey.Visible = false;
                lblKey.Visible = false;
                txtKeyMaster.Visible = false;
            }
            else
            {
                string Mensaje = "¡CONTRASEÑA INCORRECTA!\nVERIFIQUE SU KEYMASTER";
                MessageBox.Show(Mensaje, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace ProyectoV3
{
    public partial class FrmConductores : Form
    {
        ServicioPDF servicioPDF;
        ConductoresServiceDB servicio = new ConductoresServiceDB();
        Conductor Conductor;
        

        public FrmConductores()
        {
            try
            {
                InitializeComponent();
                Consultar();
            }
            catch (Exception)
            {
                string Men = "ERROR";
                MessageBox.Show(Men, "Mensaje al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public FrmConductores(ref Conductor conductor)
        {
            try
            {
                InitializeComponent();
                Conductor = conductor;
            }
            catch (Exception)
            {
                string Men = "ERROR";
                MessageBox.Show(Men,"Mensaje al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmConductores_Load(object sender, EventArgs e)
        {

        }

        public void Consultar()
        {
            TablaConductores.DataSource = servicio.ConsultarTodos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TablaConductores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void TablaConductores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Conductor.Identificacion = ((Conductor) TablaConductores.CurrentRow.DataBoundItem).Identificacion;
            Conductor.Deuda = ((Conductor)TablaConductores.CurrentRow.DataBoundItem).Deuda;
            this.Dispose();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<Conductor> conductores = new List<Conductor>();
                servicioPDF = new ServicioPDF(saveFileDialog1.FileName);
                saveFileDialog1.Dispose();
                conductores = servicio.ConsultarTodos();
                servicioPDF.Save(conductores);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

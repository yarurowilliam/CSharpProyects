using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace ProyectoV3
{
    public partial class FrmChofer : Form
    {
        MotocicletasServiceDB servicio = new MotocicletasServiceDB();
        ConductoresServiceDB servicio2 = new ConductoresServiceDB();
        public FrmChofer()
        {
            InitializeComponent();
        }

        private void CheckBuscar_CheckedChanged(object sender, EventArgs e)
        {
            Motocicleta motocicleta = new Motocicleta();
            FrmMotos Fm2 = new FrmMotos(ref motocicleta);
            Fm2.ShowDialog();
            TxtPlaca.Text = motocicleta.Placa;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Conductor conductor = new Conductor();
            FrmConductores Fm1 = new FrmConductores(ref conductor);
            Fm1.ShowDialog();
            TxtCodigo.Text = conductor.Identificacion;
        }

        private void FrmChofer_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Asignar();
        }
        public void Asignar()
        {
            string iden = TxtCodigo.Text;
            string placa = TxtPlaca.Text;
            Conductor conductor = new Conductor();
            Motocicleta moto = new Motocicleta();
            conductor = servicio2.BuscarConductor(iden);
            moto = servicio.BuscarMoto(placa);
            moto.Conductor = conductor;
            var mensaje = servicio.GuardarMotoAsignada(moto);
            MessageBox.Show(mensaje, "Mensaje al Liquidar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (mensaje == "ASIGNACION COMPLETA")
            {
                moto.Estado = "OCUPADA";
                servicio.Modificar(moto);
            }
        }

        public void Prueba()
        {
            string id = TxtCodigo.Text;
            string placa = TxtPlaca.Text;
            Conductor conductor = new Conductor();
            Motocicleta moto = new Motocicleta();
            conductor = servicio2.BuscarConductor(id);
            moto.Conductor = conductor;
            moto = servicio.BuscarMoto(placa);
            // servicio.Crear();
            moto.Estado = "OCUPADA";
            servicio.Modificar(moto);               
            var mensaje = servicio.GuardarMotoAsignada(moto);
            MessageBox.Show(mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

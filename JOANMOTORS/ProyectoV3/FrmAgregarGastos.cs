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
using BLL;


namespace ProyectoV3
{
    public partial class FrmAgregarGastos : Form
    {
        MotocicletasServiceDB servicio = new MotocicletasServiceDB();
        GastosServiceDB servicio2 = new GastosServiceDB();
        MotocicletasServiceDB MotocicletasServiceDB = new MotocicletasServiceDB();
        
 //       Motocicleta motocicleta;
        public FrmAgregarGastos()
        {
            InitializeComponent();
            ComboGastos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmAgregarGastos_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBuscar_CheckedChanged(object sender, EventArgs e)
        {
            Motocicleta motocicleta = new Motocicleta();
            FrmMotos Fm2 = new FrmMotos(ref motocicleta);
            Fm2.ShowDialog();
            motocicleta = MotocicletasServiceDB.BuscarMoto(motocicleta.Placa);
            TxtPlaca.Text = motocicleta.Placa;
            gastos.Motocicleta = motocicleta;
            gastos.Fecha = DateTime.Now;
        }
        Gastos gastos = new Gastos();
        private void Agregar()
        {

            //  gastos.Motocicleta.Placa = TxtPlaca.Text;
            gastos.Tipo = ComboGastos.SelectedItem.ToString();
            gastos.Objeto = TxtObjeto.Text;
            gastos.Pago = Convert.ToDouble(TxtPagado.Text);
            var Mensaje = servicio2.Guardar(gastos);
            MessageBox.Show(Mensaje, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        
    }
}

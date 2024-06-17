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
    public partial class FrmTarifaDiaria : Form
    {
        TarifaDiariaServiceDB TarifaDiariaService = new TarifaDiariaServiceDB();
        ConductoresServiceDB servicio = new ConductoresServiceDB();
        ConductoresServiceDB ConductoresServiceDB = new ConductoresServiceDB();
        public FrmTarifaDiaria()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTarifaDiaria_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            if (TxtTotalTarifa.Text != null)
            {
                if (Convert.ToDouble(TxtTotalTarifa.Text) >= Convert.ToDouble(TxtValorAPagar.Text))
                {
                    Conductor.Deuda = Convert.ToDouble(TxtTotalTarifa.Text) - Convert.ToDouble(TxtValorAPagar.Text);
                }
                else
                {
                    Conductor.Deuda = Convert.ToDouble(TxtValorAPagar.Text) - Convert.ToDouble(TxtTotalTarifa.Text);
                }
                TarifaDiaria.Pagado = Convert.ToDouble(TxtValorAPagar.Text);
                ConductoresServiceDB.ModificarDeuda(Conductor);
                var Mensaje = TarifaDiariaService.Guardar(TarifaDiaria);
                MessageBox.Show(Mensaje, "ADD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TxtValorAPagar.Text = new TarifaServiceDB().Buscar().Valor.ToString();
                if (Convert.ToDouble(TxtTotalTarifa.Text) >= Convert.ToDouble(TxtValorAPagar.Text))
                {
                    Conductor.Deuda = Convert.ToDouble(TxtTotalTarifa.Text) - Convert.ToDouble(TxtValorAPagar.Text);
                }
                else
                {
                    Conductor.Deuda = Convert.ToDouble(TxtValorAPagar.Text) - Convert.ToDouble(TxtTotalTarifa.Text);
                }
                TarifaDiaria.Pagado = Convert.ToDouble(TxtValorAPagar.Text);
                ConductoresServiceDB.ModificarDeuda(Conductor);
                TarifaDiariaService.Guardar(TarifaDiaria);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        Conductor Conductor = new Conductor();
        TarifaDiaria TarifaDiaria = new TarifaDiaria();
        private void CheckBuscar_CheckedChanged(object sender, EventArgs e)
        {
            
            FrmConductores Fm1 = new FrmConductores(ref Conductor);
            Fm1.ShowDialog();
            Conductor = ConductoresServiceDB.BuscarConductor(Conductor.Identificacion);
            TxtPlaca.Text = Conductor.Identificacion;
            TxtDeuda.Text = Conductor.Deuda.ToString();
            TxtTotalTarifa.Text = ((new TarifaServiceDB().Buscar().Valor) + Conductor.Deuda).ToString();
            
            TarifaDiaria.Conductor = Conductor;
            TarifaDiaria.Fecha = DateTime.Now;
            
            
        }
    }
}

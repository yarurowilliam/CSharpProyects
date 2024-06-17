using BLL;
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

namespace ProyectoV3
{
    public partial class FrmMotos : Form
    {
        MotocicletasServiceDB servicio = new MotocicletasServiceDB();
        Motocicleta MotocicletaS = new Motocicleta();
        public FrmMotos()
        {
            InitializeComponent();
        }
        public FrmMotos(ref Motocicleta motocicleta)
        {
            InitializeComponent();
            MotocicletaS = motocicleta;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MotocicletaS.Placa = ((Motocicleta)TablaMotocicletas.CurrentRow.DataBoundItem).Placa;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        public void Consultar()
        {
            TablaMotocicletas.DataSource = servicio.ConsultarTodos();
        }

    }
}

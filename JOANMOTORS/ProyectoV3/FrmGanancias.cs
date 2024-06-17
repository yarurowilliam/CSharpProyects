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
    public partial class FrmGanancias : Form
    {
        TarifaDiariaServiceDB servicio = new TarifaDiariaServiceDB();
        TarifaDiaria tarifa;
        public FrmGanancias()
        {
            InitializeComponent();
            //Consultar();
        }

        List<TarifaDiaria> listaTarifa = new List<TarifaDiaria>();

        public DataTable CreateTabla(List<TarifaDiaria> listaTarifa)
        {

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Identificacion");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Pagado");
            tabla.Columns.Add("Fecha");

            foreach (var liq in listaTarifa)
            {
                DataRow fila = tabla.NewRow();

                fila["Identificacion"] = liq.Conductor.Identificacion;
                fila["Nombre"] = liq.Conductor.Nombre;
                fila["Pagado"] = liq.Pagado;
                fila["Fecha"] = liq.Fecha;


                tabla.Rows.Add(fila);
            }
            return tabla;
        }




        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public void Consultar()
        {

            TablaGanancias.DataSource = CreateTabla(servicio.ConsultarTodos());
        }


        private void FrmGanancias_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}

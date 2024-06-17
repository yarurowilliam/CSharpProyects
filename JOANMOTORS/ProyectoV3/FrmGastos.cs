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
    public partial class FrmGastos : Form
    {
        GastosServiceDB servicio = new GastosServiceDB();
        Gastos gastos;
        public FrmGastos()
        {
            InitializeComponent();
            Consultar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGastos_Load(object sender, EventArgs e)
        {

        }
        //List<Gastos> listaGastos = new List<Gastos>();
        //public DataTable CreateTabla(List<Gastos> listaGastos)
        //{

        //    DataTable tabla = new DataTable();
        //    tabla.Columns.Add("Placa");
        //    tabla.Columns.Add("Tipo");
        //    tabla.Columns.Add("Objeto");
        //    tabla.Columns.Add("Fecha");

        //    foreach (var liq in listaGastos)
        //    {
        //        DataRow fila = tabla.NewRow();

        //        fila["Placa"] = liq.Motocicleta.Placa;
        //        fila["Tipo"] = liq.Conductor.Nombre;
        //        fila["Objeto"] = liq.Pagado;
        //        fila["Fecha"] = liq.Fecha;


        //        tabla.Rows.Add(fila);
        //    }
        //    return tabla;
        //}


        public void Consultar()
        {
            TablaGastos.DataSource = servicio.ConsultarTodos();
        }
    }
}

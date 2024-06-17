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
    
    public partial class FrmAgregarAsignacion : Form
    {
        MotocicletasServiceDB servicio = new MotocicletasServiceDB();
        Conductor conductor;
        public FrmAgregarAsignacion()
        {
            InitializeComponent();
        }


        private void Mostrar()
        {
            TablaAsignados.DataSource = CreateTabla(servicio.ConsultarAsignado());
        }

        public DataTable CreateTabla(List<Motocicleta> listaMotocicleta)
        {

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Identificacion");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Estado");
            tabla.Columns.Add("Placa");
            tabla.Columns.Add("Cilindraje");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("EstadoMoto");

            foreach (var liq in listaMotocicleta)
            {
                DataRow fila = tabla.NewRow();

                fila["Identificacion"] = liq.Conductor.Identificacion;
                fila["Nombre"] = liq.Conductor.Nombre;
                fila["Telefono"] = liq.Conductor.Telefono;
                fila["Direccion"] = liq.Conductor.Direccion;
                fila["Estado"] = liq.Conductor.Estado;
                fila["Placa"] = liq.Placa;
                fila["Cilindraje"] = liq.Cilindraje;
                fila["Modelo"] = liq.Modelo;
                fila["EstadoMoto"] = liq.Estado;

                tabla.Rows.Add(fila);
            }
            return tabla;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}

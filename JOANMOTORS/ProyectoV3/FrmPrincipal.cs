using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoV3
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
    
        
        public double Base {
            get
            {
                return Base;
            }
            set
            {
                MessageBox.Show("TARIFA AGREGADA CORRECTAMENTE");
                AbrirFormInPanel(new FrmInicio());
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg,int wparm , int lparm);

        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = false;
            AbrirFormInPanel(new FrmMotos());
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = false;
            AbrirFormInPanel(new FrmConductores());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            SubMenuAgregar.Visible = false;
            SubMenuFin.Visible = false;
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregarMoto_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = false;
            AbrirFormInPanel(new FrmAgregarMoto());
        }

        private void BtnAgregarConductor_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = false;
            AbrirFormInPanel(new FrmAgregarConductor());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = false;
            AbrirFormInPanel(new FrmAgregarTarifa());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = false;
            AbrirFormInPanel(new FrmAgregarGastos());
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = false;
            AbrirFormInPanel(new FrmInicio());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            SubMenuAgregar.Visible = false;
            AbrirFormInPanel(new FrmAgregarAsignacion());
        }

        private void BtnFinanzas_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = true;
            SubMenuAgregar.Visible = false;
        }

        private void BtnGanancias_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            AbrirFormInPanel(new FrmGanancias());
        }

        private void BtnGastos2_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            AbrirFormInPanel(new FrmGastos());
        }

        private void BtnChofer_Click(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            AbrirFormInPanel(new FrmChofer());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            AbrirFormInPanel(new FrmActualizarPapeles());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SubMenuFin.Visible = false;
            AbrirFormInPanel(new FrmTarifaDiaria());
        }

        private void SubMenuFin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblReloj_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
        }
    }
}

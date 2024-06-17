namespace ProyectoV3
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SubMenuAgregar = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.SubMenuFin = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.BtnExpandir = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnChofer = new System.Windows.Forms.Button();
            this.BtnGastos = new System.Windows.Forms.Button();
            this.BtnTarifa = new System.Windows.Forms.Button();
            this.BtnAgregarConductor = new System.Windows.Forms.Button();
            this.BtnAgregarMoto = new System.Windows.Forms.Button();
            this.BtnGastos2 = new System.Windows.Forms.Button();
            this.BtnGanancias = new System.Windows.Forms.Button();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.BtnFinanzas = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnConductores = new System.Windows.Forms.Button();
            this.BtnMotos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.SubMenuAgregar.SuspendLayout();
            this.SubMenuFin.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuVertical.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuVertical.Controls.Add(this.SubMenuAgregar);
            this.MenuVertical.Controls.Add(this.lblFecha);
            this.MenuVertical.Controls.Add(this.lblReloj);
            this.MenuVertical.Controls.Add(this.SubMenuFin);
            this.MenuVertical.Controls.Add(this.BtnConsultas);
            this.MenuVertical.Controls.Add(this.BtnFinanzas);
            this.MenuVertical.Controls.Add(this.BtnAgregar);
            this.MenuVertical.Controls.Add(this.BtnConductores);
            this.MenuVertical.Controls.Add(this.BtnMotos);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(247, 750);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // SubMenuAgregar
            // 
            this.SubMenuAgregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.SubMenuAgregar.Controls.Add(this.button2);
            this.SubMenuAgregar.Controls.Add(this.BtnChofer);
            this.SubMenuAgregar.Controls.Add(this.BtnGastos);
            this.SubMenuAgregar.Controls.Add(this.BtnTarifa);
            this.SubMenuAgregar.Controls.Add(this.BtnAgregarConductor);
            this.SubMenuAgregar.Controls.Add(this.BtnAgregarMoto);
            this.SubMenuAgregar.Location = new System.Drawing.Point(45, 338);
            this.SubMenuAgregar.Name = "SubMenuAgregar";
            this.SubMenuAgregar.Size = new System.Drawing.Size(227, 271);
            this.SubMenuAgregar.TabIndex = 5;
            this.SubMenuAgregar.Visible = false;
            this.SubMenuAgregar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFecha.Location = new System.Drawing.Point(3, 721);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(227, 20);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Miercoles, 10  noviembre  2017";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.Color.White;
            this.lblReloj.Location = new System.Drawing.Point(38, 682);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(151, 39);
            this.lblReloj.TabIndex = 11;
            this.lblReloj.Text = "00:00:00";
            this.lblReloj.Click += new System.EventHandler(this.lblReloj_Click);
            // 
            // SubMenuFin
            // 
            this.SubMenuFin.BackColor = System.Drawing.Color.MidnightBlue;
            this.SubMenuFin.Controls.Add(this.BtnGastos2);
            this.SubMenuFin.Controls.Add(this.BtnGanancias);
            this.SubMenuFin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SubMenuFin.Location = new System.Drawing.Point(45, 233);
            this.SubMenuFin.Name = "SubMenuFin";
            this.SubMenuFin.Size = new System.Drawing.Size(227, 86);
            this.SubMenuFin.TabIndex = 9;
            this.SubMenuFin.Visible = false;
            this.SubMenuFin.Paint += new System.Windows.Forms.PaintEventHandler(this.SubMenuFin_Paint);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.BarraTitulo.Controls.Add(this.IconMinimizar);
            this.BarraTitulo.Controls.Add(this.IconCerrar);
            this.BarraTitulo.Controls.Add(this.BtnExpandir);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(247, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1119, 38);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.MidnightBlue;
            this.PanelContenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(247, 38);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1119, 712);
            this.PanelContenedor.TabIndex = 2;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = global::ProyectoV3.Properties.Resources.icon_minimizar;
            this.IconMinimizar.Location = new System.Drawing.Point(1046, 6);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(23, 24);
            this.IconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMinimizar.TabIndex = 4;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = global::ProyectoV3.Properties.Resources.icon_cerrar2;
            this.IconCerrar.Location = new System.Drawing.Point(1075, 9);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(23, 21);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 1;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // BtnExpandir
            // 
            this.BtnExpandir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExpandir.Image = global::ProyectoV3.Properties.Resources.Mobile_Menu_Icon;
            this.BtnExpandir.Location = new System.Drawing.Point(6, 9);
            this.BtnExpandir.Name = "BtnExpandir";
            this.BtnExpandir.Size = new System.Drawing.Size(37, 29);
            this.BtnExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExpandir.TabIndex = 0;
            this.BtnExpandir.TabStop = false;
            this.BtnExpandir.Click += new System.EventHandler(this.BtnExpandir_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Image = global::ProyectoV3.Properties.Resources.fraudulent;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "T. Diaria";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtnChofer
            // 
            this.BtnChofer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnChofer.FlatAppearance.BorderSize = 0;
            this.BtnChofer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChofer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnChofer.Image = global::ProyectoV3.Properties.Resources.jacket;
            this.BtnChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChofer.Location = new System.Drawing.Point(0, 185);
            this.BtnChofer.Name = "BtnChofer";
            this.BtnChofer.Size = new System.Drawing.Size(205, 40);
            this.BtnChofer.TabIndex = 9;
            this.BtnChofer.Text = "Conductor";
            this.BtnChofer.UseVisualStyleBackColor = false;
            this.BtnChofer.Click += new System.EventHandler(this.BtnChofer_Click);
            // 
            // BtnGastos
            // 
            this.BtnGastos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnGastos.FlatAppearance.BorderSize = 0;
            this.BtnGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGastos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnGastos.Image = global::ProyectoV3.Properties.Resources.money;
            this.BtnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGastos.Location = new System.Drawing.Point(0, 139);
            this.BtnGastos.Name = "BtnGastos";
            this.BtnGastos.Size = new System.Drawing.Size(205, 40);
            this.BtnGastos.TabIndex = 8;
            this.BtnGastos.Text = "Gastos";
            this.BtnGastos.UseVisualStyleBackColor = false;
            this.BtnGastos.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnTarifa
            // 
            this.BtnTarifa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnTarifa.FlatAppearance.BorderSize = 0;
            this.BtnTarifa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarifa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnTarifa.Image = global::ProyectoV3.Properties.Resources.envelope;
            this.BtnTarifa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTarifa.Location = new System.Drawing.Point(0, 93);
            this.BtnTarifa.Name = "BtnTarifa";
            this.BtnTarifa.Size = new System.Drawing.Size(208, 40);
            this.BtnTarifa.TabIndex = 7;
            this.BtnTarifa.Text = "Tarifa";
            this.BtnTarifa.UseVisualStyleBackColor = false;
            this.BtnTarifa.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnAgregarConductor
            // 
            this.BtnAgregarConductor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnAgregarConductor.FlatAppearance.BorderSize = 0;
            this.BtnAgregarConductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAgregarConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarConductor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnAgregarConductor.Image = global::ProyectoV3.Properties.Resources.helmet;
            this.BtnAgregarConductor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarConductor.Location = new System.Drawing.Point(0, 47);
            this.BtnAgregarConductor.Name = "BtnAgregarConductor";
            this.BtnAgregarConductor.Size = new System.Drawing.Size(205, 40);
            this.BtnAgregarConductor.TabIndex = 6;
            this.BtnAgregarConductor.Text = "Persona";
            this.BtnAgregarConductor.UseVisualStyleBackColor = false;
            this.BtnAgregarConductor.Click += new System.EventHandler(this.BtnAgregarConductor_Click);
            // 
            // BtnAgregarMoto
            // 
            this.BtnAgregarMoto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnAgregarMoto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarMoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAgregarMoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarMoto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnAgregarMoto.Image = global::ProyectoV3.Properties.Resources.motop;
            this.BtnAgregarMoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarMoto.Location = new System.Drawing.Point(0, 0);
            this.BtnAgregarMoto.Name = "BtnAgregarMoto";
            this.BtnAgregarMoto.Size = new System.Drawing.Size(205, 41);
            this.BtnAgregarMoto.TabIndex = 6;
            this.BtnAgregarMoto.Text = "Motos";
            this.BtnAgregarMoto.UseVisualStyleBackColor = false;
            this.BtnAgregarMoto.Click += new System.EventHandler(this.BtnAgregarMoto_Click);
            // 
            // BtnGastos2
            // 
            this.BtnGastos2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnGastos2.FlatAppearance.BorderSize = 0;
            this.BtnGastos2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnGastos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGastos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGastos2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnGastos2.Image = global::ProyectoV3.Properties.Resources.forbidden;
            this.BtnGastos2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGastos2.Location = new System.Drawing.Point(0, 46);
            this.BtnGastos2.Name = "BtnGastos2";
            this.BtnGastos2.Size = new System.Drawing.Size(205, 40);
            this.BtnGastos2.TabIndex = 8;
            this.BtnGastos2.Text = "Gastos";
            this.BtnGastos2.UseVisualStyleBackColor = false;
            this.BtnGastos2.Click += new System.EventHandler(this.BtnGastos2_Click);
            // 
            // BtnGanancias
            // 
            this.BtnGanancias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnGanancias.FlatAppearance.BorderSize = 0;
            this.BtnGanancias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGanancias.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnGanancias.Image = global::ProyectoV3.Properties.Resources.baggage;
            this.BtnGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGanancias.Location = new System.Drawing.Point(0, 0);
            this.BtnGanancias.Name = "BtnGanancias";
            this.BtnGanancias.Size = new System.Drawing.Size(205, 40);
            this.BtnGanancias.TabIndex = 7;
            this.BtnGanancias.Text = "Ganancias";
            this.BtnGanancias.UseVisualStyleBackColor = false;
            this.BtnGanancias.Click += new System.EventHandler(this.BtnGanancias_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.FlatAppearance.BorderSize = 0;
            this.BtnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConsultas.Image = global::ProyectoV3.Properties.Resources.effective;
            this.BtnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.Location = new System.Drawing.Point(0, 243);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(250, 40);
            this.BtnConsultas.TabIndex = 4;
            this.BtnConsultas.Text = "Asignaciones";
            this.BtnConsultas.UseVisualStyleBackColor = true;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // BtnFinanzas
            // 
            this.BtnFinanzas.FlatAppearance.BorderSize = 0;
            this.BtnFinanzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinanzas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFinanzas.Image = global::ProyectoV3.Properties.Resources.creative;
            this.BtnFinanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanzas.Location = new System.Drawing.Point(0, 197);
            this.BtnFinanzas.Name = "BtnFinanzas";
            this.BtnFinanzas.Size = new System.Drawing.Size(250, 40);
            this.BtnFinanzas.TabIndex = 2;
            this.BtnFinanzas.Text = "Finanzas";
            this.BtnFinanzas.UseVisualStyleBackColor = true;
            this.BtnFinanzas.Click += new System.EventHandler(this.BtnFinanzas_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgregar.Image = global::ProyectoV3.Properties.Resources.connection;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(3, 289);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(250, 40);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnConductores
            // 
            this.BtnConductores.FlatAppearance.BorderSize = 0;
            this.BtnConductores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConductores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConductores.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnConductores.Image = global::ProyectoV3.Properties.Resources.helmet;
            this.BtnConductores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConductores.Location = new System.Drawing.Point(0, 151);
            this.BtnConductores.Name = "BtnConductores";
            this.BtnConductores.Size = new System.Drawing.Size(250, 40);
            this.BtnConductores.TabIndex = 2;
            this.BtnConductores.Text = "Conductores";
            this.BtnConductores.UseVisualStyleBackColor = true;
            this.BtnConductores.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnMotos
            // 
            this.BtnMotos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMotos.FlatAppearance.BorderSize = 0;
            this.BtnMotos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnMotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMotos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMotos.Image = ((System.Drawing.Image)(resources.GetObject("BtnMotos.Image")));
            this.BtnMotos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMotos.Location = new System.Drawing.Point(3, 105);
            this.BtnMotos.Name = "BtnMotos";
            this.BtnMotos.Size = new System.Drawing.Size(247, 40);
            this.BtnMotos.TabIndex = 1;
            this.BtnMotos.Text = "Motos";
            this.BtnMotos.UseVisualStyleBackColor = true;
            this.BtnMotos.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoV3.Properties.Resources.Sin_título_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::ProyectoV3.Properties.Resources.speedometer;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1366, 750);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Resize += new System.EventHandler(this.FrmPrincipal_Resize);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.SubMenuAgregar.ResumeLayout(false);
            this.SubMenuFin.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BtnExpandir;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.Button BtnMotos;
        private System.Windows.Forms.Button BtnConductores;
        private System.Windows.Forms.Button BtnFinanzas;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Panel SubMenuAgregar;
        private System.Windows.Forms.Button BtnAgregarConductor;
        private System.Windows.Forms.Button BtnAgregarMoto;
        private System.Windows.Forms.Button BtnGastos;
        private System.Windows.Forms.Button BtnTarifa;
        private System.Windows.Forms.Panel SubMenuFin;
        private System.Windows.Forms.Button BtnGastos2;
        private System.Windows.Forms.Button BtnGanancias;
        private System.Windows.Forms.Button BtnChofer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}


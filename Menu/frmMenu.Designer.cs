namespace Proyecto.Menu
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTituloFormHijo = new System.Windows.Forms.Label();
            this.picHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picBarra = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.btnRestauracion = new FontAwesome.Sharp.IconButton();
            this.pnlSubCentroAtencion = new System.Windows.Forms.Panel();
            this.btnAsistenciaFamiliar = new FontAwesome.Sharp.IconButton();
            this.btnReporte = new FontAwesome.Sharp.IconButton();
            this.btnIncidencias = new FontAwesome.Sharp.IconButton();
            this.btnCentroAtencion = new FontAwesome.Sharp.IconButton();
            this.pnlSubMaestros = new System.Windows.Forms.Panel();
            this.btnAlumnos = new FontAwesome.Sharp.IconButton();
            this.btnMaestros = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.pnlSubInventario = new System.Windows.Forms.Panel();
            this.btnCatalogo = new FontAwesome.Sharp.IconButton();
            this.btnSalidas = new FontAwesome.Sharp.IconButton();
            this.btnEntradas = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnDonadores = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.pnlSubPersonal = new System.Windows.Forms.Panel();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnPersonal = new FontAwesome.Sharp.IconButton();
            this.pnlSubBiblioteca = new System.Windows.Forms.Panel();
            this.btnDevoluciones = new FontAwesome.Sharp.IconButton();
            this.btnPrestamos = new FontAwesome.Sharp.IconButton();
            this.btnLibros = new FontAwesome.Sharp.IconButton();
            this.btnBiblioteca = new FontAwesome.Sharp.IconButton();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHijoActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMenuVertical.SuspendLayout();
            this.pnlSubCentroAtencion.SuspendLayout();
            this.pnlSubMaestros.SuspendLayout();
            this.pnlSubInventario.SuspendLayout();
            this.pnlSubPersonal.SuspendLayout();
            this.pnlSubBiblioteca.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlTitulo.Controls.Add(this.picMinimizar);
            this.pnlTitulo.Controls.Add(this.lblTituloFormHijo);
            this.pnlTitulo.Controls.Add(this.picHijoActual);
            this.pnlTitulo.Controls.Add(this.picCerrar);
            this.pnlTitulo.Controls.Add(this.picBarra);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(250, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(750, 32);
            this.pnlTitulo.TabIndex = 30;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = global::Proyecto.Properties.Resources.min;
            this.picMinimizar.Location = new System.Drawing.Point(686, 0);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(26, 32);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 5;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // lblTituloFormHijo
            // 
            this.lblTituloFormHijo.AutoSize = true;
            this.lblTituloFormHijo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormHijo.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblTituloFormHijo.Location = new System.Drawing.Point(69, 9);
            this.lblTituloFormHijo.Name = "lblTituloFormHijo";
            this.lblTituloFormHijo.Size = new System.Drawing.Size(41, 18);
            this.lblTituloFormHijo.TabIndex = 4;
            this.lblTituloFormHijo.Text = "Home";
            // 
            // picHijoActual
            // 
            this.picHijoActual.BackColor = System.Drawing.Color.SlateBlue;
            this.picHijoActual.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.picHijoActual.IconChar = FontAwesome.Sharp.IconChar.House;
            this.picHijoActual.IconColor = System.Drawing.Color.LightSteelBlue;
            this.picHijoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picHijoActual.IconSize = 24;
            this.picHijoActual.Location = new System.Drawing.Point(39, 4);
            this.picHijoActual.Name = "picHijoActual";
            this.picHijoActual.Size = new System.Drawing.Size(24, 25);
            this.picHijoActual.TabIndex = 3;
            this.picHijoActual.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::Proyecto.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(716, 0);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(27, 32);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 1;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // picBarra
            // 
            this.picBarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBarra.Image = global::Proyecto.Properties.Resources.barra5;
            this.picBarra.Location = new System.Drawing.Point(6, 3);
            this.picBarra.Name = "picBarra";
            this.picBarra.Size = new System.Drawing.Size(26, 29);
            this.picBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBarra.TabIndex = 0;
            this.picBarra.TabStop = false;
            this.picBarra.Click += new System.EventHandler(this.picBarra_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(233, 92);
            this.pnlLogo.TabIndex = 38;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::Proyecto.Properties.Resources.LogoEducarte;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 101);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.AutoScroll = true;
            this.pnlMenuVertical.BackColor = System.Drawing.Color.SlateBlue;
            this.pnlMenuVertical.Controls.Add(this.btnRestauracion);
            this.pnlMenuVertical.Controls.Add(this.pnlSubCentroAtencion);
            this.pnlMenuVertical.Controls.Add(this.btnCentroAtencion);
            this.pnlMenuVertical.Controls.Add(this.pnlSubMaestros);
            this.pnlMenuVertical.Controls.Add(this.btnMaestros);
            this.pnlMenuVertical.Controls.Add(this.btnCerrarSesion);
            this.pnlMenuVertical.Controls.Add(this.pnlSubInventario);
            this.pnlMenuVertical.Controls.Add(this.btnInventario);
            this.pnlMenuVertical.Controls.Add(this.btnDonadores);
            this.pnlMenuVertical.Controls.Add(this.btnClientes);
            this.pnlMenuVertical.Controls.Add(this.pnlSubPersonal);
            this.pnlMenuVertical.Controls.Add(this.btnPersonal);
            this.pnlMenuVertical.Controls.Add(this.pnlSubBiblioteca);
            this.pnlMenuVertical.Controls.Add(this.btnBiblioteca);
            this.pnlMenuVertical.Controls.Add(this.pnlLogo);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(250, 732);
            this.pnlMenuVertical.TabIndex = 29;
            // 
            // btnRestauracion
            // 
            this.btnRestauracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestauracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestauracion.FlatAppearance.BorderSize = 0;
            this.btnRestauracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestauracion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestauracion.ForeColor = System.Drawing.Color.White;
            this.btnRestauracion.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnRestauracion.IconColor = System.Drawing.Color.White;
            this.btnRestauracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestauracion.IconSize = 35;
            this.btnRestauracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestauracion.Location = new System.Drawing.Point(0, 781);
            this.btnRestauracion.Name = "btnRestauracion";
            this.btnRestauracion.Size = new System.Drawing.Size(233, 35);
            this.btnRestauracion.TabIndex = 54;
            this.btnRestauracion.Text = "Restauracion";
            this.btnRestauracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestauracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestauracion.UseVisualStyleBackColor = true;
            this.btnRestauracion.Click += new System.EventHandler(this.btnRestauracion_Click);
            // 
            // pnlSubCentroAtencion
            // 
            this.pnlSubCentroAtencion.Controls.Add(this.btnAsistenciaFamiliar);
            this.pnlSubCentroAtencion.Controls.Add(this.btnReporte);
            this.pnlSubCentroAtencion.Controls.Add(this.btnIncidencias);
            this.pnlSubCentroAtencion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubCentroAtencion.Location = new System.Drawing.Point(0, 677);
            this.pnlSubCentroAtencion.Name = "pnlSubCentroAtencion";
            this.pnlSubCentroAtencion.Size = new System.Drawing.Size(233, 104);
            this.pnlSubCentroAtencion.TabIndex = 53;
            // 
            // btnAsistenciaFamiliar
            // 
            this.btnAsistenciaFamiliar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAsistenciaFamiliar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistenciaFamiliar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistenciaFamiliar.FlatAppearance.BorderSize = 0;
            this.btnAsistenciaFamiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaFamiliar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaFamiliar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAsistenciaFamiliar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAsistenciaFamiliar.IconColor = System.Drawing.Color.White;
            this.btnAsistenciaFamiliar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsistenciaFamiliar.IconSize = 35;
            this.btnAsistenciaFamiliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistenciaFamiliar.Location = new System.Drawing.Point(0, 70);
            this.btnAsistenciaFamiliar.Name = "btnAsistenciaFamiliar";
            this.btnAsistenciaFamiliar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAsistenciaFamiliar.Size = new System.Drawing.Size(233, 35);
            this.btnAsistenciaFamiliar.TabIndex = 44;
            this.btnAsistenciaFamiliar.Text = "Asistencia Familiar";
            this.btnAsistenciaFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistenciaFamiliar.UseVisualStyleBackColor = false;
            this.btnAsistenciaFamiliar.Click += new System.EventHandler(this.btnAsistenciaFamiliar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReporte.IconColor = System.Drawing.Color.White;
            this.btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporte.IconSize = 35;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 35);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReporte.Size = new System.Drawing.Size(233, 35);
            this.btnReporte.TabIndex = 43;
            this.btnReporte.Text = "Reporte Semanal";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIncidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncidencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncidencias.FlatAppearance.BorderSize = 0;
            this.btnIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidencias.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidencias.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIncidencias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIncidencias.IconColor = System.Drawing.Color.White;
            this.btnIncidencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIncidencias.IconSize = 35;
            this.btnIncidencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncidencias.Location = new System.Drawing.Point(0, 0);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIncidencias.Size = new System.Drawing.Size(233, 35);
            this.btnIncidencias.TabIndex = 42;
            this.btnIncidencias.Text = "Incidencias";
            this.btnIncidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncidencias.UseVisualStyleBackColor = false;
            this.btnIncidencias.Click += new System.EventHandler(this.btnIncidencias_Click);
            // 
            // btnCentroAtencion
            // 
            this.btnCentroAtencion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCentroAtencion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCentroAtencion.FlatAppearance.BorderSize = 0;
            this.btnCentroAtencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentroAtencion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentroAtencion.ForeColor = System.Drawing.Color.White;
            this.btnCentroAtencion.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHeart;
            this.btnCentroAtencion.IconColor = System.Drawing.Color.White;
            this.btnCentroAtencion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCentroAtencion.IconSize = 35;
            this.btnCentroAtencion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentroAtencion.Location = new System.Drawing.Point(0, 642);
            this.btnCentroAtencion.Name = "btnCentroAtencion";
            this.btnCentroAtencion.Size = new System.Drawing.Size(233, 35);
            this.btnCentroAtencion.TabIndex = 52;
            this.btnCentroAtencion.Text = "Centro de Atención";
            this.btnCentroAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentroAtencion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCentroAtencion.UseVisualStyleBackColor = true;
            this.btnCentroAtencion.Click += new System.EventHandler(this.btnCentroAtencion_Click);
            // 
            // pnlSubMaestros
            // 
            this.pnlSubMaestros.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSubMaestros.Controls.Add(this.btnAlumnos);
            this.pnlSubMaestros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMaestros.Location = new System.Drawing.Point(0, 603);
            this.pnlSubMaestros.Name = "pnlSubMaestros";
            this.pnlSubMaestros.Size = new System.Drawing.Size(233, 39);
            this.pnlSubMaestros.TabIndex = 51;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAlumnos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAlumnos.IconColor = System.Drawing.Color.White;
            this.btnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlumnos.IconSize = 35;
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 0);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAlumnos.Size = new System.Drawing.Size(233, 35);
            this.btnAlumnos.TabIndex = 41;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnMaestros
            // 
            this.btnMaestros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaestros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaestros.FlatAppearance.BorderSize = 0;
            this.btnMaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaestros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaestros.ForeColor = System.Drawing.Color.White;
            this.btnMaestros.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnMaestros.IconColor = System.Drawing.Color.White;
            this.btnMaestros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaestros.IconSize = 35;
            this.btnMaestros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaestros.Location = new System.Drawing.Point(0, 568);
            this.btnMaestros.Name = "btnMaestros";
            this.btnMaestros.Size = new System.Drawing.Size(233, 35);
            this.btnMaestros.TabIndex = 50;
            this.btnMaestros.Text = "Maestros";
            this.btnMaestros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaestros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaestros.UseVisualStyleBackColor = true;
            this.btnMaestros.Click += new System.EventHandler(this.btnMaestros_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 35;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 816);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(0, 0, 76, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(233, 35);
            this.btnCerrarSesion.TabIndex = 49;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlSubInventario
            // 
            this.pnlSubInventario.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSubInventario.Controls.Add(this.btnCatalogo);
            this.pnlSubInventario.Controls.Add(this.btnSalidas);
            this.pnlSubInventario.Controls.Add(this.btnEntradas);
            this.pnlSubInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubInventario.Location = new System.Drawing.Point(0, 456);
            this.pnlSubInventario.Name = "pnlSubInventario";
            this.pnlSubInventario.Size = new System.Drawing.Size(233, 112);
            this.pnlSubInventario.TabIndex = 46;
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogo.FlatAppearance.BorderSize = 0;
            this.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCatalogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCatalogo.IconColor = System.Drawing.Color.White;
            this.btnCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatalogo.IconSize = 35;
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.Location = new System.Drawing.Point(0, 70);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCatalogo.Size = new System.Drawing.Size(233, 35);
            this.btnCatalogo.TabIndex = 42;
            this.btnCatalogo.Text = "Catálogo";
            this.btnCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalidas.FlatAppearance.BorderSize = 0;
            this.btnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalidas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSalidas.IconColor = System.Drawing.Color.White;
            this.btnSalidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalidas.IconSize = 35;
            this.btnSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidas.Location = new System.Drawing.Point(0, 35);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSalidas.Size = new System.Drawing.Size(233, 35);
            this.btnSalidas.TabIndex = 41;
            this.btnSalidas.Text = "Salidas";
            this.btnSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEntradas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEntradas.IconColor = System.Drawing.Color.White;
            this.btnEntradas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntradas.IconSize = 35;
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.Location = new System.Drawing.Point(0, 0);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEntradas.Size = new System.Drawing.Size(233, 35);
            this.btnEntradas.TabIndex = 40;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnInventario.IconColor = System.Drawing.Color.White;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 35;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 421);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(233, 35);
            this.btnInventario.TabIndex = 39;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnDonadores
            // 
            this.btnDonadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonadores.FlatAppearance.BorderSize = 0;
            this.btnDonadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonadores.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonadores.ForeColor = System.Drawing.Color.White;
            this.btnDonadores.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnDonadores.IconColor = System.Drawing.Color.White;
            this.btnDonadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDonadores.IconSize = 35;
            this.btnDonadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonadores.Location = new System.Drawing.Point(0, 386);
            this.btnDonadores.Name = "btnDonadores";
            this.btnDonadores.Size = new System.Drawing.Size(233, 35);
            this.btnDonadores.TabIndex = 39;
            this.btnDonadores.Text = "Donadores";
            this.btnDonadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonadores.UseVisualStyleBackColor = true;
            this.btnDonadores.Click += new System.EventHandler(this.btnDonadores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 35;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 351);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(233, 35);
            this.btnClientes.TabIndex = 39;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlSubPersonal
            // 
            this.pnlSubPersonal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSubPersonal.Controls.Add(this.btnUsuarios);
            this.pnlSubPersonal.Controls.Add(this.btnEmpleados);
            this.pnlSubPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubPersonal.Location = new System.Drawing.Point(0, 274);
            this.pnlSubPersonal.Name = "pnlSubPersonal";
            this.pnlSubPersonal.Size = new System.Drawing.Size(233, 77);
            this.pnlSubPersonal.TabIndex = 42;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 35;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 35);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(233, 35);
            this.btnUsuarios.TabIndex = 41;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 35;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(233, 35);
            this.btnEmpleados.TabIndex = 40;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnPersonal.IconColor = System.Drawing.Color.White;
            this.btnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonal.IconSize = 35;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 239);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(233, 35);
            this.btnPersonal.TabIndex = 39;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // pnlSubBiblioteca
            // 
            this.pnlSubBiblioteca.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlSubBiblioteca.Controls.Add(this.btnDevoluciones);
            this.pnlSubBiblioteca.Controls.Add(this.btnPrestamos);
            this.pnlSubBiblioteca.Controls.Add(this.btnLibros);
            this.pnlSubBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubBiblioteca.Location = new System.Drawing.Point(0, 127);
            this.pnlSubBiblioteca.Name = "pnlSubBiblioteca";
            this.pnlSubBiblioteca.Size = new System.Drawing.Size(233, 112);
            this.pnlSubBiblioteca.TabIndex = 40;
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDevoluciones.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDevoluciones.IconColor = System.Drawing.Color.White;
            this.btnDevoluciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevoluciones.IconSize = 35;
            this.btnDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevoluciones.Location = new System.Drawing.Point(0, 70);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDevoluciones.Size = new System.Drawing.Size(233, 35);
            this.btnDevoluciones.TabIndex = 42;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrestamos.IconColor = System.Drawing.Color.White;
            this.btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrestamos.IconSize = 35;
            this.btnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 35);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPrestamos.Size = new System.Drawing.Size(233, 35);
            this.btnPrestamos.TabIndex = 41;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLibros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLibros.IconColor = System.Drawing.Color.White;
            this.btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibros.IconSize = 35;
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.Location = new System.Drawing.Point(0, 0);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLibros.Size = new System.Drawing.Size(233, 35);
            this.btnLibros.TabIndex = 40;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click_1);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.ForeColor = System.Drawing.Color.White;
            this.btnBiblioteca.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBiblioteca.IconColor = System.Drawing.Color.White;
            this.btnBiblioteca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBiblioteca.IconSize = 35;
            this.btnBiblioteca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteca.Location = new System.Drawing.Point(0, 92);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(233, 35);
            this.btnBiblioteca.TabIndex = 39;
            this.btnBiblioteca.Text = "Biblioteca";
            this.btnBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(250, 32);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(750, 700);
            this.pnlControl.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(282, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 732);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHijoActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarra)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMenuVertical.ResumeLayout(false);
            this.pnlSubCentroAtencion.ResumeLayout(false);
            this.pnlSubMaestros.ResumeLayout(false);
            this.pnlSubInventario.ResumeLayout(false);
            this.pnlSubPersonal.ResumeLayout(false);
            this.pnlSubBiblioteca.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox picBarra;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private FontAwesome.Sharp.IconButton btnBiblioteca;
        private System.Windows.Forms.Panel pnlSubPersonal;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private FontAwesome.Sharp.IconButton btnPersonal;
        private System.Windows.Forms.Panel pnlSubBiblioteca;
        private FontAwesome.Sharp.IconButton btnDevoluciones;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnLibros;
        private System.Windows.Forms.Panel pnlSubInventario;
        private FontAwesome.Sharp.IconButton btnCatalogo;
        private FontAwesome.Sharp.IconButton btnSalidas;
        private FontAwesome.Sharp.IconButton btnEntradas;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnDonadores;
        private FontAwesome.Sharp.IconButton btnClientes;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox picHijoActual;
        private System.Windows.Forms.Label lblTituloFormHijo;
        private System.Windows.Forms.Panel pnlSubCentroAtencion;
        private FontAwesome.Sharp.IconButton btnAsistenciaFamiliar;
        private FontAwesome.Sharp.IconButton btnReporte;
        private FontAwesome.Sharp.IconButton btnIncidencias;
        private FontAwesome.Sharp.IconButton btnCentroAtencion;
        private System.Windows.Forms.Panel pnlSubMaestros;
        private FontAwesome.Sharp.IconButton btnAlumnos;
        private FontAwesome.Sharp.IconButton btnMaestros;
        private FontAwesome.Sharp.IconButton btnRestauracion;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.PictureBox picMinimizar;
    }
}
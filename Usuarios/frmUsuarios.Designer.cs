namespace Proyecto.Usuarios
{
    partial class frmUsuarios
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
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picMaximizar = new System.Windows.Forms.PictureBox();
            this.picRestaurar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.TextBox();
            this.cbxBiblioteca = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxInventario = new MaterialSkin.Controls.MaterialCheckbox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.lblUsuarios = new System.Windows.Forms.TextBox();
            this.picUsuarios = new System.Windows.Forms.PictureBox();
            this.txtDniEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDniEmpleado = new System.Windows.Forms.TextBox();
            this.txtPermisos = new System.Windows.Forms.TextBox();
            this.cbxEncargado = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxAdmin = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbxBusqueda = new MaterialSkin.Controls.MaterialComboBox();
            this.txtConsultar = new MaterialSkin.Controls.MaterialTextBox();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.pnlUsuario.Controls.Add(this.picAtras);
            this.pnlUsuario.Controls.Add(this.picMaximizar);
            this.pnlUsuario.Controls.Add(this.picRestaurar);
            this.pnlUsuario.Controls.Add(this.picMinimizar);
            this.pnlUsuario.Controls.Add(this.picCerrar);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(1180, 24);
            this.pnlUsuario.TabIndex = 0;
            // 
            // picAtras
            // 
            this.picAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAtras.Image = global::Proyecto.Properties.Resources.atras;
            this.picAtras.Location = new System.Drawing.Point(6, 4);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(24, 17);
            this.picAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtras.TabIndex = 8;
            this.picAtras.TabStop = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // picMaximizar
            // 
            this.picMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMaximizar.Image = global::Proyecto.Properties.Resources.max;
            this.picMaximizar.Location = new System.Drawing.Point(1112, 3);
            this.picMaximizar.Name = "picMaximizar";
            this.picMaximizar.Size = new System.Drawing.Size(25, 19);
            this.picMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaximizar.TabIndex = 5;
            this.picMaximizar.TabStop = false;
            this.picMaximizar.Click += new System.EventHandler(this.picMaximizar_Click);
            // 
            // picRestaurar
            // 
            this.picRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRestaurar.Image = global::Proyecto.Properties.Resources._159699;
            this.picRestaurar.Location = new System.Drawing.Point(1112, 3);
            this.picRestaurar.Name = "picRestaurar";
            this.picRestaurar.Size = new System.Drawing.Size(25, 19);
            this.picRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestaurar.TabIndex = 7;
            this.picRestaurar.TabStop = false;
            this.picRestaurar.Click += new System.EventHandler(this.picRestaurar_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = global::Proyecto.Properties.Resources.min;
            this.picMinimizar.Location = new System.Drawing.Point(1081, 3);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(25, 19);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 6;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::Proyecto.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(1143, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(25, 19);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 4;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(42, 247);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(202, 23);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxBiblioteca
            // 
            this.cbxBiblioteca.AutoSize = true;
            this.cbxBiblioteca.Depth = 0;
            this.cbxBiblioteca.Location = new System.Drawing.Point(72, 517);
            this.cbxBiblioteca.Margin = new System.Windows.Forms.Padding(0);
            this.cbxBiblioteca.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxBiblioteca.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxBiblioteca.Name = "cbxBiblioteca";
            this.cbxBiblioteca.ReadOnly = false;
            this.cbxBiblioteca.Ripple = true;
            this.cbxBiblioteca.Size = new System.Drawing.Size(105, 37);
            this.cbxBiblioteca.TabIndex = 17;
            this.cbxBiblioteca.Text = "Biblioteca";
            this.cbxBiblioteca.UseVisualStyleBackColor = true;
            this.cbxBiblioteca.CheckedChanged += new System.EventHandler(this.cbxBiblioteca_CheckedChanged);
            // 
            // cbxInventario
            // 
            this.cbxInventario.AutoSize = true;
            this.cbxInventario.Depth = 0;
            this.cbxInventario.Location = new System.Drawing.Point(72, 554);
            this.cbxInventario.Margin = new System.Windows.Forms.Padding(0);
            this.cbxInventario.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxInventario.Name = "cbxInventario";
            this.cbxInventario.ReadOnly = false;
            this.cbxInventario.Ripple = true;
            this.cbxInventario.Size = new System.Drawing.Size(105, 37);
            this.cbxInventario.TabIndex = 18;
            this.cbxInventario.Text = "Inventario";
            this.cbxInventario.UseVisualStyleBackColor = true;
            this.cbxInventario.CheckedChanged += new System.EventHandler(this.cbxInventario_CheckedChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(509, 114);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(628, 494);
            this.dgvUsuarios.TabIndex = 19;
            // 
            // lblContraseña
            // 
            this.lblContraseña.BackColor = System.Drawing.Color.White;
            this.lblContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblContraseña.Enabled = false;
            this.lblContraseña.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(158, 332);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(202, 23);
            this.lblContraseña.TabIndex = 22;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContraseña
            // 
            this.txtContraseña.AnimateReadOnly = false;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.LeadingIcon = null;
            this.txtContraseña.Location = new System.Drawing.Point(158, 361);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(202, 50);
            this.txtContraseña.TabIndex = 21;
            this.txtContraseña.Text = "";
            this.txtContraseña.TrailingIcon = null;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = false;
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.HighEmphasis = true;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(297, 432);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(158, 36);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = false;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = null;
            this.btnModificar.Location = new System.Drawing.Point(297, 506);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(158, 36);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(297, 580);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(158, 36);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(42, 276);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 50);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarios.BackColor = System.Drawing.Color.White;
            this.lblUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUsuarios.Enabled = false;
            this.lblUsuarios.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(158, 51);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(202, 45);
            this.lblUsuarios.TabIndex = 29;
            this.lblUsuarios.Text = "Usuarios";
            this.lblUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picUsuarios
            // 
            this.picUsuarios.Enabled = false;
            this.picUsuarios.Image = global::Proyecto.Properties.Resources._327527;
            this.picUsuarios.Location = new System.Drawing.Point(188, 114);
            this.picUsuarios.Name = "picUsuarios";
            this.picUsuarios.Size = new System.Drawing.Size(145, 114);
            this.picUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuarios.TabIndex = 20;
            this.picUsuarios.TabStop = false;
            // 
            // txtDniEmpleado
            // 
            this.txtDniEmpleado.AnimateReadOnly = false;
            this.txtDniEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDniEmpleado.Depth = 0;
            this.txtDniEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDniEmpleado.LeadingIcon = null;
            this.txtDniEmpleado.Location = new System.Drawing.Point(255, 276);
            this.txtDniEmpleado.MaxLength = 50;
            this.txtDniEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDniEmpleado.Multiline = false;
            this.txtDniEmpleado.Name = "txtDniEmpleado";
            this.txtDniEmpleado.Size = new System.Drawing.Size(202, 50);
            this.txtDniEmpleado.TabIndex = 31;
            this.txtDniEmpleado.Text = "";
            this.txtDniEmpleado.TrailingIcon = null;
            // 
            // lblDniEmpleado
            // 
            this.lblDniEmpleado.BackColor = System.Drawing.Color.White;
            this.lblDniEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDniEmpleado.Enabled = false;
            this.lblDniEmpleado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniEmpleado.Location = new System.Drawing.Point(255, 247);
            this.lblDniEmpleado.Name = "lblDniEmpleado";
            this.lblDniEmpleado.Size = new System.Drawing.Size(202, 23);
            this.lblDniEmpleado.TabIndex = 30;
            this.lblDniEmpleado.Text = "DNI Empleado";
            this.lblDniEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPermisos
            // 
            this.txtPermisos.BackColor = System.Drawing.Color.White;
            this.txtPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPermisos.Enabled = false;
            this.txtPermisos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermisos.Location = new System.Drawing.Point(28, 417);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(182, 23);
            this.txtPermisos.TabIndex = 34;
            this.txtPermisos.Text = "Permisos de los usuarios";
            this.txtPermisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxEncargado
            // 
            this.cbxEncargado.AutoSize = true;
            this.cbxEncargado.Depth = 0;
            this.cbxEncargado.Location = new System.Drawing.Point(42, 480);
            this.cbxEncargado.Margin = new System.Windows.Forms.Padding(0);
            this.cbxEncargado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxEncargado.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxEncargado.Name = "cbxEncargado";
            this.cbxEncargado.ReadOnly = false;
            this.cbxEncargado.Ripple = true;
            this.cbxEncargado.Size = new System.Drawing.Size(111, 37);
            this.cbxEncargado.TabIndex = 35;
            this.cbxEncargado.Text = "Encargado";
            this.cbxEncargado.UseVisualStyleBackColor = true;
            this.cbxEncargado.CheckedChanged += new System.EventHandler(this.cbxEmpleado_CheckedChanged);
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Depth = 0;
            this.cbxAdmin.Location = new System.Drawing.Point(42, 443);
            this.cbxAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.cbxAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.ReadOnly = false;
            this.cbxAdmin.Ripple = true;
            this.cbxAdmin.Size = new System.Drawing.Size(135, 37);
            this.cbxAdmin.TabIndex = 36;
            this.cbxAdmin.Text = "Administrador";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            this.cbxAdmin.CheckedChanged += new System.EventHandler(this.cbxAdmin_CheckedChanged_1);
            // 
            // cbxBusqueda
            // 
            this.cbxBusqueda.AutoResize = false;
            this.cbxBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxBusqueda.Depth = 0;
            this.cbxBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxBusqueda.DropDownHeight = 174;
            this.cbxBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBusqueda.DropDownWidth = 121;
            this.cbxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxBusqueda.FormattingEnabled = true;
            this.cbxBusqueda.IntegralHeight = false;
            this.cbxBusqueda.ItemHeight = 43;
            this.cbxBusqueda.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "DNI"});
            this.cbxBusqueda.Location = new System.Drawing.Point(935, 59);
            this.cbxBusqueda.MaxDropDownItems = 4;
            this.cbxBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxBusqueda.Name = "cbxBusqueda";
            this.cbxBusqueda.Size = new System.Drawing.Size(202, 49);
            this.cbxBusqueda.StartIndex = 0;
            this.cbxBusqueda.TabIndex = 102;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.AnimateReadOnly = false;
            this.txtConsultar.BackColor = System.Drawing.Color.White;
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultar.Depth = 0;
            this.txtConsultar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsultar.LeadingIcon = null;
            this.txtConsultar.Location = new System.Drawing.Point(509, 59);
            this.txtConsultar.MaxLength = 50;
            this.txtConsultar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsultar.Multiline = false;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(420, 50);
            this.txtConsultar.TabIndex = 100;
            this.txtConsultar.Text = "";
            this.txtConsultar.TrailingIcon = null;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.cbxBusqueda);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.cbxEncargado);
            this.Controls.Add(this.txtPermisos);
            this.Controls.Add(this.txtDniEmpleado);
            this.Controls.Add(this.lblDniEmpleado);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.picUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.cbxInventario);
            this.Controls.Add(this.cbxBiblioteca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picMaximizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picRestaurar;
        private System.Windows.Forms.TextBox lblNombre;
        private MaterialSkin.Controls.MaterialCheckbox cbxBiblioteca;
        private MaterialSkin.Controls.MaterialCheckbox cbxInventario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.PictureBox picUsuarios;
        private System.Windows.Forms.TextBox lblContraseña;
        private MaterialSkin.Controls.MaterialTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.TextBox lblUsuarios;
        private MaterialSkin.Controls.MaterialTextBox txtDniEmpleado;
        private System.Windows.Forms.TextBox lblDniEmpleado;
        private System.Windows.Forms.TextBox txtPermisos;
        private MaterialSkin.Controls.MaterialCheckbox cbxEncargado;
        private MaterialSkin.Controls.MaterialCheckbox cbxAdmin;
        private MaterialSkin.Controls.MaterialComboBox cbxBusqueda;
        private MaterialSkin.Controls.MaterialTextBox txtConsultar;
    }
}
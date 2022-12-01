namespace Proyecto.Clientes
{
    partial class frmClientes
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
            this.pnlBiblioteca = new System.Windows.Forms.Panel();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picMaximizar = new System.Windows.Forms.PictureBox();
            this.picRestaurar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new MaterialSkin.Controls.MaterialTextBox();
            this.lblApellidos = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDniCliente = new System.Windows.Forms.TextBox();
            this.lblClientes = new System.Windows.Forms.TextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.picUsuarios = new System.Windows.Forms.PictureBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.TextBox();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.lblID = new System.Windows.Forms.TextBox();
            this.cbxBusqueda = new MaterialSkin.Controls.MaterialComboBox();
            this.txtConsultar = new MaterialSkin.Controls.MaterialTextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.pnlBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBiblioteca
            // 
            this.pnlBiblioteca.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlBiblioteca.Controls.Add(this.picAtras);
            this.pnlBiblioteca.Controls.Add(this.picMaximizar);
            this.pnlBiblioteca.Controls.Add(this.picRestaurar);
            this.pnlBiblioteca.Controls.Add(this.picMinimizar);
            this.pnlBiblioteca.Controls.Add(this.picCerrar);
            this.pnlBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.pnlBiblioteca.Name = "pnlBiblioteca";
            this.pnlBiblioteca.Size = new System.Drawing.Size(1164, 24);
            this.pnlBiblioteca.TabIndex = 4;
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
            this.picMaximizar.Location = new System.Drawing.Point(1096, 3);
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
            this.picRestaurar.Location = new System.Drawing.Point(1096, 3);
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
            this.picMinimizar.Location = new System.Drawing.Point(1065, 3);
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
            this.picCerrar.Location = new System.Drawing.Point(1127, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(25, 19);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 4;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(245, 417);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(202, 50);
            this.txtTelefono.TabIndex = 69;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTelefono.Enabled = false;
            this.lblTelefono.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(245, 388);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(202, 23);
            this.lblTelefono.TabIndex = 68;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(18, 417);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(202, 50);
            this.txtDireccion.TabIndex = 67;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.Color.White;
            this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDireccion.Enabled = false;
            this.lblDireccion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(18, 388);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(202, 23);
            this.lblDireccion.TabIndex = 66;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AnimateReadOnly = false;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidos.LeadingIcon = null;
            this.txtApellidos.Location = new System.Drawing.Point(245, 338);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidos.Multiline = false;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(202, 50);
            this.txtApellidos.TabIndex = 65;
            this.txtApellidos.Text = "";
            this.txtApellidos.TrailingIcon = null;
            // 
            // lblApellidos
            // 
            this.lblApellidos.BackColor = System.Drawing.Color.White;
            this.lblApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblApellidos.Enabled = false;
            this.lblApellidos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(245, 309);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(202, 23);
            this.lblApellidos.TabIndex = 64;
            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.AnimateReadOnly = false;
            this.txtDniCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDniCliente.Depth = 0;
            this.txtDniCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDniCliente.LeadingIcon = null;
            this.txtDniCliente.Location = new System.Drawing.Point(245, 250);
            this.txtDniCliente.MaxLength = 50;
            this.txtDniCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDniCliente.Multiline = false;
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(202, 50);
            this.txtDniCliente.TabIndex = 63;
            this.txtDniCliente.Text = "";
            this.txtDniCliente.TrailingIcon = null;
            this.txtDniCliente.TextChanged += new System.EventHandler(this.txtDniCliente_TextChanged);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.BackColor = System.Drawing.Color.White;
            this.lblDniCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDniCliente.Enabled = false;
            this.lblDniCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(245, 221);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(202, 23);
            this.lblDniCliente.TabIndex = 62;
            this.lblDniCliente.Text = "DNI Cliente";
            this.lblDniCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClientes
            // 
            this.lblClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientes.BackColor = System.Drawing.Color.White;
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblClientes.Enabled = false;
            this.lblClientes.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(156, 30);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(202, 45);
            this.lblClientes.TabIndex = 61;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(18, 338);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 50);
            this.txtNombre.TabIndex = 60;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
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
            this.btnEliminar.Location = new System.Drawing.Point(136, 589);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(202, 36);
            this.btnEliminar.TabIndex = 59;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(136, 541);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(202, 36);
            this.btnModificar.TabIndex = 58;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnRegistrar.Location = new System.Drawing.Point(136, 493);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(202, 36);
            this.btnRegistrar.TabIndex = 57;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // picUsuarios
            // 
            this.picUsuarios.Enabled = false;
            this.picUsuarios.Image = global::Proyecto.Properties.Resources.Clientes;
            this.picUsuarios.Location = new System.Drawing.Point(183, 90);
            this.picUsuarios.Name = "picUsuarios";
            this.picUsuarios.Size = new System.Drawing.Size(145, 114);
            this.picUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuarios.TabIndex = 54;
            this.picUsuarios.TabStop = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(515, 103);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(636, 521);
            this.dgvClientes.TabIndex = 53;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 309);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(202, 23);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(18, 250);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 50);
            this.txtID.TabIndex = 93;
            this.txtID.Text = "";
            this.txtID.TrailingIcon = null;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(18, 221);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(202, 23);
            this.lblID.TabIndex = 92;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            "DNI",
            "Nombre",
            "Teléfono"});
            this.cbxBusqueda.Location = new System.Drawing.Point(890, 48);
            this.cbxBusqueda.MaxDropDownItems = 4;
            this.cbxBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxBusqueda.Name = "cbxBusqueda";
            this.cbxBusqueda.Size = new System.Drawing.Size(202, 49);
            this.cbxBusqueda.StartIndex = 0;
            this.cbxBusqueda.TabIndex = 96;
            this.cbxBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbxBusqueda_SelectedIndexChanged);
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
            this.txtConsultar.Location = new System.Drawing.Point(515, 49);
            this.txtConsultar.MaxLength = 50;
            this.txtConsultar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsultar.Multiline = false;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(369, 50);
            this.txtConsultar.TabIndex = 94;
            this.txtConsultar.Text = "";
            this.txtConsultar.TrailingIcon = null;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // picBuscar
            // 
            this.picBuscar.Enabled = false;
            this.picBuscar.Image = global::Proyecto.Properties.Resources.buscar_personal;
            this.picBuscar.Location = new System.Drawing.Point(1098, 49);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(53, 50);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 101;
            this.picBuscar.TabStop = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1164, 641);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.cbxBusqueda);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.picUsuarios);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlBiblioteca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.pnlBiblioteca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBiblioteca;
        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.PictureBox picMaximizar;
        private System.Windows.Forms.PictureBox picRestaurar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private System.Windows.Forms.TextBox lblTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private System.Windows.Forms.TextBox lblDireccion;
        private MaterialSkin.Controls.MaterialTextBox txtApellidos;
        private System.Windows.Forms.TextBox lblApellidos;
        private MaterialSkin.Controls.MaterialTextBox txtDniCliente;
        private System.Windows.Forms.TextBox lblDniCliente;
        private System.Windows.Forms.TextBox lblClientes;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private System.Windows.Forms.PictureBox picUsuarios;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox lblNombre;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private System.Windows.Forms.TextBox lblID;
        private MaterialSkin.Controls.MaterialComboBox cbxBusqueda;
        private MaterialSkin.Controls.MaterialTextBox txtConsultar;
        private System.Windows.Forms.PictureBox picBuscar;
    }
}
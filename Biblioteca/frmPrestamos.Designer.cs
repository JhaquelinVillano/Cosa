namespace Proyecto.Biblioteca
{
    partial class frmPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBiblioteca = new System.Windows.Forms.Panel();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picMaximizar = new System.Windows.Forms.PictureBox();
            this.picRestaurar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.txtLibroID = new MaterialSkin.Controls.MaterialTextBox();
            this.lblID = new System.Windows.Forms.TextBox();
            this.lblPrestamos = new System.Windows.Forms.TextBox();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.txtNombreSolicitante = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCliente = new System.Windows.Forms.TextBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.btnDevolver = new MaterialSkin.Controls.MaterialButton();
            this.txtPrestamoID = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPrestamoID = new System.Windows.Forms.TextBox();
            this.cbxBusqueda = new MaterialSkin.Controls.MaterialComboBox();
            this.txtConsultar = new MaterialSkin.Controls.MaterialTextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.picBiblioteca = new System.Windows.Forms.PictureBox();
            this.pnlBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBiblioteca
            // 
            this.pnlBiblioteca.BackColor = System.Drawing.Color.Teal;
            this.pnlBiblioteca.Controls.Add(this.picAtras);
            this.pnlBiblioteca.Controls.Add(this.picMaximizar);
            this.pnlBiblioteca.Controls.Add(this.picRestaurar);
            this.pnlBiblioteca.Controls.Add(this.picMinimizar);
            this.pnlBiblioteca.Controls.Add(this.picCerrar);
            this.pnlBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.pnlBiblioteca.Name = "pnlBiblioteca";
            this.pnlBiblioteca.Size = new System.Drawing.Size(1180, 24);
            this.pnlBiblioteca.TabIndex = 3;
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
            // txtLibroID
            // 
            this.txtLibroID.AnimateReadOnly = false;
            this.txtLibroID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibroID.Depth = 0;
            this.txtLibroID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLibroID.LeadingIcon = null;
            this.txtLibroID.Location = new System.Drawing.Point(116, 343);
            this.txtLibroID.MaxLength = 50;
            this.txtLibroID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLibroID.Multiline = false;
            this.txtLibroID.Name = "txtLibroID";
            this.txtLibroID.Size = new System.Drawing.Size(202, 50);
            this.txtLibroID.TabIndex = 65;
            this.txtLibroID.Text = "";
            this.txtLibroID.TrailingIcon = null;
            this.txtLibroID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLibroID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(116, 314);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(202, 23);
            this.lblID.TabIndex = 64;
            this.lblID.Text = "ID Libro";
            this.lblID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrestamos.BackColor = System.Drawing.Color.White;
            this.lblPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrestamos.Enabled = false;
            this.lblPrestamos.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.Location = new System.Drawing.Point(134, 35);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(174, 45);
            this.lblPrestamos.TabIndex = 69;
            this.lblPrestamos.Text = "Prestamos";
            this.lblPrestamos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvP
            // 
            this.dgvP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.EnableHeadersVisualStyles = false;
            this.dgvP.Location = new System.Drawing.Point(458, 105);
            this.dgvP.Name = "dgvP";
            this.dgvP.Size = new System.Drawing.Size(697, 547);
            this.dgvP.TabIndex = 75;
            this.dgvP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvP_CellClick);
            // 
            // txtNombreSolicitante
            // 
            this.txtNombreSolicitante.AnimateReadOnly = false;
            this.txtNombreSolicitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreSolicitante.Depth = 0;
            this.txtNombreSolicitante.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreSolicitante.LeadingIcon = null;
            this.txtNombreSolicitante.Location = new System.Drawing.Point(116, 428);
            this.txtNombreSolicitante.MaxLength = 50;
            this.txtNombreSolicitante.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreSolicitante.Multiline = false;
            this.txtNombreSolicitante.Name = "txtNombreSolicitante";
            this.txtNombreSolicitante.Size = new System.Drawing.Size(202, 50);
            this.txtNombreSolicitante.TabIndex = 80;
            this.txtNombreSolicitante.Text = "";
            this.txtNombreSolicitante.TrailingIcon = null;
            this.txtNombreSolicitante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreSolicitante_KeyPress);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCliente.Enabled = false;
            this.lblCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(116, 399);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(202, 23);
            this.lblCliente.TabIndex = 79;
            this.lblCliente.Text = "ID Cliente";
            this.lblCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnEliminar.Location = new System.Drawing.Point(116, 616);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(202, 36);
            this.btnEliminar.TabIndex = 83;
            this.btnEliminar.Text = "Deshacer prestamo";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnRegistrar.Location = new System.Drawing.Point(116, 520);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(202, 36);
            this.btnRegistrar.TabIndex = 81;
            this.btnRegistrar.Text = "Hacer prestamo";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.AutoSize = false;
            this.btnDevolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDevolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDevolver.Depth = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDevolver.HighEmphasis = true;
            this.btnDevolver.Icon = null;
            this.btnDevolver.Location = new System.Drawing.Point(116, 568);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDevolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDevolver.Size = new System.Drawing.Size(202, 36);
            this.btnDevolver.TabIndex = 84;
            this.btnDevolver.Text = "Hacer devolución";
            this.btnDevolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDevolver.UseAccentColor = false;
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // txtPrestamoID
            // 
            this.txtPrestamoID.AnimateReadOnly = false;
            this.txtPrestamoID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrestamoID.Depth = 0;
            this.txtPrestamoID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrestamoID.LeadingIcon = null;
            this.txtPrestamoID.Location = new System.Drawing.Point(116, 257);
            this.txtPrestamoID.MaxLength = 50;
            this.txtPrestamoID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrestamoID.Multiline = false;
            this.txtPrestamoID.Name = "txtPrestamoID";
            this.txtPrestamoID.Size = new System.Drawing.Size(202, 50);
            this.txtPrestamoID.TabIndex = 86;
            this.txtPrestamoID.Text = "";
            this.txtPrestamoID.TrailingIcon = null;
            this.txtPrestamoID.TextChanged += new System.EventHandler(this.txtPrestamoID_TextChanged);
            this.txtPrestamoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrestamoID_KeyPress);
            // 
            // lblPrestamoID
            // 
            this.lblPrestamoID.BackColor = System.Drawing.Color.White;
            this.lblPrestamoID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrestamoID.Enabled = false;
            this.lblPrestamoID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamoID.Location = new System.Drawing.Point(116, 228);
            this.lblPrestamoID.Name = "lblPrestamoID";
            this.lblPrestamoID.Size = new System.Drawing.Size(202, 23);
            this.lblPrestamoID.TabIndex = 85;
            this.lblPrestamoID.Text = "ID Prestamo";
            this.lblPrestamoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            "ID Prestamo",
            "ID Libro",
            "ID Cliente"});
            this.cbxBusqueda.Location = new System.Drawing.Point(894, 54);
            this.cbxBusqueda.MaxDropDownItems = 4;
            this.cbxBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxBusqueda.Name = "cbxBusqueda";
            this.cbxBusqueda.Size = new System.Drawing.Size(202, 49);
            this.cbxBusqueda.StartIndex = 0;
            this.cbxBusqueda.TabIndex = 99;
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
            this.txtConsultar.Location = new System.Drawing.Point(458, 53);
            this.txtConsultar.MaxLength = 50;
            this.txtConsultar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsultar.Multiline = false;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(430, 50);
            this.txtConsultar.TabIndex = 97;
            this.txtConsultar.Text = "";
            this.txtConsultar.TrailingIcon = null;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // picBuscar
            // 
            this.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscar.Image = global::Proyecto.Properties.Resources.buscar_libros;
            this.picBuscar.Location = new System.Drawing.Point(1102, 53);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(53, 50);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 100;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            // 
            // picBiblioteca
            // 
            this.picBiblioteca.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBiblioteca.Enabled = false;
            this.picBiblioteca.Image = global::Proyecto.Properties.Resources.libros_01;
            this.picBiblioteca.Location = new System.Drawing.Point(144, 85);
            this.picBiblioteca.Name = "picBiblioteca";
            this.picBiblioteca.Size = new System.Drawing.Size(155, 119);
            this.picBiblioteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBiblioteca.TabIndex = 53;
            this.picBiblioteca.TabStop = false;
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.cbxBusqueda);
            this.Controls.Add(this.txtPrestamoID);
            this.Controls.Add(this.lblPrestamoID);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombreSolicitante);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dgvP);
            this.Controls.Add(this.lblPrestamos);
            this.Controls.Add(this.txtLibroID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.picBiblioteca);
            this.Controls.Add(this.pnlBiblioteca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrestamosDevoluciones";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.pnlBiblioteca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBiblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.PictureBox picMaximizar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Panel pnlBiblioteca;
        private System.Windows.Forms.PictureBox picRestaurar;
        private System.Windows.Forms.PictureBox picBiblioteca;
        private MaterialSkin.Controls.MaterialTextBox txtLibroID;
        private System.Windows.Forms.TextBox lblID;
        private System.Windows.Forms.TextBox lblPrestamos;
        private System.Windows.Forms.DataGridView dgvP;
        private MaterialSkin.Controls.MaterialTextBox txtNombreSolicitante;
        private System.Windows.Forms.TextBox lblCliente;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private MaterialSkin.Controls.MaterialButton btnDevolver;
        private MaterialSkin.Controls.MaterialTextBox txtPrestamoID;
        private System.Windows.Forms.TextBox lblPrestamoID;
        private MaterialSkin.Controls.MaterialComboBox cbxBusqueda;
        private MaterialSkin.Controls.MaterialTextBox txtConsultar;
        private System.Windows.Forms.PictureBox picBuscar;
    }
}
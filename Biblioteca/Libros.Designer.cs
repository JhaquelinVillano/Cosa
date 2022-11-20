namespace Proyecto.Biblioteca
{
    partial class frmLibros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            this.pnlBiblioteca = new System.Windows.Forms.Panel();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picMaximizar = new System.Windows.Forms.PictureBox();
            this.picRestaurar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.lblBiblioteca = new System.Windows.Forms.TextBox();
            this.txtAutor = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.lblAutor = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.TextBox();
            this.txtEdicion = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.lblEdicion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxIdioma = new MaterialSkin.Controls.MaterialComboBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.txtConsultar = new MaterialSkin.Controls.MaterialTextBox();
            this.picLibros = new System.Windows.Forms.PictureBox();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.txtExistencias = new MaterialSkin.Controls.MaterialTextBox();
            this.lblExistencias = new System.Windows.Forms.TextBox();
            this.picBusquedaPR = new System.Windows.Forms.PictureBox();
            this.cbxBusqueda = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBusquedaPR)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBiblioteca
            // 
            this.pnlBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBiblioteca.Controls.Add(this.picAtras);
            this.pnlBiblioteca.Controls.Add(this.picMaximizar);
            this.pnlBiblioteca.Controls.Add(this.picRestaurar);
            this.pnlBiblioteca.Controls.Add(this.picMinimizar);
            this.pnlBiblioteca.Controls.Add(this.picCerrar);
            this.pnlBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.pnlBiblioteca.Name = "pnlBiblioteca";
            this.pnlBiblioteca.Size = new System.Drawing.Size(1180, 24);
            this.pnlBiblioteca.TabIndex = 2;
            this.pnlBiblioteca.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBiblioteca_Paint);
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
            // lblBiblioteca
            // 
            this.lblBiblioteca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBiblioteca.BackColor = System.Drawing.Color.White;
            this.lblBiblioteca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBiblioteca.Enabled = false;
            this.lblBiblioteca.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.Location = new System.Drawing.Point(183, 30);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(155, 45);
            this.lblBiblioteca.TabIndex = 43;
            this.lblBiblioteca.Text = "Libros";
            this.lblBiblioteca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblBiblioteca.TextChanged += new System.EventHandler(this.lblBiblioteca_TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.AnimateReadOnly = false;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutor.Depth = 0;
            this.txtAutor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutor.LeadingIcon = null;
            this.txtAutor.Location = new System.Drawing.Point(12, 323);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAutor.Multiline = false;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(202, 50);
            this.txtAutor.TabIndex = 60;
            this.txtAutor.Text = "";
            this.txtAutor.TrailingIcon = null;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(289, 294);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(202, 23);
            this.txtCantidad.TabIndex = 58;
            this.txtCantidad.Text = "Categoría";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnEliminar.Location = new System.Drawing.Point(348, 613);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(165, 36);
            this.btnEliminar.TabIndex = 56;
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
            this.btnModificar.Location = new System.Drawing.Point(175, 613);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(165, 36);
            this.btnModificar.TabIndex = 55;
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
            this.btnRegistrar.Location = new System.Drawing.Point(2, 613);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(165, 36);
            this.btnRegistrar.TabIndex = 54;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(12, 240);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 50);
            this.txtID.TabIndex = 51;
            this.txtID.Text = "";
            this.txtID.TrailingIcon = null;
            this.txtID.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblAutor
            // 
            this.lblAutor.BackColor = System.Drawing.Color.White;
            this.lblAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAutor.Enabled = false;
            this.lblAutor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(12, 294);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(202, 23);
            this.lblAutor.TabIndex = 49;
            this.lblAutor.Text = "Autor";
            this.lblAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 211);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(202, 23);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "ID";
            this.lblID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblID.TextChanged += new System.EventHandler(this.lblID_TextChanged);
            // 
            // txtEdicion
            // 
            this.txtEdicion.AnimateReadOnly = false;
            this.txtEdicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdicion.Depth = 0;
            this.txtEdicion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEdicion.LeadingIcon = null;
            this.txtEdicion.Location = new System.Drawing.Point(289, 409);
            this.txtEdicion.MaxLength = 50;
            this.txtEdicion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEdicion.Multiline = false;
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(202, 50);
            this.txtEdicion.TabIndex = 66;
            this.txtEdicion.Text = "";
            this.txtEdicion.TrailingIcon = null;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 23);
            this.textBox1.TabIndex = 64;
            this.textBox1.Text = "Idioma";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(289, 240);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 50);
            this.txtNombre.TabIndex = 63;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombreBiblioteca_TextChanged);
            // 
            // lblEdicion
            // 
            this.lblEdicion.BackColor = System.Drawing.Color.White;
            this.lblEdicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblEdicion.Enabled = false;
            this.lblEdicion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicion.Location = new System.Drawing.Point(289, 380);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(202, 23);
            this.lblEdicion.TabIndex = 62;
            this.lblEdicion.Text = "Edición";
            this.lblEdicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(289, 211);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(202, 23);
            this.lblNombre.TabIndex = 61;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblNombre.TextChanged += new System.EventHandler(this.lblNombre_TextChanged);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.AutoResize = false;
            this.cbxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCategoria.Depth = 0;
            this.cbxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxCategoria.DropDownHeight = 174;
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.DropDownWidth = 121;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.IntegralHeight = false;
            this.cbxCategoria.ItemHeight = 43;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Arte",
            "Aventuras",
            "Arquitectura",
            "Administración",
            "Biologia",
            "Cuentos",
            "Ciencia Ficción",
            "Ciencia",
            "Ciencias Naturales",
            "Comunicación",
            "Deportes y Juegos",
            "Educación",
            "Terror"});
            this.cbxCategoria.Location = new System.Drawing.Point(289, 325);
            this.cbxCategoria.MaxDropDownItems = 4;
            this.cbxCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(202, 49);
            this.cbxCategoria.StartIndex = 0;
            this.cbxCategoria.TabIndex = 67;
            // 
            // cbxIdioma
            // 
            this.cbxIdioma.AutoResize = false;
            this.cbxIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxIdioma.Depth = 0;
            this.cbxIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxIdioma.DropDownHeight = 174;
            this.cbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdioma.DropDownWidth = 121;
            this.cbxIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxIdioma.FormattingEnabled = true;
            this.cbxIdioma.IntegralHeight = false;
            this.cbxIdioma.ItemHeight = 43;
            this.cbxIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Portugues",
            "Mandarin"});
            this.cbxIdioma.Location = new System.Drawing.Point(12, 405);
            this.cbxIdioma.MaxDropDownItems = 4;
            this.cbxIdioma.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxIdioma.Name = "cbxIdioma";
            this.cbxIdioma.Size = new System.Drawing.Size(202, 49);
            this.cbxIdioma.StartIndex = 0;
            this.cbxIdioma.TabIndex = 68;
            // 
            // dgvLibros
            // 
            this.dgvLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLibros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(153)))), ((int)(((byte)(120)))));
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(520, 102);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(636, 547);
            this.dgvLibros.TabIndex = 70;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBiblioteca_CellContentClick);
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
            this.txtConsultar.Location = new System.Drawing.Point(520, 51);
            this.txtConsultar.MaxLength = 50;
            this.txtConsultar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsultar.Multiline = false;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(369, 50);
            this.txtConsultar.TabIndex = 71;
            this.txtConsultar.Text = "";
            this.txtConsultar.TrailingIcon = null;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // picLibros
            // 
            this.picLibros.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLibros.Enabled = false;
            this.picLibros.Image = global::Proyecto.Properties.Resources.Biblioteca1;
            this.picLibros.Location = new System.Drawing.Point(183, 86);
            this.picLibros.Name = "picLibros";
            this.picLibros.Size = new System.Drawing.Size(155, 119);
            this.picLibros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLibros.TabIndex = 52;
            this.picLibros.TabStop = false;
            this.picLibros.Click += new System.EventHandler(this.picBiblioteca_Click);
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Enabled = true;
            this.tmrTiempo.Interval = 1000;
            this.tmrTiempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtExistencias
            // 
            this.txtExistencias.AnimateReadOnly = false;
            this.txtExistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistencias.Depth = 0;
            this.txtExistencias.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtExistencias.LeadingIcon = null;
            this.txtExistencias.Location = new System.Drawing.Point(156, 489);
            this.txtExistencias.MaxLength = 50;
            this.txtExistencias.MouseState = MaterialSkin.MouseState.OUT;
            this.txtExistencias.Multiline = false;
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(202, 50);
            this.txtExistencias.TabIndex = 73;
            this.txtExistencias.Text = "";
            this.txtExistencias.TrailingIcon = null;
            // 
            // lblExistencias
            // 
            this.lblExistencias.BackColor = System.Drawing.Color.White;
            this.lblExistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblExistencias.Enabled = false;
            this.lblExistencias.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencias.Location = new System.Drawing.Point(156, 460);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(202, 23);
            this.lblExistencias.TabIndex = 72;
            this.lblExistencias.Text = "Existencias";
            this.lblExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBusquedaPR
            // 
            this.picBusquedaPR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBusquedaPR.Image = ((System.Drawing.Image)(resources.GetObject("picBusquedaPR.Image")));
            this.picBusquedaPR.Location = new System.Drawing.Point(1103, 51);
            this.picBusquedaPR.Name = "picBusquedaPR";
            this.picBusquedaPR.Size = new System.Drawing.Size(53, 49);
            this.picBusquedaPR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBusquedaPR.TabIndex = 74;
            this.picBusquedaPR.TabStop = false;
            this.picBusquedaPR.Click += new System.EventHandler(this.picBusquedaPR_Click);
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
            "Categoría"});
            this.cbxBusqueda.Location = new System.Drawing.Point(895, 51);
            this.cbxBusqueda.MaxDropDownItems = 4;
            this.cbxBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxBusqueda.Name = "cbxBusqueda";
            this.cbxBusqueda.Size = new System.Drawing.Size(202, 49);
            this.cbxBusqueda.StartIndex = 0;
            this.cbxBusqueda.TabIndex = 75;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.cbxBusqueda);
            this.Controls.Add(this.picBusquedaPR);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.cbxIdioma);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtEdicion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.picLibros);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblBiblioteca);
            this.Controls.Add(this.pnlBiblioteca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            this.pnlBiblioteca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBusquedaPR)).EndInit();
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
        private System.Windows.Forms.TextBox lblBiblioteca;
        private MaterialSkin.Controls.MaterialTextBox txtAutor;
        private System.Windows.Forms.TextBox txtCantidad;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private System.Windows.Forms.PictureBox picLibros;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private System.Windows.Forms.TextBox lblAutor;
        private System.Windows.Forms.TextBox lblID;
        private MaterialSkin.Controls.MaterialTextBox txtEdicion;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private System.Windows.Forms.TextBox lblEdicion;
        private System.Windows.Forms.TextBox lblNombre;
        private MaterialSkin.Controls.MaterialComboBox cbxCategoria;
        private MaterialSkin.Controls.MaterialComboBox cbxIdioma;
        private System.Windows.Forms.DataGridView dgvLibros;
        private MaterialSkin.Controls.MaterialTextBox txtConsultar;
        private System.Windows.Forms.Timer tmrTiempo;
        private MaterialSkin.Controls.MaterialTextBox txtExistencias;
        private System.Windows.Forms.TextBox lblExistencias;
        private System.Windows.Forms.PictureBox picBusquedaPR;
        private MaterialSkin.Controls.MaterialComboBox cbxBusqueda;
    }
}
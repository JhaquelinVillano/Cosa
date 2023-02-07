namespace Proyecto.Inventario
{
    partial class frmEntradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.lblDescripción = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.TextBox();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.rbtnDonacion = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtExportar = new System.Windows.Forms.TextBox();
            this.rbtnCompra = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtConsultar = new MaterialSkin.Controls.MaterialTextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.picExcel = new System.Windows.Forms.PictureBox();
            this.txtSumar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(12, 137);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 50);
            this.txtNombre.TabIndex = 33;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblDescripción
            // 
            this.lblDescripción.BackColor = System.Drawing.Color.White;
            this.lblDescripción.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescripción.Enabled = false;
            this.lblDescripción.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(12, 297);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(202, 23);
            this.lblDescripción.TabIndex = 31;
            this.lblDescripción.Text = "Descripción";
            this.lblDescripción.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.White;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCodigo.Enabled = false;
            this.lblCodigo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(202, 23);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(202, 23);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.EnableHeadersVisualStyles = false;
            this.dgvEntradas.Location = new System.Drawing.Point(246, 77);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.Size = new System.Drawing.Size(492, 580);
            this.dgvEntradas.TabIndex = 37;
            this.dgvEntradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellClick);
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 572);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(202, 36);
            this.btnEliminar.TabIndex = 40;
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
            this.btnModificar.Location = new System.Drawing.Point(12, 524);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(202, 36);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = false;
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(12, 476);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(202, 36);
            this.btnIngresar.TabIndex = 38;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.HideSelection = true;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 326);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(202, 92);
            this.txtDescripcion.TabIndex = 44;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(12, 222);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(202, 50);
            this.txtCantidad.TabIndex = 46;
            this.txtCantidad.Text = "";
            this.txtCantidad.TrailingIcon = null;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.White;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCantidad.Enabled = false;
            this.lblCantidad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 193);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(202, 23);
            this.lblCantidad.TabIndex = 45;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AnimateReadOnly = false;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.LeadingIcon = null;
            this.txtCodigo.Location = new System.Drawing.Point(12, 47);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(202, 50);
            this.txtCodigo.TabIndex = 47;
            this.txtCodigo.Text = "";
            this.txtCodigo.TrailingIcon = null;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // rbtnDonacion
            // 
            this.rbtnDonacion.AutoSize = true;
            this.rbtnDonacion.Depth = 0;
            this.rbtnDonacion.Location = new System.Drawing.Point(9, 433);
            this.rbtnDonacion.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnDonacion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnDonacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnDonacion.Name = "rbtnDonacion";
            this.rbtnDonacion.Ripple = true;
            this.rbtnDonacion.Size = new System.Drawing.Size(103, 37);
            this.rbtnDonacion.TabIndex = 48;
            this.rbtnDonacion.TabStop = true;
            this.rbtnDonacion.Text = "Donación";
            this.rbtnDonacion.UseVisualStyleBackColor = true;
            // 
            // txtExportar
            // 
            this.txtExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExportar.BackColor = System.Drawing.Color.White;
            this.txtExportar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExportar.Enabled = false;
            this.txtExportar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportar.Location = new System.Drawing.Point(109, 616);
            this.txtExportar.Name = "txtExportar";
            this.txtExportar.Size = new System.Drawing.Size(121, 23);
            this.txtExportar.TabIndex = 49;
            this.txtExportar.Text = "Exportar";
            this.txtExportar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnCompra
            // 
            this.rbtnCompra.AutoSize = true;
            this.rbtnCompra.Depth = 0;
            this.rbtnCompra.Location = new System.Drawing.Point(123, 433);
            this.rbtnCompra.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnCompra.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnCompra.Name = "rbtnCompra";
            this.rbtnCompra.Ripple = true;
            this.rbtnCompra.Size = new System.Drawing.Size(91, 37);
            this.rbtnCompra.TabIndex = 50;
            this.rbtnCompra.TabStop = true;
            this.rbtnCompra.Text = "Compra";
            this.rbtnCompra.UseVisualStyleBackColor = true;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.AnimateReadOnly = false;
            this.txtConsultar.BackColor = System.Drawing.Color.White;
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultar.Depth = 0;
            this.txtConsultar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsultar.LeadingIcon = null;
            this.txtConsultar.Location = new System.Drawing.Point(246, 21);
            this.txtConsultar.MaxLength = 50;
            this.txtConsultar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsultar.Multiline = false;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(430, 50);
            this.txtConsultar.TabIndex = 73;
            this.txtConsultar.Text = "";
            this.txtConsultar.TrailingIcon = null;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // picBuscar
            // 
            this.picBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscar.Image = global::Proyecto.Properties.Resources.buscar_Inventario;
            this.picBuscar.Location = new System.Drawing.Point(682, 21);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(56, 50);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 91;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            // 
            // picExcel
            // 
            this.picExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExcel.Image = global::Proyecto.Properties.Resources.excel;
            this.picExcel.Location = new System.Drawing.Point(134, 644);
            this.picExcel.Name = "picExcel";
            this.picExcel.Size = new System.Drawing.Size(62, 39);
            this.picExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExcel.TabIndex = 43;
            this.picExcel.TabStop = false;
            this.picExcel.Click += new System.EventHandler(this.picExcel_Click);
            // 
            // txtSumar
            // 
            this.txtSumar.AutoSize = false;
            this.txtSumar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtSumar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtSumar.Depth = 0;
            this.txtSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSumar.HighEmphasis = true;
            this.txtSumar.Icon = null;
            this.txtSumar.Location = new System.Drawing.Point(13, 621);
            this.txtSumar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSumar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSumar.Name = "txtSumar";
            this.txtSumar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtSumar.Size = new System.Drawing.Size(88, 36);
            this.txtSumar.TabIndex = 92;
            this.txtSumar.Text = "Sumar";
            this.txtSumar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtSumar.UseAccentColor = false;
            this.txtSumar.UseVisualStyleBackColor = true;
            this.txtSumar.Click += new System.EventHandler(this.txtSumar_Click);
            // 
            // frmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 688);
            this.Controls.Add(this.txtSumar);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.rbtnCompra);
            this.Controls.Add(this.txtExportar);
            this.Controls.Add(this.rbtnDonacion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.picExcel);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dgvEntradas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private System.Windows.Forms.TextBox lblDescripción;
        private System.Windows.Forms.TextBox lblCodigo;
        private System.Windows.Forms.TextBox lblNombre;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private System.Windows.Forms.PictureBox picExcel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private System.Windows.Forms.TextBox lblCantidad;
        private MaterialSkin.Controls.MaterialTextBox txtCodigo;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDonacion;
        private System.Windows.Forms.TextBox txtExportar;
        private MaterialSkin.Controls.MaterialRadioButton rbtnCompra;
        private MaterialSkin.Controls.MaterialTextBox txtConsultar;
        private System.Windows.Forms.PictureBox picBuscar;
        private MaterialSkin.Controls.MaterialButton txtSumar;
    }
}
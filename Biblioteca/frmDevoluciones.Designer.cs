namespace Proyecto.Biblioteca
{
    partial class frmDevoluciones
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
            this.pnlBiblioteca = new System.Windows.Forms.Panel();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picMaximizar = new System.Windows.Forms.PictureBox();
            this.picRestaurar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.txtConsultar = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxBusqueda = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPrestamoID = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPrestamoID = new System.Windows.Forms.TextBox();
            this.btnDevolver = new MaterialSkin.Controls.MaterialButton();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.lblDevoluciones = new System.Windows.Forms.TextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.picBiblioteca = new System.Windows.Forms.PictureBox();
            this.pnlBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBiblioteca
            // 
            this.pnlBiblioteca.BackColor = System.Drawing.Color.MidnightBlue;
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
            this.picMaximizar.Location = new System.Drawing.Point(1096, 2);
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
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.AnimateReadOnly = false;
            this.txtConsultar.BackColor = System.Drawing.Color.White;
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultar.Depth = 0;
            this.txtConsultar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsultar.LeadingIcon = null;
            this.txtConsultar.Location = new System.Drawing.Point(326, 30);
            this.txtConsultar.MaxLength = 50;
            this.txtConsultar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsultar.Multiline = false;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(559, 50);
            this.txtConsultar.TabIndex = 113;
            this.txtConsultar.Text = "";
            this.txtConsultar.TrailingIcon = null;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            // 
            // cbxBusqueda
            // 
            this.cbxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            "ID - Devolución",
            "Nombre - Libro",
            "DNI - Cliente",
            "Usuario - Empleado",
            "DNI - Empleado",
            "Fecha - Prestamo",
            "Fecha - Devolución"});
            this.cbxBusqueda.Location = new System.Drawing.Point(891, 31);
            this.cbxBusqueda.MaxDropDownItems = 4;
            this.cbxBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxBusqueda.Name = "cbxBusqueda";
            this.cbxBusqueda.Size = new System.Drawing.Size(202, 49);
            this.cbxBusqueda.StartIndex = 0;
            this.cbxBusqueda.TabIndex = 114;
            // 
            // txtPrestamoID
            // 
            this.txtPrestamoID.AnimateReadOnly = false;
            this.txtPrestamoID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrestamoID.Depth = 0;
            this.txtPrestamoID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrestamoID.LeadingIcon = null;
            this.txtPrestamoID.Location = new System.Drawing.Point(55, 258);
            this.txtPrestamoID.MaxLength = 50;
            this.txtPrestamoID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrestamoID.Multiline = false;
            this.txtPrestamoID.Name = "txtPrestamoID";
            this.txtPrestamoID.Size = new System.Drawing.Size(202, 50);
            this.txtPrestamoID.TabIndex = 112;
            this.txtPrestamoID.Text = "";
            this.txtPrestamoID.TrailingIcon = null;
            // 
            // lblPrestamoID
            // 
            this.lblPrestamoID.BackColor = System.Drawing.Color.White;
            this.lblPrestamoID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrestamoID.Enabled = false;
            this.lblPrestamoID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamoID.Location = new System.Drawing.Point(55, 229);
            this.lblPrestamoID.Name = "lblPrestamoID";
            this.lblPrestamoID.Size = new System.Drawing.Size(202, 23);
            this.lblPrestamoID.TabIndex = 111;
            this.lblPrestamoID.Text = "ID Prestamo";
            this.lblPrestamoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnDevolver.Location = new System.Drawing.Point(55, 345);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDevolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDevolver.Size = new System.Drawing.Size(202, 36);
            this.btnDevolver.TabIndex = 110;
            this.btnDevolver.Text = "Hacer devolución";
            this.btnDevolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDevolver.UseAccentColor = false;
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevoluciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevoluciones.EnableHeadersVisualStyles = false;
            this.dgvDevoluciones.Location = new System.Drawing.Point(326, 82);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.Size = new System.Drawing.Size(826, 547);
            this.dgvDevoluciones.TabIndex = 105;
            // 
            // lblDevoluciones
            // 
            this.lblDevoluciones.BackColor = System.Drawing.Color.White;
            this.lblDevoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDevoluciones.Enabled = false;
            this.lblDevoluciones.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevoluciones.Location = new System.Drawing.Point(55, 35);
            this.lblDevoluciones.Name = "lblDevoluciones";
            this.lblDevoluciones.Size = new System.Drawing.Size(208, 45);
            this.lblDevoluciones.TabIndex = 104;
            this.lblDevoluciones.Text = "Devoluciones";
            this.lblDevoluciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBuscar
            // 
            this.picBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscar.Image = global::Proyecto.Properties.Resources.buscar_libros;
            this.picBuscar.Location = new System.Drawing.Point(1099, 30);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(53, 50);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 115;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            // 
            // picBiblioteca
            // 
            this.picBiblioteca.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBiblioteca.Enabled = false;
            this.picBiblioteca.Image = global::Proyecto.Properties.Resources.bitacora1;
            this.picBiblioteca.Location = new System.Drawing.Point(83, 86);
            this.picBiblioteca.Name = "picBiblioteca";
            this.picBiblioteca.Size = new System.Drawing.Size(155, 119);
            this.picBiblioteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBiblioteca.TabIndex = 101;
            this.picBiblioteca.TabStop = false;
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1164, 641);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.cbxBusqueda);
            this.Controls.Add(this.txtPrestamoID);
            this.Controls.Add(this.lblPrestamoID);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvDevoluciones);
            this.Controls.Add(this.lblDevoluciones);
            this.Controls.Add(this.picBiblioteca);
            this.Controls.Add(this.pnlBiblioteca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            this.pnlBiblioteca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBiblioteca)).EndInit();
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
        private System.Windows.Forms.PictureBox picBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtConsultar;
        private MaterialSkin.Controls.MaterialComboBox cbxBusqueda;
        private MaterialSkin.Controls.MaterialTextBox txtPrestamoID;
        private System.Windows.Forms.TextBox lblPrestamoID;
        private MaterialSkin.Controls.MaterialButton btnDevolver;
        private System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.TextBox lblDevoluciones;
        private System.Windows.Forms.PictureBox picBiblioteca;
    }
}
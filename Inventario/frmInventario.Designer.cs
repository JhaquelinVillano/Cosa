namespace Proyecto.Inventario
{
    partial class frmInventario
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
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picMaximizar = new System.Windows.Forms.PictureBox();
            this.picRestaurar = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.txtConsultar = new MaterialSkin.Controls.MaterialTextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblInventario = new System.Windows.Forms.TextBox();
            this.picInventario = new System.Windows.Forms.PictureBox();
            this.btnEntradas = new MaterialSkin.Controls.MaterialButton();
            this.txtExportar = new System.Windows.Forms.TextBox();
            this.picExcel = new System.Windows.Forms.PictureBox();
            this.btnInventario = new MaterialSkin.Controls.MaterialButton();
            this.btnSalidas = new MaterialSkin.Controls.MaterialButton();
            this.pnlInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInventario
            // 
            this.pnlInventario.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlInventario.Controls.Add(this.picAtras);
            this.pnlInventario.Controls.Add(this.picMaximizar);
            this.pnlInventario.Controls.Add(this.picRestaurar);
            this.pnlInventario.Controls.Add(this.picMinimizar);
            this.pnlInventario.Controls.Add(this.picCerrar);
            this.pnlInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventario.Location = new System.Drawing.Point(0, 0);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(1180, 24);
            this.pnlInventario.TabIndex = 2;
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
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.AnimateReadOnly = false;
            this.txtConsultar.BackColor = System.Drawing.Color.White;
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultar.Depth = 0;
            this.txtConsultar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsultar.LeadingIcon = null;
            this.txtConsultar.Location = new System.Drawing.Point(258, 42);
            this.txtConsultar.MaxLength = 50;
            this.txtConsultar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsultar.Multiline = false;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(767, 50);
            this.txtConsultar.TabIndex = 76;
            this.txtConsultar.Text = "";
            this.txtConsultar.TrailingIcon = null;
            this.txtConsultar.TextChanged += new System.EventHandler(this.txtConsultar_TextChanged);
            this.txtConsultar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsultar_KeyUp);
            // 
            // dgvInventario
            // 
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(258, 96);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(910, 546);
            this.dgvInventario.TabIndex = 74;
            // 
            // lblInventario
            // 
            this.lblInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventario.BackColor = System.Drawing.Color.White;
            this.lblInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInventario.Enabled = false;
            this.lblInventario.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.Location = new System.Drawing.Point(21, 45);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(202, 45);
            this.lblInventario.TabIndex = 78;
            this.lblInventario.Text = "Inventario";
            this.lblInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblInventario.TextChanged += new System.EventHandler(this.lblInventario_TextChanged);
            // 
            // picInventario
            // 
            this.picInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.picInventario.Enabled = false;
            this.picInventario.Image = global::Proyecto.Properties.Resources.Entradas;
            this.picInventario.Location = new System.Drawing.Point(41, 96);
            this.picInventario.Name = "picInventario";
            this.picInventario.Size = new System.Drawing.Size(160, 119);
            this.picInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInventario.TabIndex = 77;
            this.picInventario.TabStop = false;
            // 
            // btnEntradas
            // 
            this.btnEntradas.AutoSize = false;
            this.btnEntradas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntradas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEntradas.Depth = 0;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.HighEmphasis = true;
            this.btnEntradas.Icon = null;
            this.btnEntradas.Location = new System.Drawing.Point(21, 290);
            this.btnEntradas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntradas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEntradas.Size = new System.Drawing.Size(202, 36);
            this.btnEntradas.TabIndex = 79;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEntradas.UseAccentColor = false;
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // txtExportar
            // 
            this.txtExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExportar.BackColor = System.Drawing.Color.White;
            this.txtExportar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExportar.Enabled = false;
            this.txtExportar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportar.Location = new System.Drawing.Point(6, 600);
            this.txtExportar.Name = "txtExportar";
            this.txtExportar.Size = new System.Drawing.Size(76, 23);
            this.txtExportar.TabIndex = 81;
            this.txtExportar.Text = "Exportar";
            this.txtExportar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picExcel
            // 
            this.picExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExcel.Image = global::Proyecto.Properties.Resources.excel;
            this.picExcel.Location = new System.Drawing.Point(12, 629);
            this.picExcel.Name = "picExcel";
            this.picExcel.Size = new System.Drawing.Size(62, 39);
            this.picExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExcel.TabIndex = 80;
            this.picExcel.TabStop = false;
            this.picExcel.Click += new System.EventHandler(this.picExcel_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.AutoSize = false;
            this.btnInventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInventario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInventario.Depth = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.HighEmphasis = true;
            this.btnInventario.Icon = null;
            this.btnInventario.Location = new System.Drawing.Point(21, 242);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInventario.Size = new System.Drawing.Size(202, 36);
            this.btnInventario.TabIndex = 82;
            this.btnInventario.Text = "Actualizar";
            this.btnInventario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInventario.UseAccentColor = false;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.AutoSize = false;
            this.btnSalidas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalidas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalidas.Depth = 0;
            this.btnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidas.HighEmphasis = true;
            this.btnSalidas.Icon = null;
            this.btnSalidas.Location = new System.Drawing.Point(21, 338);
            this.btnSalidas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalidas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalidas.Size = new System.Drawing.Size(202, 36);
            this.btnSalidas.TabIndex = 83;
            this.btnSalidas.Text = "Salidas";
            this.btnSalidas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalidas.UseAccentColor = false;
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.btnSalidas);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.txtExportar);
            this.Controls.Add(this.picExcel);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.picInventario);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pnlInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.pnlInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInventario;
        private System.Windows.Forms.PictureBox picAtras;
        private System.Windows.Forms.PictureBox picMaximizar;
        private System.Windows.Forms.PictureBox picRestaurar;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private MaterialSkin.Controls.MaterialTextBox txtConsultar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.TextBox lblInventario;
        private System.Windows.Forms.PictureBox picInventario;
        private MaterialSkin.Controls.MaterialButton btnEntradas;
        private System.Windows.Forms.TextBox txtExportar;
        private System.Windows.Forms.PictureBox picExcel;
        private MaterialSkin.Controls.MaterialButton btnInventario;
        private MaterialSkin.Controls.MaterialButton btnSalidas;
    }
}
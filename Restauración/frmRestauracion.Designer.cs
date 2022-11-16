namespace Proyecto.Restauración
{
    partial class frmRestauracion
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
            this.pnlRestauracion = new System.Windows.Forms.Panel();
            this.picAtras = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.picRestauracion = new System.Windows.Forms.PictureBox();
            this.lblRestauracion = new System.Windows.Forms.TextBox();
            this.btnCopia = new MaterialSkin.Controls.MaterialButton();
            this.btnRestablecer = new MaterialSkin.Controls.MaterialButton();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.pnlRestauracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestauracion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRestauracion
            // 
            this.pnlRestauracion.BackColor = System.Drawing.Color.Salmon;
            this.pnlRestauracion.Controls.Add(this.picAtras);
            this.pnlRestauracion.Controls.Add(this.picMin);
            this.pnlRestauracion.Controls.Add(this.picMinimizar);
            this.pnlRestauracion.Controls.Add(this.picSalir);
            this.pnlRestauracion.Controls.Add(this.picCerrar);
            this.pnlRestauracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRestauracion.Location = new System.Drawing.Point(0, 0);
            this.pnlRestauracion.Name = "pnlRestauracion";
            this.pnlRestauracion.Size = new System.Drawing.Size(375, 26);
            this.pnlRestauracion.TabIndex = 1;
            // 
            // picAtras
            // 
            this.picAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAtras.Image = global::Proyecto.Properties.Resources.atras;
            this.picAtras.Location = new System.Drawing.Point(3, 6);
            this.picAtras.Name = "picAtras";
            this.picAtras.Size = new System.Drawing.Size(24, 17);
            this.picAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAtras.TabIndex = 49;
            this.picAtras.TabStop = false;
            this.picAtras.Click += new System.EventHandler(this.picAtras_Click);
            // 
            // picMin
            // 
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Proyecto.Properties.Resources.min;
            this.picMin.Location = new System.Drawing.Point(307, 5);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(25, 18);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMin.TabIndex = 7;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = global::Proyecto.Properties.Resources.min;
            this.picMinimizar.Location = new System.Drawing.Point(379, 4);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(25, 18);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizar.TabIndex = 5;
            this.picMinimizar.TabStop = false;
            // 
            // picSalir
            // 
            this.picSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalir.Image = global::Proyecto.Properties.Resources.cerrar;
            this.picSalir.Location = new System.Drawing.Point(338, 5);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(25, 18);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalir.TabIndex = 6;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::Proyecto.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(410, 5);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(25, 18);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 4;
            this.picCerrar.TabStop = false;
            // 
            // picRestauracion
            // 
            this.picRestauracion.Cursor = System.Windows.Forms.Cursors.Default;
            this.picRestauracion.Enabled = false;
            this.picRestauracion.Image = global::Proyecto.Properties.Resources.Respaldo;
            this.picRestauracion.Location = new System.Drawing.Point(106, 102);
            this.picRestauracion.Name = "picRestauracion";
            this.picRestauracion.Size = new System.Drawing.Size(149, 134);
            this.picRestauracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestauracion.TabIndex = 6;
            this.picRestauracion.TabStop = false;
            // 
            // lblRestauracion
            // 
            this.lblRestauracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRestauracion.BackColor = System.Drawing.Color.White;
            this.lblRestauracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRestauracion.Enabled = false;
            this.lblRestauracion.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestauracion.Location = new System.Drawing.Point(39, 42);
            this.lblRestauracion.Name = "lblRestauracion";
            this.lblRestauracion.Size = new System.Drawing.Size(308, 45);
            this.lblRestauracion.TabIndex = 43;
            this.lblRestauracion.Text = "Copia y Restauración";
            this.lblRestauracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCopia
            // 
            this.btnCopia.AutoSize = false;
            this.btnCopia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopia.Depth = 0;
            this.btnCopia.HighEmphasis = true;
            this.btnCopia.Icon = null;
            this.btnCopia.Location = new System.Drawing.Point(106, 430);
            this.btnCopia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopia.Size = new System.Drawing.Size(149, 36);
            this.btnCopia.TabIndex = 46;
            this.btnCopia.Text = "Copia de Seguridad";
            this.btnCopia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopia.UseAccentColor = false;
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.AutoSize = false;
            this.btnRestablecer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestablecer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRestablecer.Depth = 0;
            this.btnRestablecer.HighEmphasis = true;
            this.btnRestablecer.Icon = null;
            this.btnRestablecer.Location = new System.Drawing.Point(106, 360);
            this.btnRestablecer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRestablecer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRestablecer.Size = new System.Drawing.Size(149, 36);
            this.btnRestablecer.TabIndex = 47;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRestablecer.UseAccentColor = false;
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(28, 296);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(319, 30);
            this.txtdireccion.TabIndex = 48;
            // 
            // frmRestauracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnCopia);
            this.Controls.Add(this.lblRestauracion);
            this.Controls.Add(this.picRestauracion);
            this.Controls.Add(this.pnlRestauracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRestauracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRestauracion";
            this.Load += new System.EventHandler(this.frmRestauracion_Load);
            this.pnlRestauracion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestauracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRestauracion;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.PictureBox picRestauracion;
        private System.Windows.Forms.TextBox lblRestauracion;
        private MaterialSkin.Controls.MaterialButton btnCopia;
        private MaterialSkin.Controls.MaterialButton btnRestablecer;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.PictureBox picAtras;
    }
}
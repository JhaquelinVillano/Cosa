namespace Proyecto
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnAcceder = new MaterialSkin.Controls.MaterialButton();
            this.txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.linkContraseña = new System.Windows.Forms.LinkLabel();
            this.picNuevoUsuario = new System.Windows.Forms.PictureBox();
            this.picMinimizarLogin = new System.Windows.Forms.PictureBox();
            this.picCerrarLogin = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picContraseña = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNuevoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.AutoSize = false;
            this.btnAcceder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcceder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAcceder.Depth = 0;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnAcceder.HighEmphasis = true;
            this.btnAcceder.Icon = null;
            this.btnAcceder.Location = new System.Drawing.Point(34, 415);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAcceder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAcceder.Size = new System.Drawing.Size(301, 36);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAcceder.UseAccentColor = false;
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click_1);
            // 
            // txtContraseña
            // 
            this.txtContraseña.AnimateReadOnly = false;
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.LeadingIcon = null;
            this.txtContraseña.Location = new System.Drawing.Point(91, 309);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Password = true;
            this.txtContraseña.Size = new System.Drawing.Size(245, 50);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "";
            this.txtContraseña.TrailingIcon = null;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(91, 210);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(244, 50);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // linkContraseña
            // 
            this.linkContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkContraseña.AutoSize = true;
            this.linkContraseña.LinkColor = System.Drawing.Color.DimGray;
            this.linkContraseña.Location = new System.Drawing.Point(125, 396);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(146, 13);
            this.linkContraseña.TabIndex = 0;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "¿Ha olvidado su contraseña?";
            this.linkContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContraseña_LinkClicked);
            // 
            // picNuevoUsuario
            // 
            this.picNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNuevoUsuario.Image = global::Proyecto.Properties.Resources.soporte_tecnico;
            this.picNuevoUsuario.Location = new System.Drawing.Point(314, 486);
            this.picNuevoUsuario.Name = "picNuevoUsuario";
            this.picNuevoUsuario.Size = new System.Drawing.Size(53, 52);
            this.picNuevoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNuevoUsuario.TabIndex = 24;
            this.picNuevoUsuario.TabStop = false;
            // 
            // picMinimizarLogin
            // 
            this.picMinimizarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizarLogin.Image = global::Proyecto.Properties.Resources.png_transparent_interface_maximize_minimize_minus_plus_user_interface_line_icon;
            this.picMinimizarLogin.Location = new System.Drawing.Point(311, 4);
            this.picMinimizarLogin.Name = "picMinimizarLogin";
            this.picMinimizarLogin.Size = new System.Drawing.Size(25, 20);
            this.picMinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimizarLogin.TabIndex = 20;
            this.picMinimizarLogin.TabStop = false;
            this.picMinimizarLogin.Click += new System.EventHandler(this.picMinimizarLogin_Click);
            // 
            // picCerrarLogin
            // 
            this.picCerrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrarLogin.Image = global::Proyecto.Properties.Resources.cerrar;
            this.picCerrarLogin.Location = new System.Drawing.Point(342, 4);
            this.picCerrarLogin.Name = "picCerrarLogin";
            this.picCerrarLogin.Size = new System.Drawing.Size(25, 20);
            this.picCerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrarLogin.TabIndex = 19;
            this.picCerrarLogin.TabStop = false;
            this.picCerrarLogin.Click += new System.EventHandler(this.picCerrarLogin_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(34, 26);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(301, 131);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picContraseña
            // 
            this.picContraseña.Enabled = false;
            this.picContraseña.Image = global::Proyecto.Properties.Resources.contraseña;
            this.picContraseña.Location = new System.Drawing.Point(35, 309);
            this.picContraseña.Name = "picContraseña";
            this.picContraseña.Size = new System.Drawing.Size(50, 48);
            this.picContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContraseña.TabIndex = 14;
            this.picContraseña.TabStop = false;
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picUsuario.Enabled = false;
            this.picUsuario.Image = global::Proyecto.Properties.Resources.usuario;
            this.picUsuario.Location = new System.Drawing.Point(37, 210);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(48, 48);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 13;
            this.picUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources._1f7e0;
            this.pictureBox1.Location = new System.Drawing.Point(-152, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.icone_cercle_rempli_vert;
            this.pictureBox2.Location = new System.Drawing.Point(341, -36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 372);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUsuario.Enabled = false;
            this.lblUsuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(37, 181);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(298, 23);
            this.lblUsuario.TabIndex = 94;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblContraseña
            // 
            this.lblContraseña.BackColor = System.Drawing.Color.White;
            this.lblContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblContraseña.Enabled = false;
            this.lblContraseña.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(37, 280);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(298, 23);
            this.lblContraseña.TabIndex = 95;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.picNuevoUsuario);
            this.Controls.Add(this.linkContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.picMinimizarLogin);
            this.Controls.Add(this.picCerrarLogin);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picContraseña);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picNuevoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private MaterialSkin.Controls.MaterialButton btnAcceder;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picCerrarLogin;
        private System.Windows.Forms.PictureBox picMinimizarLogin;
        private MaterialSkin.Controls.MaterialTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private System.Windows.Forms.LinkLabel linkContraseña;
        private System.Windows.Forms.PictureBox picNuevoUsuario;
        private System.Windows.Forms.TextBox lblUsuario;
        private System.Windows.Forms.TextBox lblContraseña;
    }
}


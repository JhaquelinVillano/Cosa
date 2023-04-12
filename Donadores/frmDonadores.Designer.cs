namespace Proyecto.Donadores
{
    partial class frmDonadores
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
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreDonadores = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCorreo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNacionalidad = new System.Windows.Forms.TextBox();
            this.lblTeléfono = new System.Windows.Forms.TextBox();
            this.lblRedesSociales = new System.Windows.Forms.TextBox();
            this.txtRedesSociales = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNacionalidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPlataforma = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPlataforma = new System.Windows.Forms.TextBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.dtpDonadores = new System.Windows.Forms.DateTimePicker();
            this.dgvDonadores = new System.Windows.Forms.DataGridView();
            this.txtConsultar = new MaterialSkin.Controls.MaterialTextBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(263, 55);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(223, 50);
            this.txtCorreo.TabIndex = 74;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // txtNombreDonadores
            // 
            this.txtNombreDonadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreDonadores.AnimateReadOnly = false;
            this.txtNombreDonadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreDonadores.Depth = 0;
            this.txtNombreDonadores.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreDonadores.LeadingIcon = null;
            this.txtNombreDonadores.Location = new System.Drawing.Point(20, 50);
            this.txtNombreDonadores.MaxLength = 50;
            this.txtNombreDonadores.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreDonadores.Multiline = false;
            this.txtNombreDonadores.Name = "txtNombreDonadores";
            this.txtNombreDonadores.Size = new System.Drawing.Size(223, 50);
            this.txtNombreDonadores.TabIndex = 73;
            this.txtNombreDonadores.Text = "";
            this.txtNombreDonadores.TrailingIcon = null;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorreo.BackColor = System.Drawing.Color.White;
            this.lblCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCorreo.Enabled = false;
            this.lblCorreo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(263, 26);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(223, 23);
            this.lblCorreo.TabIndex = 72;
            this.lblCorreo.Text = "Correo";
            this.lblCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(223, 23);
            this.lblNombre.TabIndex = 71;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(20, 228);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(223, 50);
            this.txtTelefono.TabIndex = 69;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNacionalidad.BackColor = System.Drawing.Color.White;
            this.lblNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNacionalidad.Enabled = false;
            this.lblNacionalidad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(20, 111);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(223, 23);
            this.lblNacionalidad.TabIndex = 68;
            this.lblNacionalidad.Text = "Nacionalidad";
            this.lblNacionalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeléfono.BackColor = System.Drawing.Color.White;
            this.lblTeléfono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTeléfono.Enabled = false;
            this.lblTeléfono.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfono.Location = new System.Drawing.Point(20, 199);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(223, 23);
            this.lblTeléfono.TabIndex = 67;
            this.lblTeléfono.Text = "Teléfono";
            this.lblTeléfono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRedesSociales
            // 
            this.lblRedesSociales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRedesSociales.BackColor = System.Drawing.Color.White;
            this.lblRedesSociales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRedesSociales.Enabled = false;
            this.lblRedesSociales.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedesSociales.Location = new System.Drawing.Point(263, 199);
            this.lblRedesSociales.Name = "lblRedesSociales";
            this.lblRedesSociales.Size = new System.Drawing.Size(223, 23);
            this.lblRedesSociales.TabIndex = 78;
            this.lblRedesSociales.Text = "Red Social";
            this.lblRedesSociales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRedesSociales
            // 
            this.txtRedesSociales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRedesSociales.AnimateReadOnly = false;
            this.txtRedesSociales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRedesSociales.Depth = 0;
            this.txtRedesSociales.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRedesSociales.LeadingIcon = null;
            this.txtRedesSociales.Location = new System.Drawing.Point(263, 228);
            this.txtRedesSociales.MaxLength = 50;
            this.txtRedesSociales.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRedesSociales.Multiline = false;
            this.txtRedesSociales.Name = "txtRedesSociales";
            this.txtRedesSociales.Size = new System.Drawing.Size(223, 50);
            this.txtRedesSociales.TabIndex = 79;
            this.txtRedesSociales.Text = "";
            this.txtRedesSociales.TrailingIcon = null;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNacionalidad.AnimateReadOnly = false;
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNacionalidad.Depth = 0;
            this.txtNacionalidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNacionalidad.LeadingIcon = null;
            this.txtNacionalidad.Location = new System.Drawing.Point(20, 140);
            this.txtNacionalidad.MaxLength = 50;
            this.txtNacionalidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNacionalidad.Multiline = false;
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(223, 50);
            this.txtNacionalidad.TabIndex = 80;
            this.txtNacionalidad.Text = "";
            this.txtNacionalidad.TrailingIcon = null;
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlataforma.AnimateReadOnly = false;
            this.txtPlataforma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlataforma.Depth = 0;
            this.txtPlataforma.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlataforma.LeadingIcon = null;
            this.txtPlataforma.Location = new System.Drawing.Point(263, 140);
            this.txtPlataforma.MaxLength = 50;
            this.txtPlataforma.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPlataforma.Multiline = false;
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(223, 50);
            this.txtPlataforma.TabIndex = 81;
            this.txtPlataforma.Text = "";
            this.txtPlataforma.TrailingIcon = null;
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlataforma.BackColor = System.Drawing.Color.White;
            this.lblPlataforma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPlataforma.Enabled = false;
            this.lblPlataforma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlataforma.Location = new System.Drawing.Point(263, 111);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(223, 23);
            this.lblPlataforma.TabIndex = 82;
            this.lblPlataforma.Text = "Plataforma";
            this.lblPlataforma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(513, 180);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(223, 36);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.AutoSize = false;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = null;
            this.btnModificar.Location = new System.Drawing.Point(514, 132);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(223, 36);
            this.btnModificar.TabIndex = 84;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.AutoSize = false;
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.HighEmphasis = true;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(513, 84);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(223, 36);
            this.btnRegistrar.TabIndex = 83;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dtpDonadores
            // 
            this.dtpDonadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDonadores.Location = new System.Drawing.Point(513, 228);
            this.dtpDonadores.Name = "dtpDonadores";
            this.dtpDonadores.Size = new System.Drawing.Size(223, 20);
            this.dtpDonadores.TabIndex = 86;
            // 
            // dgvDonadores
            // 
            this.dgvDonadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(186)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonadores.EnableHeadersVisualStyles = false;
            this.dgvDonadores.Location = new System.Drawing.Point(20, 367);
            this.dgvDonadores.Name = "dgvDonadores";
            this.dgvDonadores.Size = new System.Drawing.Size(716, 321);
            this.dgvDonadores.TabIndex = 87;
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
            this.txtConsultar.Location = new System.Drawing.Point(20, 299);
            this.txtConsultar.MaxLength = 50;
            this.txtConsultar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsultar.Multiline = false;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(647, 50);
            this.txtConsultar.TabIndex = 89;
            this.txtConsultar.Text = "";
            this.txtConsultar.TrailingIcon = null;
            // 
            // picBuscar
            // 
            this.picBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBuscar.Enabled = false;
            this.picBuscar.Image = global::Proyecto.Properties.Resources.buscar_personal;
            this.picBuscar.Location = new System.Drawing.Point(682, 299);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(56, 50);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 90;
            this.picBuscar.TabStop = false;
            // 
            // frmDonadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(750, 700);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.dgvDonadores);
            this.Controls.Add(this.dtpDonadores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblPlataforma);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtRedesSociales);
            this.Controls.Add(this.lblRedesSociales);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombreDonadores);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblTeléfono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDonadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox txtNombreDonadores;
        private System.Windows.Forms.TextBox lblCorreo;
        private System.Windows.Forms.TextBox lblNombre;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private System.Windows.Forms.TextBox lblNacionalidad;
        private System.Windows.Forms.TextBox lblTeléfono;
        private System.Windows.Forms.TextBox lblRedesSociales;
        private MaterialSkin.Controls.MaterialTextBox txtRedesSociales;
        private MaterialSkin.Controls.MaterialTextBox txtNacionalidad;
        private MaterialSkin.Controls.MaterialTextBox txtPlataforma;
        private System.Windows.Forms.TextBox lblPlataforma;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpDonadores;
        private System.Windows.Forms.DataGridView dgvDonadores;
        private MaterialSkin.Controls.MaterialTextBox txtConsultar;
        private System.Windows.Forms.PictureBox picBuscar;
    }
}
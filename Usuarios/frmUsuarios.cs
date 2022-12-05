using IronRuby.StandardLibrary.Yaml;
using Proyecto.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Usuarios
{
    public partial class frmUsuarios : Form
    {
        Metodos.Usuarios usuarios = new Metodos.Usuarios();
        public string Usuario;
        public frmUsuarios()
        {
            InitializeComponent();
            usuarios.consultarUsuarios(dgvUsuarios, txtConsultar, cbxBusqueda);
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picMaximizar.Visible = false;
            picRestaurar.Visible = true;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaximizar.Visible = true;
            
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Usuario = Usuario;
            menu.Show();
            this.Hide();
        }

        private void cbxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxEmpleados_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbxEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEncargado.Checked == true)
            {
                cbxAdmin.Enabled = false;
            }
            if (cbxEncargado.Checked == false)
            {
                cbxAdmin.Enabled = true;
                cbxBiblioteca.Checked=false;
                cbxInventario.Checked=false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            usuarios.registrarUsuarios(txtNombre,txtContraseña, txtDniEmpleado, cbxAdmin,cbxEncargado,cbxBiblioteca,cbxInventario);
            usuarios.consultarUsuarios(dgvUsuarios, txtConsultar, cbxBusqueda);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrUsuarios_Tick(object sender, EventArgs e)
        {
            
        }

        private void cbxBiblioteca_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBiblioteca.Checked==true)
            {
                cbxEncargado.Checked=true;
            }
        }

        private void cbxInventario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxInventario.Checked == true)
            {
                cbxEncargado.Checked = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            usuarios.eliminarUsuario(txtNombre, txtContraseña, txtDniEmpleado, cbxAdmin, cbxEncargado, cbxBiblioteca, cbxInventario);
            usuarios.consultarUsuarios(dgvUsuarios, txtConsultar, cbxBusqueda);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            usuarios.modificarUsuarios(txtNombre, txtContraseña, txtDniEmpleado, cbxAdmin, cbxEncargado, cbxBiblioteca, cbxInventario);
            usuarios.consultarUsuarios(dgvUsuarios, txtConsultar, cbxBusqueda);
        }

        private void cbxAdmin_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxAdmin.Checked == true)
            {
                cbxBiblioteca.Checked = false;
                cbxEncargado.Checked = false;
                cbxInventario.Checked = false;
                cbxBiblioteca.Enabled = false;
                cbxEncargado.Enabled = false;
                cbxInventario.Enabled = false;
            }
            if (cbxAdmin.Checked == false)
            {
                cbxBiblioteca.Enabled = true;
                cbxEncargado.Enabled = true;
                cbxInventario.Enabled = true;
            }
        }

        private void picBusquedaPR_Click(object sender, EventArgs e)
        {
            
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            usuarios.consultarUsuarios(dgvUsuarios, txtConsultar, cbxBusqueda);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
                txtDniEmpleado.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
            }
            catch (Exception)
            {
                txtNombre.Text = "";
                txtDniEmpleado.Text = "";
                MessageBox.Show("Selecciona según la fila deseada.", "Ventana informativa");
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            usuarios.consultarUsuarios(dgvUsuarios, txtConsultar, cbxBusqueda);
        }
    }
}

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

namespace Proyecto.Clientes
{
    public partial class frmClientes : Form
    {
        Metodos.Clientes clientes = new Metodos.Clientes();
        ErrorProvider error = new ErrorProvider();
        public frmClientes()
        {
            InitializeComponent();
            clientes.consultarClientes(dgvClientes, txtConsultar, cbxBusqueda);
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void picMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picMaximizar.Visible = false;
            picRestaurar.Visible = true;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            menu.Show();
            this.Hide();
        }

        private void txtDniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clientes.registrarClientes(txtID, txtDniCliente, txtNombre, txtApellidos, txtDireccion, txtTelefono);
            clientes.consultarClientes(dgvClientes, txtConsultar, cbxBusqueda);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clientes.modificarClientes(txtID, txtDniCliente, txtNombre, txtApellidos, txtDireccion, txtTelefono);
            clientes.consultarClientes(dgvClientes, txtConsultar, cbxBusqueda);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clientes.eliminarClientes(txtID, txtDniCliente, txtNombre, txtApellidos, txtDireccion, txtTelefono);
            clientes.consultarClientes(dgvClientes, txtConsultar, cbxBusqueda);
        }

        private void picBusquedaPR_Click(object sender, EventArgs e)
        {
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            clientes.consultarClientes(dgvClientes, txtConsultar, cbxBusqueda);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvClientes.SelectedCells[0].Value.ToString();
                txtDniCliente.Text = dgvClientes.SelectedCells[1].Value.ToString();
                txtNombre.Text = dgvClientes.SelectedCells[2].Value.ToString();
                txtApellidos.Text = dgvClientes.SelectedCells[3].Value.ToString();
                txtDireccion.Text = dgvClientes.SelectedCells[4].Value.ToString();
                txtTelefono.Text = dgvClientes.SelectedCells[5].Value.ToString();
            }
            catch (Exception)
            {
                txtID.Text = "";
                txtDniCliente.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                MessageBox.Show("Selecciona según la fila deseada.", "Ventana informativa");
            }
        }

        private void cbxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            clientes.consultarClientes(dgvClientes, txtConsultar, cbxBusqueda);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mostrar el error
            bool validar = Metodos.Validaciones.soloNumeros(e);
            if (!validar)
            {
                error.SetError(txtID, "Solo numeros");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mostrar el error
            bool validar = Metodos.Validaciones.soloNumeros(e);
            if (!validar)
            {
                error.SetError(txtTelefono, "Solo numeros");
            }
            else
            {
                error.Clear();
            }
        }
    }
}

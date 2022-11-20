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

namespace Proyecto.Empleados
{
    public partial class frmEmpleados : Form
    {
        Metodos.Empleados empleados = new Metodos.Empleados();
        public frmEmpleados()
        {
            InitializeComponent();
            empleados.consultarEmpleados(dgvEmpleados);
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

        private void picAtras_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaximizar.Visible = true;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            tmrTiempo.Start();
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            empleados.consultarEmpleados(dgvEmpleados);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            empleados.registrarEmpleados(txtID,txtDniEmpleado,txtNombre,txtApellidos,txtDireccion,txtTelefono,txtCorreo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            empleados.modificarEmpleados(txtID, txtDniEmpleado, txtNombre, txtApellidos, txtDireccion, txtTelefono, txtCorreo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            empleados.eliminarEmpleados(txtID, txtDniEmpleado, txtNombre, txtApellidos, txtDireccion, txtTelefono, txtCorreo);
        }
    }
}

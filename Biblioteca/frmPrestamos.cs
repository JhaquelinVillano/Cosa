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

namespace Proyecto.Biblioteca
{
    public partial class frmPrestamos : Form
    {
        Metodos.Prestamos prestamos = new Metodos.Prestamos();
        ErrorProvider error = new ErrorProvider();
        public string Usuario;
        public frmPrestamos()
        {
            InitializeComponent();
            prestamos.consultarPrestamos(dgvP, txtConsultar, cbxBusqueda);
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
            menu.Usuario = Usuario;
            menu.Show();
            this.Hide();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            prestamos.registrarPrestamos(txtLibroID,txtNombreSolicitante,Usuario,txtPrestamoID);
            prestamos.consultarPrestamos(dgvP, txtConsultar, cbxBusqueda);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            prestamos.EliminarPrestamos(txtLibroID, txtNombreSolicitante,txtPrestamoID);
            prestamos.consultarPrestamos(dgvP, txtConsultar, cbxBusqueda);
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            prestamos.hacerDevolucion(txtLibroID, txtNombreSolicitante, txtPrestamoID,Usuario);
            prestamos.consultarPrestamos(dgvP, txtConsultar, cbxBusqueda);
        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picBusquedaPR_Click(object sender, EventArgs e)
        {
            
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            prestamos.consultarPrestamos(dgvP, txtConsultar, cbxBusqueda);
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            prestamos.consultarPrestamos(dgvP, txtConsultar, cbxBusqueda);
        }

        private void txtPrestamoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrestamoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mostrar el error
            bool validar = Metodos.Validaciones.soloNumeros(e);
            if (!validar)
            {
                error.SetError(txtPrestamoID, "Solo numeros");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtLibroID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mostrar el error
            bool validar = Metodos.Validaciones.soloNumeros(e);
            if (!validar)
            {
                error.SetError(txtLibroID, "Solo numeros");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtNombreSolicitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mostrar el error
            bool validar = Metodos.Validaciones.soloNumeros(e);
            if (!validar)
            {
                error.SetError(txtNombreSolicitante, "Solo numeros");
            }
            else
            {
                error.Clear();
            }
        }
    }
}

using Proyecto.Menu;
using Proyecto.Metodos;
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
    public partial class frmDevoluciones : Form
    {
        Metodos.Devoluciones devoluciones = new Metodos.Devoluciones();
        public frmDevoluciones()
        {
            InitializeComponent();
            devoluciones.consultarDevoluciones(dgvDevoluciones, txtConsultar, cbxBusqueda);
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

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaximizar.Visible = true;
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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            devoluciones.consultarDevoluciones(dgvDevoluciones, txtConsultar, cbxBusqueda);
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            devoluciones.consultarDevoluciones(dgvDevoluciones, txtConsultar, cbxBusqueda);
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {

        }
    }
}

using Proyecto.Entradas_y_Salidas;
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

namespace Proyecto.Inventario
{
    public partial class frmInventario : Form
    {
        Metodos.Inventa inventario = new Metodos.Inventa();
        Excel export = new Excel();
        public frmInventario()
        {
            InitializeComponent();
            inventario.actualizarInventario(dgvInventario);
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

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            frmEntradas entra = new frmEntradas();
            entra.Show();
            this.Hide();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            frmSalidas salidas = new frmSalidas();
            salidas.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void picExcel_Click(object sender, EventArgs e)
        {   //Llamando metodo
            export.exportar(dgvInventario);
        }
    }
}

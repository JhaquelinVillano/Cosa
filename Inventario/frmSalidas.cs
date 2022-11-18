using MySql.Data.MySqlClient;
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

namespace Proyecto.Entradas_y_Salidas
{
    public partial class frmSalidas : Form
    {   //LLamando clases
        Metodos.Inventa inventario = new Metodos.Inventa();
        public frmSalidas()
        {
            InitializeComponent();
            inventario.cargarCategorias(cbxNombreArticulo);
            inventario.cargarID(cbxID);
            inventario.actualizarSalida(dgvSalidas);
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

        private void limpiar()
        {
            txtCantidad.Text = "";
            txtConsultar.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string fechita = "";
            //Convirtiendo fecha a string
            DateTime fecha = DateTime.Today;
            //Guardando la fecha en dato tipo string con formato
            fechita = fecha.ToShortDateString().ToString();
            //Metodo
            inventario.registroSalida(cbxNombreArticulo.Text, int.Parse(txtCantidad.Text), fechita);
            inventario.actualizarSalida(dgvSalidas);
            inventario.cargarID(cbxID);
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string fechita = "";
            //Convirtiendo fecha a string
            DateTime fecha = DateTime.Today;
            //Guardando la fecha en dato tipo string con formato
            fechita = fecha.ToShortDateString().ToString();
            inventario.modificarSalida(int.Parse(cbxID.Text), cbxNombreArticulo.Text, int.Parse(txtCantidad.Text), fechita);
            inventario.cargarID(cbxID);
            inventario.actualizarSalida(dgvSalidas);
            limpiar();
        }

        private void cbxNombreArticulo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxNombreArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.eliminarSalidas(int.Parse(cbxID.Text));
            inventario.cargarID(cbxID);
            inventario.actualizarSalida(dgvSalidas);
            limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}

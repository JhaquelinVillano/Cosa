using MySql.Data.MySqlClient;
using Proyecto.Inventario;
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
        ErrorProvider error = new ErrorProvider();
        public string Usuario;
        public frmSalidas()
        {
            InitializeComponent();
            inventario.cargarCategorias(cbxNombreArticulo, cbxID);
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
            menu.Usuario = Usuario;
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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string fechita = "";
            //Convirtiendo fecha a string
            DateTime fecha = DateTime.Today;
            //Guardando la fecha en dato tipo string con formato
            fechita = fecha.ToShortDateString().ToString();
            //Metodo
            inventario.registroSalida(cbxID.Text, cbxNombreArticulo.Text, int.Parse(txtCantidad.Text), fechita);
            inventario.actualizarSalida(dgvSalidas);
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string fechita = "";
            //Convirtiendo fecha a string
            DateTime fecha = DateTime.Today;
            //Guardando la fecha en dato tipo string con formato
            fechita = fecha.ToShortDateString().ToString();
            inventario.modificarSalida(cbxID.Text, cbxNombreArticulo.Text, int.Parse(txtCantidad.Text), fechita);
            inventario.actualizarSalida(dgvSalidas);
            limpiar();
        }

        private void cbxNombreArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.eliminarSalidas(cbxNombreArticulo.Text);
            inventario.actualizarSalida(dgvSalidas);
            limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void dgvSalidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                cbxID.Text = dgvSalidas.SelectedCells[0].Value.ToString();
            txtCantidad.Text = dgvSalidas.SelectedCells[2].Value.ToString();
        }catch (Exception)
            {
                cbxID.Text = "";
                txtCantidad.Text = "";
                MessageBox.Show("Selecciona según la fila deseada.", "Ventana informativa");
            }
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {   //Si esta vacio le ingresamos los valores
            if (txtConsultar.Text != "")
            {
                dgvSalidas.DataSource = inventario.busqueda("select * from `salidas` where " +
                    "`id_salidas` like '%" + txtConsultar.Text + "%' or nombreArticulo_s like '%" + txtConsultar.Text + "' " +
                    " or fecha_s like '%" + txtConsultar.Text + "%'");

            }//Dado caso que no entre, que nos actualize la pagina
            else
            {
                inventario.actualizarSalida(dgvSalidas);
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (Validaciones.vacios(txtCantidad))
            {
                error.SetError(txtCantidad, "No puede dejar vacio!");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mostrar el error
            bool validar = Validaciones.soloNumeros(e);
            if (!validar)
            {
                error.SetError(txtCantidad, "Solo numeros");
            }
            else
            {
                error.Clear();
            }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            //Si esta vacio le ingresamos los valores
            if (txtConsultar.Text != "")
            {
                dgvSalidas.DataSource = inventario.busqueda("select * from `salidas` where " +
                    "`id_salidas` like '%" + txtConsultar.Text + "%' or nombreArticulo_s like '%" + txtConsultar.Text + "' " +
                    " or fecha_s like '%" + txtConsultar.Text + "%'");

            }//Dado caso que no entre, que nos actualize la pagina
            else
            {
                inventario.actualizarSalida(dgvSalidas);
            }
        }
    }
}

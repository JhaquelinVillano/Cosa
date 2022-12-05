using MaterialSkin.Controls;
using Microsoft.Ajax.Utilities;
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

namespace Proyecto.Inventario
{
    public partial class frmEntradas : Form
    {   //LLamando clases
        Metodos.Inventa inventario = new Metodos.Inventa();
        Excel export = new Excel();
        ErrorProvider error = new ErrorProvider();
        public string Usuario;

        public frmEntradas()
        {
            InitializeComponent();
            inventario.actualizarEntrada(dgvEntradas);
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Usuario = Usuario;
            menu.Show();
            this.Hide();
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

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picRestaurar.Visible = false;
            picMaximizar.Visible = true;
        }

        private void pnlInventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string tipo = "";
            if (rbtnCompra.Checked == true)
            {   //Si esta activo lo pasamos a la variable tipo
                tipo = rbtnCompra.Text;
            }
            else if (rbtnDonacion.Checked == true)
            {   //Si esta activo lo pasamos a la variable tipo
                tipo = rbtnDonacion.Text;
            }
            //LLamando metodo
            inventario.ingresarEntrada(txtCodigo.Text,
                                txtNombre.Text,
                                int.Parse(txtCantidad.Text),
                                txtDescripcion.Text,
                                tipo);
            inventario.ingresarInventario(txtCodigo.Text,
                                txtNombre.Text,
                                int.Parse(txtCantidad.Text));
            inventario.actualizarEntrada(dgvEntradas);
            limpiar();
        }

        private void picExcel_Click(object sender, EventArgs e)
        {   //Llamando metodo
            export.exportar(dgvEntradas);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string tipo = "";
            //Checando que boton utilizar
            if (rbtnCompra.Checked == true)
            {   //Si esta activo lo pasamos a la variable tipo
                tipo = rbtnCompra.Text;
            }
            else if (rbtnDonacion.Checked == true)
            {   //Si esta activo lo pasamos a la variable tipo
                tipo = rbtnDonacion.Text;
            }
            //Llamando metodos
            inventario.modificarEntrada(txtCodigo.Text,
                                txtNombre.Text,
                                int.Parse(txtCantidad.Text),
                                txtDescripcion.Text,
                                tipo);
            //Modificacion para el inventario
            inventario.modificarInventario(txtCodigo.Text,
                                txtNombre.Text,
                                int.Parse(txtCantidad.Text));
            inventario.actualizarEntrada(dgvEntradas);
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   //Metodos
            inventario.eliminarEntradas(txtCodigo.Text);
            inventario.eliminarInventario(txtCodigo.Text);
            inventario.actualizarEntrada(dgvEntradas);
            limpiar();
        }

        private void limpiar()
        {
            txtCantidad.Clear();
            txtCodigo.Clear();
            txtConsultar.Clear();
            txtDescripcion.Clear();
            txtNombre.Clear();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void txtConsultar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmEntradas_Load(object sender, EventArgs e)
        {

        }

        private void dgvEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //Rellenar celdas con informacion
            try {
            txtCodigo.Text = dgvEntradas.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvEntradas.SelectedCells[1].Value.ToString();
            txtCantidad.Text = dgvEntradas.SelectedCells[2].Value.ToString();
            txtDescripcion.Text = dgvEntradas.SelectedCells[3].Value.ToString();
        }catch (Exception)
            {
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtCantidad.Text = "";
                txtDescripcion.Text = "";
                MessageBox.Show("Selecciona según la fila deseada.", "Ventana informativa");
            }
}

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {   //Si esta vacio le ingresamos los valores
            if (txtConsultar.Text != "") {
                dgvEntradas.DataSource = inventario.busqueda("select * from `entradas` where " +
                    "`codigoArticulo_e` like '%" + txtConsultar.Text + "%' or nombreArticulo_e like '%" + txtConsultar.Text + "' " +
                    " or descripcion_e like '%" + txtConsultar.Text + "%' or fecha_e like '%" + 
                    txtConsultar.Text + "%' or tipo_e like '%" + txtConsultar.Text + "%'");
                
            }//Dado caso que no entre, que nos actualize la pagina
            else
            {
                inventario.actualizarEntrada(dgvEntradas);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {   

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (Validaciones.vacios(txtCodigo))
            {
                error.SetError(txtCodigo, "No puede dejar vacio!");
            }
            else
            {
                error.Clear();
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (Validaciones.vacios(txtNombre))
            {
                error.SetError(txtNombre, "No puede dejar vacio!");
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSumar_Click(object sender, EventArgs e)
        {
            inventario.sumarEntrada(txtCodigo.Text, int.Parse(txtCantidad.Text));
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            //Si esta vacio le ingresamos los valores
            if (txtConsultar.Text != "")
            {
                dgvEntradas.DataSource = inventario.busqueda("select * from `entradas` where " +
                    "`codigoArticulo_e` like '%" + txtConsultar.Text + "%' or nombreArticulo_e like '%" + txtConsultar.Text + "' " +
                    " or descripcion_e like '%" + txtConsultar.Text + "%' or fecha_e like '%" +
                    txtConsultar.Text + "%' or tipo_e like '%" + txtConsultar.Text + "%'");

            }//Dado caso que no entre, que nos actualize la pagina
            else
            {
                inventario.actualizarEntrada(dgvEntradas);
            }
        }
    }
}

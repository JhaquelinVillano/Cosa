using MaterialSkin.Controls;
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
        Propiedades propie = new Propiedades();

        public frmEntradas()
        {
            InitializeComponent();
            inventario.actualizarEntrada(dgvEntradas);
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
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
            string fechita = "";

            if (rbtnCompra.Checked == true)
            {   //Si esta activo lo pasamos a la variable tipo
                tipo = rbtnCompra.Text;
            }
            else if (rbtnDonacion.Checked == true)
            {   //Si esta activo lo pasamos a la variable tipo
                tipo = rbtnDonacion.Text;
            }
            //Convirtiendo fecha a string
            DateTime fecha = DateTime.Today;
            //Guardando la fecha en dato tipo string con formato
            fechita = fecha.ToShortDateString().ToString();
            //Propiedades
            propie.CodigoArticulo = txtCodigo.Text;
            propie.NombreArticulo = txtNombre.Text;
            propie.Cantidad = Convert.ToInt32(txtCantidad.Text);
            //LLamando metodo
            inventario.ingresarEntrada(propie.CodigoArticulo,
                                propie.NombreArticulo,
                                propie.Cantidad,
                                txtDescripcion.Text,
                                tipo,
                                fechita);
            inventario.actualizarEntrada(dgvEntradas);
        }

        private void picExcel_Click(object sender, EventArgs e)
        {   //Llamando metodo
            export.exportar(dgvEntradas);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string tipo = "";
            string fechita = "";
            //Checando que boton utilizar
            if (rbtnCompra.Checked == true)
            {   //Si esta activo lo pasamos a la variable tipo
                tipo = rbtnCompra.Text;
            }
            else if (rbtnDonacion.Checked == true)
            {   //Si esta activo lo pasamos a la variable tipo
                tipo = rbtnDonacion.Text;
            }
            //Convirtiendo fecha a string
            DateTime fecha = DateTime.Today;
            //Guardando la fecha en dato tipo string con formato
            fechita = fecha.ToShortDateString().ToString();
            //Llamando metodos
            inventario.modificarEntrada(txtCodigo.Text,
                                txtNombre.Text,
                                int.Parse(txtCantidad.Text),
                                txtDescripcion.Text,
                                tipo,
                                fechita);
            inventario.actualizarEntrada(dgvEntradas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   //Metodos
            inventario.eliminarEntradas(txtCodigo.Text);
            inventario.actualizarEntrada(dgvEntradas);
        }
    }
}

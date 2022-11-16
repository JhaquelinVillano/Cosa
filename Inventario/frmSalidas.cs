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
        Excel export = new Excel();
        MySqlConnection conexionDB = Conexion.conexion();
        public frmSalidas()
        {
            InitializeComponent();
            inventario.cargarCategorias(cbxNombreArticulo);
            txtCodigo.Enabled = false;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string fechita = "";
            //Convirtiendo fecha a string
            DateTime fecha = DateTime.Today;
            //Guardando la fecha en dato tipo string con formato
            fechita = fecha.ToShortDateString().ToString();
            //Metodo
            inventario.registroSalida(cbxNombreArticulo.Text, txtCodigo.Text, int.Parse(txtCantidad.Text), fechita);
            inventario.actualizarSalida(dgvSalidas);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {   //Declarando variable para los radio buttons
            string fechita = "";
            //Convirtiendo fecha a string
            DateTime fecha = DateTime.Today;
            //Guardando la fecha en dato tipo string con formato
            fechita = fecha.ToShortDateString().ToString();
            inventario.modificarSalida(cbxNombreArticulo.Text, txtCodigo.Text, int.Parse(txtCantidad.Text), fechita);
            inventario.actualizarSalida(dgvSalidas);
        }

        private void cbxNombreArticulo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxNombreArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //inventario.RellenarSalida(cbxNombreArticulo.Text, txtCodigo.Text); 
            string sql = "select * from entradas where nombreArticulo_e='" + cbxNombreArticulo.Text + "'";
            try
            {
                conexionDB.Open();
                //Ejecutando comando
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.Read() == true)
                {   //Agarrando variable de la base
                    txtCodigo.Text = dr["codigoArticulo_e"].ToString();
                }
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.eliminarSalidas(txtCodigo.Text);
        }
    }
}

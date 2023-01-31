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
using MySql.Data.MySqlClient;

namespace Proyecto.Biblioteca
{
    public partial class frmLibros : Form
    {
        Metodos.Libros libros = new Metodos.Libros();
        ErrorProvider error = new ErrorProvider();
        public string Usuario;
        public frmLibros()
        {
            InitializeComponent();
            libros.consultarLibros(dgvLibros, txtConsultar, cbxBusqueda);
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            libros.consultarLibros(dgvLibros, txtConsultar, cbxBusqueda);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            libros.registrarLibros(txtID,txtNombre,txtAutor,cbxCategoria,cbxIdioma,txtEdicion,txtExistencias);
            libros.consultarLibros(dgvLibros, txtConsultar, cbxBusqueda);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            libros.eliminarLibros(txtID, txtNombre, txtAutor, cbxCategoria, cbxIdioma, txtEdicion, txtExistencias);
            libros.consultarLibros(dgvLibros, txtConsultar, cbxBusqueda);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            libros.modificarLibros(txtID, txtNombre, txtAutor, cbxCategoria, cbxIdioma, txtEdicion, txtExistencias);
            libros.consultarLibros(dgvLibros, txtConsultar, cbxBusqueda);
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvLibros.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvLibros.SelectedCells[1].Value.ToString();
                txtAutor.Text = dgvLibros.SelectedCells[2].Value.ToString();
                cbxCategoria.Text = dgvLibros.SelectedCells[3].Value.ToString();
                cbxIdioma.Text = dgvLibros.SelectedCells[4].Value.ToString();
                txtEdicion.Text = dgvLibros.SelectedCells[5].Value.ToString();
                txtExistencias.Text = dgvLibros.SelectedCells[6].Value.ToString();
            }catch (Exception)
            {
                txtID.Text = "";
                txtNombre.Text = "";
                txtAutor.Text = "";
                txtEdicion.Text = "";
                txtExistencias.Text = "";
                MessageBox.Show("Selecciona según la fila deseada.", "Ventana informativa");
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            libros.consultarLibros(dgvLibros, txtConsultar, cbxBusqueda);
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

        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mostrar el error
            bool validar = Metodos.Validaciones.soloNumeros(e);
            if (!validar)
            {
                error.SetError(txtExistencias, "Solo numeros");
            }
            else
            {
                error.Clear();
            }
        }
    }
}

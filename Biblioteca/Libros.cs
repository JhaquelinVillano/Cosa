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
        public frmLibros()
        {
            InitializeComponent();
            libros.consultarLibros(dgvLibros);
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

        private void pnlBiblioteca_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            tmrTiempo.Start();
        }

        private void picBiblioteca_Click(object sender, EventArgs e)
        {

        }

        private void lblBiblioteca_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreBiblioteca_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpBiblioteca_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvBiblioteca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtConsultar.Text=="")
            {
                libros.consultarLibros(dgvLibros);
            }
            if (txtConsultar.Text!="")
            {

            }
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            libros.registrarLibros(txtID,txtNombre,txtAutor,cbxCategoria,cbxIdioma,txtEdicion,txtExistencias);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            libros.eliminarLibros(txtID, txtNombre, txtAutor, cbxCategoria, cbxIdioma, txtEdicion, txtExistencias);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            libros.modificarLibros(txtID, txtNombre, txtAutor, cbxCategoria, cbxIdioma, txtEdicion, txtExistencias);
        }
    }
}

using Proyecto.Biblioteca;
using Proyecto.Donadores;
using Proyecto.Entradas_y_Salidas;
using Proyecto.Inventario;
using Proyecto.Restauración;
using Proyecto.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Menu
{
    public partial class frmMenu : Form
    {
        public string Usuario;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios Usuarios = new frmUsuarios();
            Usuarios.Show();
            this.Hide();

        }

        private void picRestauracion_Click(object sender, EventArgs e)
        {
            frmRestauracion Restauracion = new frmRestauracion();
            Restauracion.Show();
            this.Hide();
        }

        private void picInventario_Click(object sender, EventArgs e)
        {
            frmEntradas Inventario = new frmEntradas();
            Inventario.Show();
            this.Hide();
        }

        private void picDonadores_Click(object sender, EventArgs e)
        {
            frmDonadores Donadores = new frmDonadores();
            Donadores.Show();
            this.Hide();
        }

        private void picCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void picLibros_Click(object sender, EventArgs e)
        {
            frmLibros Libros= new frmLibros();
            Libros.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void picPD_Click(object sender, EventArgs e)
        {
            frmPrestamos PD = new frmPrestamos();
            PD.Usuario = Usuario;
            PD.Show();
            this.Hide();
        }

        private void picEmpleados_Click(object sender, EventArgs e)
        {
            Empleados.frmEmpleados empleados = new Empleados.frmEmpleados();
            empleados.Show();
            this.Hide();
        }

        private void picSalidas_Click(object sender, EventArgs e)
        {
            frmSalidas salidas = new frmSalidas();
            salidas.Show();
            this.Hide();
        }

        private void picClientes_Click(object sender, EventArgs e)
        {
            Clientes.frmClientes clientes = new Clientes.frmClientes();
            clientes.Show();
            this.Hide();
        }

        private void picInventario_Click_1(object sender, EventArgs e)
        {
            Inventario.frmInventario inventarios = new frmInventario();
            inventarios.Show();
            this.Hide();
        }

        private void picDevoluciones_Click(object sender, EventArgs e)
        {
            frmDevoluciones devoluciones = new frmDevoluciones();
            devoluciones.Show();
            this.Hide();
        }
    }
}

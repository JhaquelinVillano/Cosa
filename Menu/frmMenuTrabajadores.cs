using Proyecto.Inventario;
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
    public partial class frmMenuTrabajadores : Form
    {
        public string Usuario;
        public string Rol;
        public string biblioteca;
        public string inventario;
        public frmMenuTrabajadores()
        {
            InitializeComponent();
        }
        //Controles del panel
            //Cierra todo el proyecto
        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
            //Minimiza el proyecto
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picInventario_Click(object sender, EventArgs e)
        {
            frmEntradas Inventario = new frmEntradas();
            Inventario.Show();
            this.Hide();
        }

        private void picDonadores_Click(object sender, EventArgs e)
        {

        }

        private void picBiblioteca_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuTrabajodores_Load(object sender, EventArgs e)
        {

        }
        //Regresa a inicio de sesion
        private void picCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

    }
}

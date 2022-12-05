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

namespace Proyecto.Restauración
{
    public partial class frmRestauracion : Form
    {
        Respaldo respaldito = new Respaldo();
        public string Usuario;
        public frmRestauracion()
        {
            InitializeComponent();
        }

        private void frmRestauracion_Load(object sender, EventArgs e)
        {

        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void picMin_Click(object sender, EventArgs e)
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

        private void btnCopia_Click(object sender, EventArgs e)
        {
            respaldito.restaurar();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {   //LLamando metodo para respaldar
            respaldito.respaldar(txtdireccion.Text);
        }
    }
}

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

namespace Proyecto.Biblioteca
{
    public partial class frmDevoluciones : Form
    {
        Metodos.Devoluciones devoluciones = new Metodos.Devoluciones();
        public string Usuario;
        public frmDevoluciones()
        {
            InitializeComponent();
            devoluciones.consultarDevoluciones(dgvDevoluciones, txtConsultar, cbxBusqueda);
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            devoluciones.consultarDevoluciones(dgvDevoluciones, txtConsultar, cbxBusqueda);
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            devoluciones.consultarDevoluciones(dgvDevoluciones, txtConsultar, cbxBusqueda);
        }
    }
}

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
using Org.BouncyCastle.Pkix;
using Proyecto.Menu;
using Proyecto.Metodos;

namespace Proyecto
{
    public partial class frmLogin : Form
    {
        Login login = new Login();
        public frmLogin()
        {
            InitializeComponent();
        }
        public int verificar=0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picLoginCirculo_Click(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void picMinimizarLogin_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
        
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
         
        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            login.iniciarSesion(txtUsuario.Text,txtContraseña.Text);
            if (login.verificar==1)
            {
                this.Hide();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void picLogo_Click_1(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

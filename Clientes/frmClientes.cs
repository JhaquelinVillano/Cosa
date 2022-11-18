﻿using Proyecto.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Clientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
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

        private void txtDniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //tmrTiempo.Start();
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            Metodos.Clientes clientes = new Metodos.Clientes();
            clientes.consultarClientes(dgvClientes);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Metodos.Clientes clientes = new Metodos.Clientes();
            clientes.registrarClientes(txtID, txtDniCliente, txtNombre, txtApellidos, txtDireccion, txtTelefono);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Metodos.Clientes clientes = new Metodos.Clientes();
            clientes.modificarClientes(txtID, txtDniCliente, txtNombre, txtApellidos, txtDireccion, txtTelefono);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Metodos.Clientes clientes = new Metodos.Clientes();
            clientes.eliminarClientes(txtID, txtDniCliente, txtNombre, txtApellidos, txtDireccion, txtTelefono);
        }
    }
}

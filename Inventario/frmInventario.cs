﻿using MySql.Data.MySqlClient;
using Proyecto.Entradas_y_Salidas;
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
    public partial class frmInventario : Form
    {
        Metodos.Inventa inventario = new Metodos.Inventa();
        Excel export = new Excel();
        public string Usuario;
        public frmInventario()
        {
            InitializeComponent();
            inventario.actualizarInventario(dgvInventario);
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
            menu.Usuario = Usuario;
            menu.Show();
            this.Hide();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            frmEntradas entra = new frmEntradas();
            entra.Show();
            this.Hide();
        }


        private void picExcel_Click(object sender, EventArgs e)
        {   //Llamando metodo
            export.exportar(dgvInventario);
        }


        private void lblInventario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
        }

        private void txtConsultar_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {   //Si esta vacio le ingresamos los valores
            if (txtConsultar.Text != "")
            {
                dgvInventario.DataSource = inventario.busqueda("select * from `productos` where " +
                    "`codigo_p` like '%" + txtConsultar.Text + "%' or nombreArticulo_p like '%" + txtConsultar.Text + "' " +
                    " or existencias_p like '%" + txtConsultar.Text + "%'");

            }//Dado caso que no entre, que nos actualize la pagina
            else
            {
                inventario.actualizarSalida(dgvInventario);
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            //Si esta vacio le ingresamos los valores
            if (txtConsultar.Text != "")
            {
                dgvInventario.DataSource = inventario.busqueda("select * from `productos` where " +
                    "`codigo_p` like '%" + txtConsultar.Text + "%' or nombreArticulo_p like '%" + txtConsultar.Text + "' " +
                    " or existencias_p like '%" + txtConsultar.Text + "%'");

            }//Dado caso que no entre, que nos actualize la pagina
            else
            {
                inventario.actualizarSalida(dgvInventario);
            }
        }
    }
}

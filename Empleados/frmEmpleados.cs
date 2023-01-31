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

namespace Proyecto.Empleados
{
    public partial class frmEmpleados : Form
    {
        Metodos.Empleados empleados = new Metodos.Empleados();
        ErrorProvider error = new ErrorProvider();
        public string Usuario;
        public frmEmpleados()
        {
            InitializeComponent();
            empleados.consultarEmpleados(dgvEmpleados, txtConsultar, cbxBusqueda);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            empleados.registrarEmpleados(txtID,txtDniEmpleado,txtNombre,txtApellidos,txtDireccion,txtTelefono,txtCorreo);
            empleados.consultarEmpleados(dgvEmpleados, txtConsultar, cbxBusqueda);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            empleados.modificarEmpleados(txtID, txtDniEmpleado, txtNombre, txtApellidos, txtDireccion, txtTelefono, txtCorreo);
            empleados.consultarEmpleados(dgvEmpleados, txtConsultar, cbxBusqueda);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            empleados.eliminarEmpleados(txtID, txtDniEmpleado, txtNombre, txtApellidos, txtDireccion, txtTelefono, txtCorreo);
            empleados.consultarEmpleados(dgvEmpleados, txtConsultar, cbxBusqueda);
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            empleados.consultarEmpleados(dgvEmpleados, txtConsultar, cbxBusqueda);
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvEmpleados.SelectedCells[0].Value.ToString();
                txtDniEmpleado.Text = dgvEmpleados.SelectedCells[1].Value.ToString();
                txtNombre.Text = dgvEmpleados.SelectedCells[2].Value.ToString();
                txtApellidos.Text = dgvEmpleados.SelectedCells[3].Value.ToString();
                txtDireccion.Text = dgvEmpleados.SelectedCells[4].Value.ToString();
                txtTelefono.Text = dgvEmpleados.SelectedCells[5].Value.ToString();
                txtCorreo.Text = dgvEmpleados.SelectedCells[6].Value.ToString();
            }
            catch (Exception)
            {
                txtID.Text = "";
                txtDniEmpleado.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                MessageBox.Show("Selecciona según la fila deseada.", "Ventana informativa");
            }
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            empleados.consultarEmpleados(dgvEmpleados, txtConsultar, cbxBusqueda);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Mostrar el error
            bool validar = Metodos.Validaciones.soloNumeros(e);
            if (!validar)
            {
                error.SetError(txtTelefono, "Solo numeros");
            }
            else
            {
                error.Clear();
            }
        }
    }
}

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

namespace Proyecto.Metodos
{
    internal class Clientes
    {
        internal void consultarClientes(DataGridView dgvClientes)
        {
            try
            {
                MySqlConnection consultaDB = Conexion.conexion();
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;
                //Consultado datos 
                MySqlCommand command = new MySqlCommand("select * from clientes order by idCliente;", consultaDB);
                command.CommandType = CommandType.Text;
                consultaDB.Open();
                resultado = command.ExecuteReader();
                dataTable.Load(resultado);
                dgvClientes.DataSource = dataTable;
                consultaDB.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR ");
            }

        }
        internal void registrarClientes(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialTextBox txtNombre, MaterialSkin.Controls.MaterialTextBox txtApelido, MaterialSkin.Controls.MaterialTextBox txtDireccion, MaterialSkin.Controls.MaterialTextBox txtTelefono)
        {
            try
            {
                if (txtID.Text != "" || txtDNI.Text == "" || txtNombre.Text == "" || txtApelido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
                {
                    txtID.Text = "";
                    MessageBox.Show("Introduzca todos los datos, excepto el ID");
                    return;
                }
                if (txtID.Text == "" || txtDNI.Text != "" || txtNombre.Text != "" || txtApelido.Text != "" || txtDireccion.Text != "" || txtTelefono.Text != "")
                {
                    MySqlConnection conexionDB = Conexion.conexion();
                    DataTable dataTableAdmin = new DataTable();
                    MySqlDataReader resultadoAdmin;
                    //ingresando datos de nuevo cliente
                    MySqlCommand commandAdmin = new MySqlCommand("insert into clientes (idCliente,dni_cliente,nombre,apellido,direccion,telefono) values (default,'" + txtDNI.Text + "','" + txtNombre.Text + "','" + txtApelido.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "');", conexionDB);
                    commandAdmin.CommandType = CommandType.Text;
                    conexionDB.Open();
                    resultadoAdmin = commandAdmin.ExecuteReader();
                    dataTableAdmin.Load(resultadoAdmin);
                    conexionDB.Close();
                    txtApelido.Text = "";
                    txtDireccion.Text = "";
                    txtDNI.Text = "";
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    MessageBox.Show("El cliente se ha registrado correctamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos.");
            }
        }
        internal void modificarClientes(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialTextBox txtNombre, MaterialSkin.Controls.MaterialTextBox txtApelido, MaterialSkin.Controls.MaterialTextBox txtDireccion, MaterialSkin.Controls.MaterialTextBox txtTelefono)
        {
            try
            {
                if (MessageBox.Show("Quieres modificar este cliente?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtID.Text == "" || txtDNI.Text == "" || txtNombre.Text == "" || txtApelido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
                    {
                        MessageBox.Show("Introduzca todos los datos");
                        return;
                    }
                    if (txtID.Text != "" || txtDNI.Text != "" || txtNombre.Text != "" || txtApelido.Text != "" || txtDireccion.Text != "" || txtTelefono.Text != "")
                    {
                        MySqlConnection conexionDB = Conexion.conexion();
                        DataTable dataTableAdmin = new DataTable();
                        MySqlDataReader resultadoAdmin;
                        //modificando datos de clientes
                        MySqlCommand commandAdmin = new MySqlCommand("UPDATE clientes set dni_cliente='" + txtDNI.Text + "',nombre='" + txtNombre.Text + "',apellido='" + txtApelido.Text + "',direccion='" + txtDireccion.Text + "',telefono='" + txtTelefono.Text + "' WHERE idCliente='" + txtID.Text + "';", conexionDB);
                        commandAdmin.CommandType = CommandType.Text;
                        conexionDB.Open();
                        resultadoAdmin = commandAdmin.ExecuteReader();
                        dataTableAdmin.Load(resultadoAdmin);
                        conexionDB.Close();
                        txtApelido.Text = "";
                        txtDireccion.Text = "";
                        txtDNI.Text = "";
                        txtID.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";
                        MessageBox.Show("El cliente se ha modificado correctamente");
                    }
                }
                else
                {
                    txtApelido.Text = "";
                    txtDireccion.Text = "";
                    txtDNI.Text = "";
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    MessageBox.Show("No se modifico el cliente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos.");
            }
        }
        internal void eliminarClientes(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialTextBox txtNombre, MaterialSkin.Controls.MaterialTextBox txtApelido, MaterialSkin.Controls.MaterialTextBox txtDireccion, MaterialSkin.Controls.MaterialTextBox txtTelefono)
        {
            try
            {
                if (MessageBox.Show("Quieres eliminar este cliente?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtID.Text == "" || txtDNI.Text != "" || txtNombre.Text != "" || txtApelido.Text != "" || txtDireccion.Text != "" || txtTelefono.Text != "")
                    {
                        txtApelido.Text = "";
                        txtDireccion.Text = "";
                        txtDNI.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";
                        MessageBox.Show("Introduzca solo el ID.");
                        return;
                    }
                    if (txtID.Text != "" || txtDNI.Text == "" || txtNombre.Text == "" || txtApelido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
                    {
                        MySqlConnection conexionDB = Conexion.conexion();
                        DataTable dataTableAdmin = new DataTable();
                        MySqlDataReader resultadoAdmin;
                        //eliminando cliente
                        MySqlCommand commandAdmin = new MySqlCommand("DELETE FROM clientes WHERE idCliente='" + txtID.Text + "';", conexionDB);
                        commandAdmin.CommandType = CommandType.Text;
                        conexionDB.Open();
                        resultadoAdmin = commandAdmin.ExecuteReader();
                        dataTableAdmin.Load(resultadoAdmin);
                        conexionDB.Close();
                        txtApelido.Text = "";
                        txtDireccion.Text = "";
                        txtDNI.Text = "";
                        txtID.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";
                        //
                        MySqlConnection consultaDB2 = Conexion.conexion();
                        DataTable dataTable2 = new DataTable();
                        MySqlDataReader resultado2;
                        //Resetear el auto incremental de la tabla
                        MySqlCommand command2 = new MySqlCommand("alter table clientes AUTO_INCREMENT=1;", consultaDB2);
                        command2.CommandType = CommandType.Text;
                        consultaDB2.Open();
                        resultado2 = command2.ExecuteReader();
                        dataTable2.Load(resultado2);
                        consultaDB2.Close();
                        //
                        MessageBox.Show("El cliente se ha eliminado correctamente");
                    }
                }
                else
                {
                    txtApelido.Text = "";
                    txtDireccion.Text = "";
                    txtDNI.Text = "";
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    MessageBox.Show("No se elimino el cliente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica el ID. Recuerda que no se puede eliminar un cliente que tenga un prestamo.");
            }
        }
    }
}

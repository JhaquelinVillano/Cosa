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
    internal class Empleados
    {
        internal void consultarEmpleados(DataGridView dgvEmpleados)
        {
            try
            {
                MySqlConnection consultaDB = Conexion.conexion();
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;
                //Consultado datos 
                MySqlCommand command = new MySqlCommand("select * from empleados order by idEmpleado;", consultaDB);
                command.CommandType = CommandType.Text;
                consultaDB.Open();
                resultado = command.ExecuteReader();
                dataTable.Load(resultado);
                dgvEmpleados.DataSource = dataTable;
                consultaDB.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR ");
            }

        }
        internal void registrarEmpleados(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialTextBox txtNombre, MaterialSkin.Controls.MaterialTextBox txtApelido, MaterialSkin.Controls.MaterialTextBox txtDireccion, MaterialSkin.Controls.MaterialTextBox txtTelefono, MaterialSkin.Controls.MaterialTextBox txtCorreo)
        {
            try
            {
                if (txtID.Text != "" || txtDNI.Text == "" || txtNombre.Text == "" || txtApelido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
                {
                    txtID.Text = "";
                    MessageBox.Show("Introduzca todos los datos, excepto el ID");
                    return;
                }
                if (txtID.Text == "" || txtDNI.Text != "" || txtNombre.Text != "" || txtApelido.Text != "" || txtDireccion.Text != "" || txtTelefono.Text != "" || txtCorreo.Text != "")
                {
                    MySqlConnection conexionDB = Conexion.conexion();
                    DataTable dataTableAdmin = new DataTable();
                    MySqlDataReader resultadoAdmin;
                    //ingresando datos de nuevo usuario Admin
                    MySqlCommand commandAdmin = new MySqlCommand("insert into empleados (idEmpleado,dni_empleado,nombre,apellido,direccion,telefono,correo) values (default,'"+txtDNI.Text+"','"+txtNombre.Text+"','"+txtApelido.Text+"','"+txtDireccion.Text+"','"+txtTelefono.Text+"','"+txtCorreo.Text+"');", conexionDB);
                    commandAdmin.CommandType = CommandType.Text;
                    conexionDB.Open();
                    resultadoAdmin = commandAdmin.ExecuteReader();
                    dataTableAdmin.Load(resultadoAdmin);
                    conexionDB.Close();
                    txtApelido.Text = "";
                    txtCorreo.Text = "";
                    txtDireccion.Text = "";
                    txtDNI.Text = "";
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    MessageBox.Show("El empleado se ha registrado correctamente");
                }
            }catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos.");
            }
        }
        internal void modificarEmpleados(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialTextBox txtNombre, MaterialSkin.Controls.MaterialTextBox txtApelido, MaterialSkin.Controls.MaterialTextBox txtDireccion, MaterialSkin.Controls.MaterialTextBox txtTelefono, MaterialSkin.Controls.MaterialTextBox txtCorreo)
        {
            try
            {
                if (MessageBox.Show("Quieres modificar este empleado?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtID.Text == "" || txtDNI.Text == "" || txtNombre.Text == "" || txtApelido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
                    {
                        MessageBox.Show("Introduzca todos los datos");
                        return;
                    }
                    if (txtID.Text != "" || txtDNI.Text != "" || txtNombre.Text != "" || txtApelido.Text != "" || txtDireccion.Text != "" || txtTelefono.Text != "" || txtCorreo.Text != "")
                    {
                        MySqlConnection conexionDB = Conexion.conexion();
                        DataTable dataTableAdmin = new DataTable();
                        MySqlDataReader resultadoAdmin;
                        //ingresando datos de nuevo usuario Admin
                        MySqlCommand commandAdmin = new MySqlCommand("UPDATE empleados set dni_empleado='" + txtDNI.Text + "',nombre='" + txtNombre.Text + "',apellido='" + txtApelido.Text + "',direccion='" + txtDireccion.Text + "',telefono='" + txtTelefono.Text + "',correo='" + txtCorreo.Text + "' WHERE idEmpleado='" + txtID.Text + "';", conexionDB);
                        commandAdmin.CommandType = CommandType.Text;
                        conexionDB.Open();
                        resultadoAdmin = commandAdmin.ExecuteReader();
                        dataTableAdmin.Load(resultadoAdmin);
                        conexionDB.Close();
                        txtApelido.Text = "";
                        txtCorreo.Text = "";
                        txtDireccion.Text = "";
                        txtDNI.Text = "";
                        txtID.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";
                        MessageBox.Show("El empleado se ha modificado correctamente");
                    }
                }
                else
                {
                    txtApelido.Text = "";
                    txtCorreo.Text = "";
                    txtDireccion.Text = "";
                    txtDNI.Text = "";
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    MessageBox.Show("No se modifico el empleado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos.");
            }
        }
        internal void eliminarEmpleados(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialTextBox txtNombre, MaterialSkin.Controls.MaterialTextBox txtApelido, MaterialSkin.Controls.MaterialTextBox txtDireccion, MaterialSkin.Controls.MaterialTextBox txtTelefono, MaterialSkin.Controls.MaterialTextBox txtCorreo)
        {
            try
            {
                if (MessageBox.Show("Quieres eliminar este empleado?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtID.Text == "" || txtDNI.Text != "" || txtNombre.Text != "" || txtApelido.Text != "" || txtDireccion.Text != "" || txtTelefono.Text != "" || txtCorreo.Text != "")
                    {
                        txtApelido.Text = "";
                        txtCorreo.Text = "";
                        txtDireccion.Text = "";
                        txtDNI.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";
                        MessageBox.Show("Introduzca solo el ID.");
                        return;
                    }
                    if (txtID.Text != "" || txtDNI.Text == "" || txtNombre.Text == "" || txtApelido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
                    {
                        MySqlConnection conexionDB = Conexion.conexion();
                        DataTable dataTableAdmin = new DataTable();
                        MySqlDataReader resultadoAdmin;
                        //ingresando datos de nuevo usuario Admin
                        MySqlCommand commandAdmin = new MySqlCommand("DELETE FROM empleados WHERE idEmpleado='"+txtID.Text+"';", conexionDB);
                        commandAdmin.CommandType = CommandType.Text;
                        conexionDB.Open();
                        resultadoAdmin = commandAdmin.ExecuteReader();
                        dataTableAdmin.Load(resultadoAdmin);
                        conexionDB.Close();
                        txtApelido.Text = "";
                        txtCorreo.Text = "";
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
                        MySqlCommand command2 = new MySqlCommand("alter table empleados AUTO_INCREMENT=1;", consultaDB2);
                        command2.CommandType = CommandType.Text;
                        consultaDB2.Open();
                        resultado2 = command2.ExecuteReader();
                        dataTable2.Load(resultado2);
                        consultaDB2.Close();
                        //
                        MessageBox.Show("El empleado se ha eliminado correctamente");
                    }
                }
                else
                {
                    txtApelido.Text = "";
                    txtCorreo.Text = "";
                    txtDireccion.Text = "";
                    txtDNI.Text = "";
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    MessageBox.Show("No se elimino el empleado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica el ID. Recuerda que no se puede eliminar un empleado que tenga un usuario.");
            }
        }
    }
}

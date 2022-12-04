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
    internal class Usuarios
    {
        internal void consultarUsuarios(DataGridView dgvUsuarios, MaterialSkin.Controls.MaterialTextBox txtConsultar, MaterialSkin.Controls.MaterialComboBox cbxBusqueda)
        {
            try
            {
                if (txtConsultar.Text == "")
                {
                    MySqlConnection consultaDB = Conexion.conexion();
                    DataTable dataTable = new DataTable();
                    MySqlDataReader resultado;
                    //Consultado datos sin la contraseña
                    MySqlCommand command = new MySqlCommand("select empleados_idEmpleado,id_usuario,empleados_dni_empleado,id_tipo,biblioteca,inventario from usuarios order by empleados_idEmpleado;", consultaDB);
                    command.CommandType = CommandType.Text;
                    consultaDB.Open();
                    resultado = command.ExecuteReader();
                    dataTable.Load(resultado);
                    dgvUsuarios.DataSource = dataTable;
                    //Agregando nombres a columnas
                    dgvUsuarios.Columns[0].HeaderText = "ID del empleado";
                    dgvUsuarios.Columns[1].HeaderText = "Usuario";
                    dgvUsuarios.Columns[2].HeaderText = "DNI del empleado";
                    dgvUsuarios.Columns[3].HeaderText = "Tipo de usuario";
                    dgvUsuarios.Columns[4].HeaderText = "Acceso a biblioteca";
                    dgvUsuarios.Columns[5].HeaderText = "Acceso a inventario";
                    consultaDB.Close();
                }
                if (txtConsultar.Text != "")
                {
                    if (cbxBusqueda.Text == "ID")
                    {
                        MySqlConnection consultaDB2 = Conexion.conexion();
                        DataTable dataTable2 = new DataTable();
                        MySqlDataReader resultado2;
                        //Consultado datos de la tabla libros
                        MySqlCommand command2 = new MySqlCommand("select empleados_idEmpleado,id_usuario,empleados_dni_empleado,id_tipo,biblioteca,inventario from usuarios where empleados_idEmpleado like '%" + txtConsultar.Text + "%';", consultaDB2);
                        command2.CommandType = CommandType.Text;
                        consultaDB2.Open();
                        resultado2 = command2.ExecuteReader();
                        dataTable2.Load(resultado2);
                        dgvUsuarios.DataSource = dataTable2;
                        //Agregando nombres a columnas
                        dgvUsuarios.Columns[0].HeaderText = "ID del empleado";
                        dgvUsuarios.Columns[1].HeaderText = "Usuario";
                        dgvUsuarios.Columns[2].HeaderText = "DNI del empleado";
                        dgvUsuarios.Columns[3].HeaderText = "Tipo de usuario";
                        dgvUsuarios.Columns[4].HeaderText = "Acceso a biblioteca";
                        dgvUsuarios.Columns[5].HeaderText = "Acceso a inventario";
                        consultaDB2.Close();
                    }
                    if (cbxBusqueda.Text == "Nombre")
                    {
                        MySqlConnection consultaDB2 = Conexion.conexion();
                        DataTable dataTable2 = new DataTable();
                        MySqlDataReader resultado2;
                        //Consultado datos de la tabla libros
                        MySqlCommand command2 = new MySqlCommand("select empleados_idEmpleado,id_usuario,empleados_dni_empleado,id_tipo,biblioteca,inventario from usuarios where id_usuario like '%" + txtConsultar.Text + "%';", consultaDB2);
                        command2.CommandType = CommandType.Text;
                        consultaDB2.Open();
                        resultado2 = command2.ExecuteReader();
                        dataTable2.Load(resultado2);
                        dgvUsuarios.DataSource = dataTable2;
                        //Agregando nombres a columnas
                        dgvUsuarios.Columns[0].HeaderText = "ID del empleado";
                        dgvUsuarios.Columns[1].HeaderText = "Usuario";
                        dgvUsuarios.Columns[2].HeaderText = "DNI del empleado";
                        dgvUsuarios.Columns[3].HeaderText = "Tipo de usuario";
                        dgvUsuarios.Columns[4].HeaderText = "Acceso a biblioteca";
                        dgvUsuarios.Columns[5].HeaderText = "Acceso a inventario";
                        consultaDB2.Close();
                    }
                    if (cbxBusqueda.Text == "DNI")
                    {
                        MySqlConnection consultaDB3 = Conexion.conexion();
                        DataTable dataTable3 = new DataTable();
                        MySqlDataReader resultado3;
                        //Consultado datos de la tabla libros
                        MySqlCommand command3 = new MySqlCommand("select empleados_idEmpleado,id_usuario,empleados_dni_empleado,id_tipo,biblioteca,inventario from usuarios where empleados_dni_empleado like '%" + txtConsultar.Text + "%';", consultaDB3);
                        command3.CommandType = CommandType.Text;
                        consultaDB3.Open();
                        resultado3 = command3.ExecuteReader();
                        dataTable3.Load(resultado3);
                        dgvUsuarios.DataSource = dataTable3;
                        //Agregando nombres a columnas
                        dgvUsuarios.Columns[0].HeaderText = "ID del empleado";
                        dgvUsuarios.Columns[1].HeaderText = "Usuario";
                        dgvUsuarios.Columns[2].HeaderText = "DNI del empleado";
                        dgvUsuarios.Columns[3].HeaderText = "Tipo de usuario";
                        dgvUsuarios.Columns[4].HeaderText = "Acceso a biblioteca";
                        dgvUsuarios.Columns[5].HeaderText = "Acceso a inventario";
                        consultaDB3.Close();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR ");
            }

        }
        internal void registrarUsuarios(MaterialSkin.Controls.MaterialTextBox txtnombre, MaterialSkin.Controls.MaterialTextBox txtcontraseña, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialCheckbox cbxAdmin, MaterialSkin.Controls.MaterialCheckbox cbxEmpleado, MaterialSkin.Controls.MaterialCheckbox cbxBiblioteca, MaterialSkin.Controls.MaterialCheckbox cbxInventario)
        {
            try
            {
                string dniEmpleado = "";
                int EmpleadoID = 0;
                //Consultado DNI
                MySqlConnection conexionDB = Conexion.conexion();
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;
                MySqlCommand command = new MySqlCommand("select  dni_empleado from empleados where dni_empleado='"+txtDNI.Text+"';", conexionDB);
                command.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = command.ExecuteReader();
                dataTable.Load(resultado);
                dniEmpleado = Convert.ToString(command.ExecuteScalar());
                conexionDB.Close();
                //Consultado el ID
                MySqlConnection conexionDB2 = Conexion.conexion();
                DataTable dataTable2 = new DataTable();
                MySqlDataReader resultado2;
                MySqlCommand command2 = new MySqlCommand("select  idEmpleado from empleados where dni_empleado='"+txtDNI.Text+"';", conexionDB2);
                command2.CommandType = CommandType.Text;
                conexionDB2.Open();
                resultado2 = command2.ExecuteReader();
                dataTable2.Load(resultado2);
                EmpleadoID = Convert.ToInt32(command2.ExecuteScalar());
                conexionDB2.Close();
                //
                if (txtnombre.Text =="" || txtDNI.Text =="" || txtcontraseña.Text ==""){
                    MessageBox.Show("Introduzca todos los datos");
                    return;
                }
                if (txtnombre.Text != "" || txtDNI.Text != "" || txtcontraseña.Text != "")
                {
                    if (dniEmpleado != "")
                    {
                        if (cbxAdmin.Checked == false && cbxEmpleado.Checked == false)
                        {
                            MessageBox.Show("No elegiste los permisos");
                        }
                        if (cbxAdmin.Checked == true)
                        {
                            DataTable dataTableAdmin = new DataTable();
                            MySqlDataReader resultadoAdmin;
                            //ingresando datos de nuevo usuario Admin
                            MySqlCommand commandAdmin = new MySqlCommand("insert into usuarios (empleados_idEmpleado,id_usuario,empleados_dni_empleado,contraseña,id_tipo,biblioteca,inventario) values ("+EmpleadoID+",'" + txtnombre.Text+"','"+txtDNI.Text+"','"+txtcontraseña.Text+"','Administrador','SI','SI');", conexionDB);
                            commandAdmin.CommandType = CommandType.Text;
                            conexionDB.Open();
                            resultadoAdmin = commandAdmin.ExecuteReader();
                            dataTableAdmin.Load(resultadoAdmin);
                            conexionDB.Close();
                            txtnombre.Text = "";
                            txtcontraseña.Text = "";
                            txtDNI.Text = "";
                            cbxAdmin.Checked = false;
                            cbxBiblioteca.Checked = false;
                            cbxEmpleado.Checked = false;
                            cbxInventario.Checked = false;
                            MessageBox.Show("El usuario se ha registrado correctamente");
                        }
                        if (cbxEmpleado.Checked==true && cbxInventario.Checked==false && cbxBiblioteca.Checked==false)
                        {
                            MessageBox.Show("No elegiste los permisos");
                        }
                        if (cbxEmpleado.Checked == true)
                        {
                            if (cbxBiblioteca.Checked==true && cbxInventario.Checked==true)
                            {
                                DataTable dataTableEnByI = new DataTable();
                                MySqlDataReader resultadoEnByI;
                                //ingresando datos de nuevo usuario Encargado con acceso a biblioteca y inventario
                                MySqlCommand commandEnByI = new MySqlCommand("insert into usuarios (empleados_idEmpleado,id_usuario,empleados_dni_empleado,contraseña,id_tipo,biblioteca,inventario) values ("+EmpleadoID+",'" + txtnombre.Text + "','" + txtDNI.Text + "','" + txtcontraseña.Text + "','Encargado','SI','SI');", conexionDB);
                                commandEnByI.CommandType = CommandType.Text;
                                conexionDB.Open();
                                resultadoEnByI = commandEnByI.ExecuteReader();
                                dataTableEnByI.Load(resultadoEnByI);
                                conexionDB.Close();
                                txtnombre.Text = "";
                                txtcontraseña.Text = "";
                                txtDNI.Text = "";
                                cbxAdmin.Checked = false;
                                cbxBiblioteca.Checked = false;
                                cbxEmpleado.Checked = false;
                                cbxInventario.Checked = false;
                                MessageBox.Show("El usuario se ha registrado correctamente");
                            }
                            if (cbxBiblioteca.Checked==true && cbxInventario.Checked==false)
                            {
                                DataTable dataTableEnB = new DataTable();
                                MySqlDataReader resultadoEnB;
                                //ingresando datos de nuevo usuario Encargado con acceso a biblioteca
                                MySqlCommand commandEnB = new MySqlCommand("insert into usuarios (empleados_idEmpleado,id_usuario,empleados_dni_empleado,contraseña,id_tipo,biblioteca,inventario) values ("+EmpleadoID+",'" + txtnombre.Text + "','" + txtDNI.Text + "','" + txtcontraseña.Text + "','Encargado','SI','NO');", conexionDB);
                                commandEnB.CommandType = CommandType.Text;
                                conexionDB.Open();
                                resultadoEnB = commandEnB.ExecuteReader();
                                dataTableEnB.Load(resultadoEnB);
                                conexionDB.Close();
                                txtnombre.Text = "";
                                txtcontraseña.Text = "";
                                txtDNI.Text = "";
                                cbxAdmin.Checked = false;
                                cbxBiblioteca.Checked = false;
                                cbxEmpleado.Checked = false;
                                cbxInventario.Checked = false;
                                MessageBox.Show("El usuario se ha registrado correctamente");
                            }
                            if (cbxInventario.Checked==true && cbxBiblioteca.Checked==false)
                            {
                                DataTable dataTableEnI = new DataTable();
                                MySqlDataReader resultadoEnI;
                                //ingresando datos de nuevo usuario Encargado con acceso a inventario
                                MySqlCommand commandEnI = new MySqlCommand("insert into usuarios (empleados_idEmpleado,id_usuario,empleados_dni_empleado,contraseña,id_tipo,biblioteca,inventario) values ("+EmpleadoID+",'" + txtnombre.Text + "','" + txtDNI.Text + "','" + txtcontraseña.Text + "','Encargado','NO','SI');", conexionDB);
                                commandEnI.CommandType = CommandType.Text;
                                conexionDB.Open();
                                resultadoEnI = commandEnI.ExecuteReader();
                                dataTableEnI.Load(resultadoEnI);
                                conexionDB.Close();
                                txtnombre.Text = "";
                                txtcontraseña.Text = "";
                                txtDNI.Text = "";
                                cbxAdmin.Checked = false;
                                cbxBiblioteca.Checked = false;
                                cbxEmpleado.Checked = false;
                                cbxInventario.Checked = false;
                                MessageBox.Show("El usuario se ha registrado correctamente");
                            }
                        }
                    }
                    if (dniEmpleado == "")
                    {
                        MessageBox.Show("No se encontro el empleado");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos");
            }
        }
        internal void modificarUsuarios(MaterialSkin.Controls.MaterialTextBox txtnombre, MaterialSkin.Controls.MaterialTextBox txtcontraseña, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialCheckbox cbxAdmin, MaterialSkin.Controls.MaterialCheckbox cbxEmpleado, MaterialSkin.Controls.MaterialCheckbox cbxBiblioteca, MaterialSkin.Controls.MaterialCheckbox cbxInventario)
        {
            try
            {
                if (MessageBox.Show("Quieres modificar este usuario?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string dniEmpleado = "";
                //Consultado DNI
                MySqlConnection conexionDB = Conexion.conexion();
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;
                MySqlCommand command = new MySqlCommand("select  dni_empleado from empleados where dni_empleado='" + txtDNI.Text + "';", conexionDB);
                command.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = command.ExecuteReader();
                dataTable.Load(resultado);
                dniEmpleado = Convert.ToString(command.ExecuteScalar());
                conexionDB.Close();
                //
                if (txtnombre.Text == "" || txtDNI.Text == "" || txtcontraseña.Text == "")
                {
                    MessageBox.Show("Introduzca todos los datos");
                    return;
                }
                if (txtnombre.Text != "" || txtDNI.Text != "" || txtcontraseña.Text != "")
                {
                    if (dniEmpleado != "")
                    {
                        if (cbxAdmin.Checked == false && cbxEmpleado.Checked == false)
                        {
                            MessageBox.Show("No elegiste los permisos");
                        }
                        if (cbxAdmin.Checked == true)
                        {
                            DataTable dataTableAdmin = new DataTable();
                            MySqlDataReader resultadoAdmin;
                            //modificando datos de usuario Admin
                            MySqlCommand commandAdmin = new MySqlCommand("UPDATE usuarios set empleados_dni_empleado='"+txtDNI.Text+"',contraseña='"+txtcontraseña.Text+"',id_tipo='Administrador',biblioteca='SI',inventario='SI' where id_usuario='"+txtnombre.Text+"';", conexionDB);
                            commandAdmin.CommandType = CommandType.Text;
                            conexionDB.Open();
                            resultadoAdmin = commandAdmin.ExecuteReader();
                            dataTableAdmin.Load(resultadoAdmin);
                            conexionDB.Close();
                            txtnombre.Text = "";
                            txtcontraseña.Text = "";
                            txtDNI.Text = "";
                            cbxAdmin.Checked = false;
                            cbxBiblioteca.Checked = false;
                            cbxEmpleado.Checked = false;
                            cbxInventario.Checked = false;
                            MessageBox.Show("El usuario se ha modificado correctamente");
                        }
                        if (cbxEmpleado.Checked == true && cbxInventario.Checked == false && cbxBiblioteca.Checked == false)
                        {
                            MessageBox.Show("No elegiste los permisos");
                        }
                        if (cbxEmpleado.Checked == true)
                        {
                            if (cbxBiblioteca.Checked == true && cbxInventario.Checked == true)
                            {
                                DataTable dataTableEnByI = new DataTable();
                                MySqlDataReader resultadoEnByI;
                                //modificando datos de usuario Encargado con acceso a biblioteca y inventario
                                MySqlCommand commandEnByI = new MySqlCommand("UPDATE usuarios set empleados_dni_empleado='" + txtDNI.Text + "',contraseña='" + txtcontraseña.Text + "',id_tipo='Encargado',biblioteca='SI',inventario='SI' where id_usuario='" + txtnombre.Text + "';", conexionDB);
                                commandEnByI.CommandType = CommandType.Text;
                                conexionDB.Open();
                                resultadoEnByI = commandEnByI.ExecuteReader();
                                dataTableEnByI.Load(resultadoEnByI);
                                conexionDB.Close();
                                txtnombre.Text = "";
                                txtcontraseña.Text = "";
                                txtDNI.Text = "";
                                cbxAdmin.Checked = false;
                                cbxBiblioteca.Checked = false;
                                cbxEmpleado.Checked = false;
                                cbxInventario.Checked = false;
                                MessageBox.Show("El usuario se ha modificado correctamente");
                            }
                            if (cbxBiblioteca.Checked == true && cbxInventario.Checked == false)
                            {
                                DataTable dataTableEnB = new DataTable();
                                MySqlDataReader resultadoEnB;
                                //modificando datos de usuario Encargado con acceso a biblioteca
                                MySqlCommand commandEnB = new MySqlCommand("UPDATE usuarios set empleados_dni_empleado='" + txtDNI.Text + "',contraseña='" + txtcontraseña.Text + "',id_tipo='Encargado',biblioteca='SI',inventario='NO' where id_usuario='" + txtnombre.Text + "';", conexionDB);
                                commandEnB.CommandType = CommandType.Text;
                                conexionDB.Open();
                                resultadoEnB = commandEnB.ExecuteReader();
                                dataTableEnB.Load(resultadoEnB);
                                conexionDB.Close();
                                txtnombre.Text = "";
                                txtcontraseña.Text = "";
                                txtDNI.Text = "";
                                cbxAdmin.Checked = false;
                                cbxBiblioteca.Checked = false;
                                cbxEmpleado.Checked = false;
                                cbxInventario.Checked = false;
                                MessageBox.Show("El usuario se ha modificado correctamente");
                            }
                            if (cbxInventario.Checked == true && cbxBiblioteca.Checked == false)
                            {
                                DataTable dataTableEnI = new DataTable();
                                MySqlDataReader resultadoEnI;
                                //modificando datos de Encargado con acceso a inventario
                                MySqlCommand commandEnI = new MySqlCommand("UPDATE usuarios set empleados_dni_empleado='" + txtDNI.Text + "',contraseña='" + txtcontraseña.Text + "',id_tipo='Encargado',biblioteca='NO',inventario='SI' where id_usuario='" + txtnombre.Text + "';", conexionDB);
                                commandEnI.CommandType = CommandType.Text;
                                conexionDB.Open();
                                resultadoEnI = commandEnI.ExecuteReader();
                                dataTableEnI.Load(resultadoEnI);
                                conexionDB.Close();
                                txtnombre.Text = "";
                                txtcontraseña.Text = "";
                                txtDNI.Text = "";
                                cbxAdmin.Checked = false;
                                cbxBiblioteca.Checked = false;
                                cbxEmpleado.Checked = false;
                                cbxInventario.Checked = false;
                                MessageBox.Show("El usuario se ha modificado correctamente");
                            }
                        }
                    }
                    if (dniEmpleado == "")
                    {
                        MessageBox.Show("No se encontro el empleado");
                    }
                }
                }
                else
                {
                    txtnombre.Text = "";
                    txtcontraseña.Text = "";
                    txtDNI.Text = "";
                    cbxAdmin.Checked = false;
                    cbxBiblioteca.Checked = false;
                    cbxEmpleado.Checked = false;
                    cbxInventario.Checked = false;
                    MessageBox.Show("No se modificado el usuario");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos");
            }
        }
        internal void eliminarUsuario(MaterialSkin.Controls.MaterialTextBox txtnombre, MaterialSkin.Controls.MaterialTextBox txtcontraseña, MaterialSkin.Controls.MaterialTextBox txtDNI, MaterialSkin.Controls.MaterialCheckbox cbxAdmin, MaterialSkin.Controls.MaterialCheckbox cbxEmpleado, MaterialSkin.Controls.MaterialCheckbox cbxBiblioteca, MaterialSkin.Controls.MaterialCheckbox cbxInventario)
        {
            try
            {
                if (MessageBox.Show("Quieres eliminar este usuario?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    MySqlConnection consultaDB = Conexion.conexion();
                    DataTable dataTable = new DataTable();
                    MySqlDataReader resultado;
                    //Consultado datos sin la contraseña
                    MySqlCommand command = new MySqlCommand("DELETE FROM usuarios WHERE id_usuario='"+txtnombre.Text+"';", consultaDB);
                    command.CommandType = CommandType.Text;
                    consultaDB.Open();
                    resultado = command.ExecuteReader();
                    dataTable.Load(resultado);
                    consultaDB.Close();
                    txtnombre.Text = "";
                    txtcontraseña.Text = "";
                    txtDNI.Text = "";
                    cbxAdmin.Checked = false;
                    cbxBiblioteca.Checked = false;
                    cbxEmpleado.Checked = false;
                    cbxInventario.Checked = false;
                    MessageBox.Show("Se ha eliminado el usuario");
                }
                else
                {
                    txtnombre.Text = "";
                    txtcontraseña.Text = "";
                    txtDNI.Text = "";
                    cbxAdmin.Checked = false;
                    cbxBiblioteca.Checked = false;
                    cbxEmpleado.Checked = false;
                    cbxInventario.Checked = false;
                    MessageBox.Show("No se elimino el usuario");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos. Recuerda que no puedes eliminar usuarios que hayan realizado prestamos los cuales esten pendientes");
            }
        }
    }
}

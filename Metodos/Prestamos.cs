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
    internal class Prestamos
    {
        internal void consultarPrestamos(DataGridView dgvPrestamos)
        {
            try
            {
                MySqlConnection consultaDB = Conexion.conexion();
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;
                //Consultado datos de prestamos 
                MySqlCommand command = new MySqlCommand("select * from prestamos order by idPrestamo_p;", consultaDB);
                command.CommandType = CommandType.Text;
                consultaDB.Open();
                resultado = command.ExecuteReader();
                dataTable.Load(resultado);
                dgvPrestamos.DataSource = dataTable;
                consultaDB.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }

        }
        internal void registrarPrestamos(MaterialSkin.Controls.MaterialTextBox txtLibroID, MaterialSkin.Controls.MaterialTextBox txtNombreSolicitante,string usuario, MaterialSkin.Controls.MaterialTextBox txtPrestamoID)
        {
            try
            {
                int x = 0;
                int y = 0;
                int clienteValor =0;
                string nombreLibro;
                string clienteDNI;
                try
                {
                    MySqlConnection consultaDB = Conexion.conexion();
                    DataTable dataTable = new DataTable();
                    MySqlDataReader resultado;
                    //Instruccion para consultar las existencias del libro
                    MySqlCommand command = new MySqlCommand("select existencias_i from libros where idLibro_l='"+ txtLibroID.Text + "';", consultaDB);
                    command.CommandType = CommandType.Text;
                    consultaDB.Open();
                    resultado = command.ExecuteReader();
                    dataTable.Load(resultado);
                    x = (Convert.ToInt32(command.ExecuteScalar()));
                    consultaDB.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ups... algo ha salido mal, Verifica el ID del libro.");
                }
                //////
                try
                {
                    MySqlConnection consultaDB2 = Conexion.conexion();
                    DataTable dataTable2 = new DataTable();
                    MySqlDataReader resultado2;
                    //instruccion para contar los prestamos de un libro segun sus existencias
                    MySqlCommand command2 = new MySqlCommand("SELECT count(*) FROM prestamos where libros_idLibro_l = '"+txtLibroID.Text+"';", consultaDB2);
                    command2.CommandType = CommandType.Text;
                    consultaDB2.Open();
                    resultado2 = command2.ExecuteReader();
                    dataTable2.Load(resultado2);
                    y = (Convert.ToInt32(command2.ExecuteScalar()));
                    consultaDB2.Close();
                }
                catch (Exception)
                {
                }
                ////
                if (txtPrestamoID.Text!="")
                {
                    txtPrestamoID.Text = "";
                    MessageBox.Show("Para hacer un prestamo no se necesita llenar el campo ID manualmente.");
                    return;
                }
                if (x == y)
                {
                    MessageBox.Show("Ya no hay libros para prestar, Verifica el ID (Numero).");
                }
                if (x != y)
                {
                    try
                    {
                        MySqlConnection consultaDB3 = Conexion.conexion();
                        DataTable dataTable3 = new DataTable();
                        MySqlDataReader resultado3;
                        //instruccion para buscar al cliente
                        MySqlCommand command3 = new MySqlCommand("select idCliente from clientes where idCliente='"+txtNombreSolicitante.Text+"';", consultaDB3);
                        command3.CommandType = CommandType.Text;
                        consultaDB3.Open();
                        resultado3 = command3.ExecuteReader();
                        dataTable3.Load(resultado3);
                        clienteValor = (Convert.ToInt32(command3.ExecuteScalar()));
                        consultaDB3.Close();
                        if (clienteValor==0)
                        {
                            MessageBox.Show("No se encontro el cliente, Verifica el ID (Numero).");
                        }
                        if (clienteValor != 0)
                        {
                            MySqlConnection consultaDB4 = Conexion.conexion();
                            DataTable dataTable4 = new DataTable();
                            MySqlDataReader resultado4;
                            //instruccion para buscar el nombre del libro
                            MySqlCommand command4 = new MySqlCommand("select nombre_l from libros where idLibro_l='"+txtLibroID.Text+"';", consultaDB4);
                            command4.CommandType = CommandType.Text;
                            consultaDB4.Open();
                            resultado4 = command4.ExecuteReader();
                            dataTable4.Load(resultado4);
                            nombreLibro = (Convert.ToString(command4.ExecuteScalar()));
                            consultaDB4.Close();
                            //////
                            MySqlConnection consultaDB5 = Conexion.conexion();
                            DataTable dataTable5 = new DataTable();
                            MySqlDataReader resultado5;
                            //instruccion para buscar el DNI del cliente
                            MySqlCommand command5 = new MySqlCommand("select dni_cliente from clientes where idCliente="+txtNombreSolicitante.Text+";", consultaDB5);
                            command5.CommandType = CommandType.Text;
                            consultaDB5.Open();
                            resultado5 = command5.ExecuteReader();
                            dataTable5.Load(resultado5);
                            clienteDNI = (Convert.ToString(command5.ExecuteScalar()));
                            consultaDB5.Close();
                            /////
                            try
                            {
                                MySqlConnection consultaDB6 = Conexion.conexion();
                                DataTable dataTable6 = new DataTable();
                                MySqlDataReader resultado6;
                                //instruccion para buscar el DNI del cliente
                                MySqlCommand command6 = new MySqlCommand("insert into prestamos (idPrestamo_p,libros_idLibro_l,libros_nombre_l,clientes_idCliente,clientes_dni_cliente,usuarios_id_usuario,fechaPrestamo_p) values (default,"+txtLibroID.Text+",'"+nombreLibro+"',"+txtNombreSolicitante.Text+",'"+clienteDNI+"','"+usuario+"',now());", consultaDB6);
                                command6.CommandType = CommandType.Text;
                                consultaDB6.Open();
                                resultado6 = command6.ExecuteReader();
                                dataTable6.Load(resultado6);
                                consultaDB6.Close();
                                txtLibroID.Text = "";
                                txtNombreSolicitante.Text = "";
                                nombreLibro = "";
                                clienteDNI = "";
                                MessageBox.Show("El prestamo ha sido registrado.");
                            }
                            catch (Exception) {
                                MessageBox.Show("Ups... algo ha salido mal al momento de registrar el prestamo.");
                            }

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ups... algo ha salido mal, Verifica el ID del cliente.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal.");
            }
        }
        internal void EliminarPrestamos(MaterialSkin.Controls.MaterialTextBox txtLibroID, MaterialSkin.Controls.MaterialTextBox txtNombreSolicitante, MaterialSkin.Controls.MaterialTextBox txtPrestamoID)
        {
            try
            {
                if (MessageBox.Show("Quieres eliminar este prestamo?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtPrestamoID.Text == "" || txtLibroID.Text != "" || txtNombreSolicitante.Text != "")
                    {
                        txtLibroID.Text = "";
                        txtNombreSolicitante.Text = "";
                        MessageBox.Show("Introduzca solo el ID del prestamo.");
                        return;
                    }
                    if (txtPrestamoID.Text != "" || txtLibroID.Text == "" || txtNombreSolicitante.Text == "")
                    {
                        MySqlConnection conexionDB = Conexion.conexion();
                        DataTable dataTableAdmin = new DataTable();
                        MySqlDataReader resultadoAdmin;
                        //eliminando el prestamo
                        MySqlCommand commandAdmin = new MySqlCommand("DELETE FROM prestamos WHERE idPrestamo_p='"+txtPrestamoID.Text+"';", conexionDB);
                        commandAdmin.CommandType = CommandType.Text;
                        conexionDB.Open();
                        resultadoAdmin = commandAdmin.ExecuteReader();
                        dataTableAdmin.Load(resultadoAdmin);
                        conexionDB.Close();
                        txtLibroID.Text = "";
                        txtNombreSolicitante.Text = "";
                        txtPrestamoID.Text = "";
                        //
                        MySqlConnection consultaDB2 = Conexion.conexion();
                        DataTable dataTable2 = new DataTable();
                        MySqlDataReader resultado2;
                        //Resetear el auto incremental de la tabla prestamos
                        MySqlCommand command2 = new MySqlCommand("alter table prestamos AUTO_INCREMENT=1;", consultaDB2);
                        command2.CommandType = CommandType.Text;
                        consultaDB2.Open();
                        resultado2 = command2.ExecuteReader();
                        dataTable2.Load(resultado2);
                        consultaDB2.Close();
                        //
                        MessageBox.Show("El prestamo ha sido eliminado");
                    }
                }
                else
                {
                    txtLibroID.Text = "";
                    txtNombreSolicitante.Text = "";
                    txtPrestamoID.Text = "";
                    MessageBox.Show("No se elimino el prestamo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica el ID (Numero).");
            }
        }
        internal void hacerDevolucion(MaterialSkin.Controls.MaterialTextBox txtLibroID, MaterialSkin.Controls.MaterialTextBox txtNombreSolicitante, MaterialSkin.Controls.MaterialTextBox txtPrestamoID,string usuario)
        {
            try
            {
                int libroID=0;
                string nombreLibro="";
                int clienteID = 0;
                string clienteDNI = "";
                int empleadoID = 0;
                string empleadoDNI = "";
                string fechaPrestamo;
                if (MessageBox.Show("Deseas continuar con la devolución del libro?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtPrestamoID.Text == "" || txtLibroID.Text != "" || txtNombreSolicitante.Text != "")
                    {
                        txtLibroID.Text = "";
                        txtNombreSolicitante.Text = "";
                        MessageBox.Show("Introduzca solo el ID del prestamo.");
                        return;
                    }
                    if (txtPrestamoID.Text != "" || txtLibroID.Text == "" || txtNombreSolicitante.Text == "")
                    {
                        MySqlConnection consultaDB3 = Conexion.conexion();
                        DataTable dataTable3 = new DataTable();
                        MySqlDataReader resultado3;
                        //instruccion para buscar el id del libro en el prestamo especificado
                        MySqlCommand command3 = new MySqlCommand("select libros_idLibro_l from prestamos where idPrestamo_p="+txtPrestamoID.Text+";", consultaDB3);
                        command3.CommandType = CommandType.Text;
                        consultaDB3.Open();
                        resultado3 = command3.ExecuteReader();
                        dataTable3.Load(resultado3);
                        libroID = (Convert.ToInt32(command3.ExecuteScalar()));
                        consultaDB3.Close();
                        //
                        MySqlConnection consultaDB4 = Conexion.conexion();
                        DataTable dataTable4 = new DataTable();
                        MySqlDataReader resultado4;
                        //instruccion para buscar el nombre del libro en el prestamo especificado
                        MySqlCommand command4 = new MySqlCommand("select libros_nombre_l from prestamos where idPrestamo_p="+txtPrestamoID.Text+";", consultaDB4);
                        command4.CommandType = CommandType.Text;
                        consultaDB4.Open();
                        resultado4 = command4.ExecuteReader();
                        dataTable4.Load(resultado4);
                        nombreLibro = (Convert.ToString(command4.ExecuteScalar()));
                        consultaDB4.Close();
                        //
                        MySqlConnection consultaDB5 = Conexion.conexion();
                        DataTable dataTable5 = new DataTable();
                        MySqlDataReader resultado5;
                        //instruccion para buscar el id del cliente en el prestamo especificado
                        MySqlCommand command5 = new MySqlCommand("select clientes_idCliente from prestamos where idPrestamo_p=" + txtPrestamoID.Text + ";", consultaDB5);
                        command5.CommandType = CommandType.Text;
                        consultaDB5.Open();
                        resultado5 = command5.ExecuteReader();
                        dataTable5.Load(resultado5);
                        clienteID = (Convert.ToInt32(command5.ExecuteScalar()));
                        consultaDB5.Close();
                        //
                        MySqlConnection consultaDB6 = Conexion.conexion();
                        DataTable dataTable6 = new DataTable();
                        MySqlDataReader resultado6;
                        //instruccion para buscar el DNI del cliente en el prestamo especificado
                        MySqlCommand command6 = new MySqlCommand("select clientes_dni_cliente from prestamos where idPrestamo_p=" + txtPrestamoID.Text + ";", consultaDB6);
                        command6.CommandType = CommandType.Text;
                        consultaDB6.Open();
                        resultado6 = command6.ExecuteReader();
                        dataTable6.Load(resultado6);
                        clienteDNI = (Convert.ToString(command6.ExecuteScalar()));
                        consultaDB6.Close();
                        //
                        MySqlConnection consultaDB7 = Conexion.conexion();
                        DataTable dataTable7 = new DataTable();
                        MySqlDataReader resultado7;
                        //instruccion para buscar el ID del empleado actual
                        MySqlCommand command7 = new MySqlCommand("select empleados_idEmpleado from usuarios where id_usuario='"+usuario+"';", consultaDB7);
                        command7.CommandType = CommandType.Text;
                        consultaDB7.Open();
                        resultado7 = command7.ExecuteReader();
                        dataTable7.Load(resultado7);
                        empleadoID = (Convert.ToInt32(command7.ExecuteScalar()));
                        consultaDB7.Close();
                        //
                        MySqlConnection consultaDB8 = Conexion.conexion();
                        DataTable dataTable8 = new DataTable();
                        MySqlDataReader resultado8;
                        //instruccion para buscar el ID del empleado actual
                        MySqlCommand command8 = new MySqlCommand("select empleados_dni_empleado from usuarios where id_usuario='" + usuario + "';", consultaDB8);
                        command8.CommandType = CommandType.Text;
                        consultaDB8.Open();
                        resultado8 = command8.ExecuteReader();
                        dataTable8.Load(resultado8);
                        empleadoDNI = (Convert.ToString(command8.ExecuteScalar()));
                        consultaDB8.Close();
                        //
                        MySqlConnection consultaDB9 = Conexion.conexion();
                        DataTable dataTable9 = new DataTable();
                        MySqlDataReader resultado9;
                        //instruccion para buscar la fecha del prestamo especificado
                        MySqlCommand command9 = new MySqlCommand("SELECT DISTINCT DATE_FORMAT(fechaPrestamo_p,'%Y-%m-%d %H:%i:%S') fechaPrestamo_p FROM prestamos WHERE idPrestamo_p="+txtPrestamoID.Text+";", consultaDB9);
                        command9.CommandType = CommandType.Text;
                        consultaDB9.Open();
                        resultado9 = command9.ExecuteReader();
                        dataTable9.Load(resultado9);
                        fechaPrestamo = (Convert.ToString(command9.ExecuteScalar()));
                        consultaDB9.Close();
                        //
                        MySqlConnection consultaDB10 = Conexion.conexion();
                        DataTable dataTable10 = new DataTable();
                        MySqlDataReader resultado10;
                        //instruccion para ingresar los datos anteriormente buscados a la tabla de devoluciones (hacer la devolucion)
                        MySqlCommand command10 = new MySqlCommand("insert into devoluciones (idDevolucion_d,libroID,nombreLibro_d,clienteID,clienteDNI,empleadoID,empleadoDNI,fechaPrestamo,fechaDevolucion_d) values (default,"+libroID+",'"+nombreLibro+"',"+clienteID+",'"+clienteDNI+"',"+empleadoID+",'"+empleadoDNI+"','"+fechaPrestamo+"',now());", consultaDB10);
                        command10.CommandType = CommandType.Text;
                        consultaDB10.Open();
                        resultado10 = command10.ExecuteReader();
                        dataTable10.Load(resultado10);
                        consultaDB10.Close();
                        //
                        MySqlConnection conexionDB = Conexion.conexion();
                        DataTable dataTableAdmin = new DataTable();
                        MySqlDataReader resultadoAdmin;
                        //eliminando el prestamo
                        MySqlCommand commandAdmin = new MySqlCommand("DELETE FROM prestamos WHERE idPrestamo_p='" + txtPrestamoID.Text + "';", conexionDB);
                        commandAdmin.CommandType = CommandType.Text;
                        conexionDB.Open();
                        resultadoAdmin = commandAdmin.ExecuteReader();
                        dataTableAdmin.Load(resultadoAdmin);
                        conexionDB.Close();
                        txtLibroID.Text = "";
                        txtNombreSolicitante.Text = "";
                        txtPrestamoID.Text = "";
                        //
                        MySqlConnection consultaDB2 = Conexion.conexion();
                        DataTable dataTable2 = new DataTable();
                        MySqlDataReader resultado2;
                        //Resetear el auto incremental de la tabla prestamos
                        MySqlCommand command2 = new MySqlCommand("alter table prestamos AUTO_INCREMENT=1;", consultaDB2);
                        command2.CommandType = CommandType.Text;
                        consultaDB2.Open();
                        resultado2 = command2.ExecuteReader();
                        dataTable2.Load(resultado2);
                        consultaDB2.Close();
                        //
                        //
                        txtPrestamoID.Text = "";
                        MessageBox.Show("Se realizó la devolución");
                    }
                }
                else
                {
                    txtLibroID.Text = "";
                    txtNombreSolicitante.Text = "";
                    txtPrestamoID.Text = "";
                    MessageBox.Show("No se realizó la devolución");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica el ID (Numero) del prestamo."+ex);
            }
        }
    }
}

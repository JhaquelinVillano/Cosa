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
    internal class Libros
    {
        internal void consultarLibros(DataGridView dgvUsuarios,MaterialSkin.Controls.MaterialTextBox txtConsultar, MaterialSkin.Controls.MaterialComboBox cbxBusqueda)
        {
            try
            {
                if (txtConsultar.Text == "")
                {
                    MySqlConnection consultaDB = Conexion.conexion();
                    DataTable dataTable = new DataTable();
                    MySqlDataReader resultado;
                    //Consultado datos de la tabla libros
                    MySqlCommand command = new MySqlCommand("select * from libros;", consultaDB);
                    command.CommandType = CommandType.Text;
                    consultaDB.Open();
                    resultado = command.ExecuteReader();
                    dataTable.Load(resultado);
                    dgvUsuarios.DataSource = dataTable;
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
                        MySqlCommand command2 = new MySqlCommand("select * from libros where idLibro_l like '%"+txtConsultar.Text+"%';", consultaDB2);
                        command2.CommandType = CommandType.Text;
                        consultaDB2.Open();
                        resultado2 = command2.ExecuteReader();
                        dataTable2.Load(resultado2);
                        dgvUsuarios.DataSource = dataTable2;
                        consultaDB2.Close();
                    }
                    if (cbxBusqueda.Text == "Nombre")
                    {
                        MySqlConnection consultaDB2 = Conexion.conexion();
                        DataTable dataTable2 = new DataTable();
                        MySqlDataReader resultado2;
                        //Consultado datos de la tabla libros
                        MySqlCommand command2 = new MySqlCommand("select * from libros where nombre_l like '%" + txtConsultar.Text + "%';", consultaDB2);
                        command2.CommandType = CommandType.Text;
                        consultaDB2.Open();
                        resultado2 = command2.ExecuteReader();
                        dataTable2.Load(resultado2);
                        dgvUsuarios.DataSource = dataTable2;
                        consultaDB2.Close();
                    }
                    if (cbxBusqueda.Text == "Categoría")
                    {
                        MySqlConnection consultaDB3 = Conexion.conexion();
                        DataTable dataTable3 = new DataTable();
                        MySqlDataReader resultado3;
                        //Consultado datos de la tabla libros
                        MySqlCommand command3 = new MySqlCommand("select * from libros where categoria_i like '%" + txtConsultar.Text + "%';", consultaDB3);
                        command3.CommandType = CommandType.Text;
                        consultaDB3.Open();
                        resultado3 = command3.ExecuteReader();
                        dataTable3.Load(resultado3);
                        dgvUsuarios.DataSource = dataTable3;
                        consultaDB3.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }

        }
        internal void registrarLibros(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtnombre, MaterialSkin.Controls.MaterialTextBox txtAutor, MaterialSkin.Controls.MaterialComboBox cbxCategoria, MaterialSkin.Controls.MaterialComboBox cbxIdioma, MaterialSkin.Controls.MaterialTextBox txtEdicion, MaterialSkin.Controls.MaterialTextBox txtExistencias)
        {
            try
            {
                if (txtnombre.Text=="" || txtExistencias.Text=="")
                {
                    MessageBox.Show("Introduzca los campos obligatorios (Nombre y existencias)");
                }
                if (txtnombre.Text != "" || txtExistencias.Text != "")
                {
                    MySqlConnection consultaDB = Conexion.conexion();
                    DataTable dataTable = new DataTable();
                    MySqlDataReader resultado;
                    //ingresando libro
                    MySqlCommand command = new MySqlCommand("insert into libros (idLibro_l,nombre_l,autor_i,categoria_i,idioma_i,edicion_i,existencias_i) values (default,'"+txtnombre.Text+"','"+txtAutor.Text+"','"+cbxCategoria.Text+"','"+cbxIdioma.Text+"','"+txtEdicion.Text+"',"+txtExistencias.Text+");", consultaDB);
                    command.CommandType = CommandType.Text;
                    consultaDB.Open();
                    resultado = command.ExecuteReader();
                    dataTable.Load(resultado);
                    consultaDB.Close();
                    txtAutor.Text = "";
                    txtEdicion.Text = "";
                    txtExistencias.Text="";
                    txtnombre.Text = "";
                    txtID.Text = "";
                    MessageBox.Show("El libro ha sido registrado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos.");
            }
        }

        internal void modificarLibros(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtnombre, MaterialSkin.Controls.MaterialTextBox txtAutor, MaterialSkin.Controls.MaterialComboBox cbxCategoria, MaterialSkin.Controls.MaterialComboBox cbxIdioma, MaterialSkin.Controls.MaterialTextBox txtEdicion, MaterialSkin.Controls.MaterialTextBox txtExistencias)
        {
            try
            {
                if (MessageBox.Show("Quieres modificar los datos de este libro?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtnombre.Text == "" || txtExistencias.Text == "")
                {
                    MessageBox.Show("Introduzca los campos obligatorios (Nombre y existencias)");
                        return;
                }
                if (txtnombre.Text != "" || txtExistencias.Text != "")
                {
                    MySqlConnection consultaDB = Conexion.conexion();
                    DataTable dataTable = new DataTable();
                    MySqlDataReader resultado;
                    //modificando libro
                    MySqlCommand command = new MySqlCommand("update libros set nombre_l='"+txtnombre.Text+"',autor_i='"+txtAutor.Text+"',categoria_i='"+cbxCategoria.Text+"',idioma_i='"+cbxIdioma.Text+"',edicion_i='"+txtEdicion.Text+"',existencias_i='"+txtExistencias.Text+"' where idLibro_l="+txtID.Text+";", consultaDB);
                    command.CommandType = CommandType.Text;
                    consultaDB.Open();
                    resultado = command.ExecuteReader();
                    dataTable.Load(resultado);
                    consultaDB.Close();
                    txtAutor.Text = "";
                    txtEdicion.Text = "";
                    txtExistencias.Text = "";
                    txtnombre.Text = "";
                    txtID.Text = "";
                    MessageBox.Show("El libro ha sido modificado");
                }
                }
                else
                {
                    txtAutor.Text = "";
                    txtEdicion.Text = "";
                    txtExistencias.Text = "";
                    txtnombre.Text = "";
                    txtID.Text = "";
                    MessageBox.Show("No se modificaron los datos del libro");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica los datos introducidos.");
            }
        }

        internal void eliminarLibros(MaterialSkin.Controls.MaterialTextBox txtID, MaterialSkin.Controls.MaterialTextBox txtnombre, MaterialSkin.Controls.MaterialTextBox txtAutor, MaterialSkin.Controls.MaterialComboBox cbxCategoria, MaterialSkin.Controls.MaterialComboBox cbxIdioma, MaterialSkin.Controls.MaterialTextBox txtEdicion, MaterialSkin.Controls.MaterialTextBox txtExistencias)
        {
            try
            {
                if (MessageBox.Show("Quieres eliminar este libro?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (txtID.Text == "" || txtnombre.Text != "" || txtAutor.Text != "" || txtEdicion.Text != "" || txtExistencias.Text != "")
                {
                    txtAutor.Text = "";
                    txtEdicion.Text = "";
                    txtExistencias.Text = "";
                    txtnombre.Text = "";
                    MessageBox.Show("Introduzca el ID del libro unicamente");
                    return;
                }
                if (txtID.Text != "")
                {
                    MySqlConnection consultaDB = Conexion.conexion();
                    DataTable dataTable = new DataTable();
                    MySqlDataReader resultado;
                    //Eliminar libro con su ID
                    MySqlCommand command = new MySqlCommand("DELETE FROM libros WHERE idLibro_l='"+txtID.Text+"';", consultaDB);
                    command.CommandType = CommandType.Text;
                    consultaDB.Open();
                    resultado = command.ExecuteReader();
                    dataTable.Load(resultado);
                    consultaDB.Close();
                    //
                    MySqlConnection consultaDB2 = Conexion.conexion();
                    DataTable dataTable2 = new DataTable();
                    MySqlDataReader resultado2;
                    //Resetear el auto incremental de la tabla
                    MySqlCommand command2 = new MySqlCommand("alter table libros AUTO_INCREMENT=1;", consultaDB2);
                    command2.CommandType = CommandType.Text;
                    consultaDB2.Open();
                    resultado2 = command2.ExecuteReader();
                    dataTable2.Load(resultado2);
                    consultaDB2.Close();
                    //
                    txtAutor.Text = "";
                    txtEdicion.Text = "";
                    txtExistencias.Text = "";
                    txtnombre.Text = "";
                    txtID.Text = "";
                    MessageBox.Show("El libro ha sido eliminado");
                }
                }
                else
                {
                    txtAutor.Text = "";
                    txtEdicion.Text = "";
                    txtExistencias.Text = "";
                    txtnombre.Text = "";
                    txtID.Text = "";
                    MessageBox.Show("No se elimino el libro");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal, Verifica el ID. Recuerde que no puede eliminar un libro que este prestado.");
            }

        }
    }
}

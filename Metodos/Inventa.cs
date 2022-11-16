using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Proyecto.Metodos
{
    internal class Inventa
    {
        //Clase Conexion
        MySqlConnection conexionDB = Conexion.conexion();

        public void ingresarEntrada(string codigo, string nombre, int cantidad, string descripcion, string tipo, string fecha)
        {   //Manejar errores
            try
            {   //Conectando
                conexionDB.Open();
                //Comando para insertar datos
                string sql = "insert into entradas (codigoArticulo_e, nombreArticulo_e, cantidad_e, descripcion_e, fecha_e, " +
                               "tipo_e) values ('" + codigo + "', '" + nombre + "', '" + cantidad + "', '" + descripcion + "', " + fecha + "," +
                               "'" + tipo + "')";

                //Conectando comandos con base de datos
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                //Ejecuntando comando en MySQL e ingresando la insercion
                comando.ExecuteNonQuery();
                MessageBox.Show("Registrado con exito");
            }
            catch (MySqlException ex)
            {   //Mensaje de error
                MessageBox.Show("Error al ingresar" + ex.Message);
            }
            finally
            {   //Finalizando conexion
                conexionDB.Close();
            }
        }

        public void eliminarEntradas(string id)
        {   //Query
            string sql = "delete from entradas where codigoArticulo_e='" + id + "'";
            try
            {   //Ejecutando conexion y comando
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Borrado con exito");
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        public void actualizarEntrada(DataGridView dgvInventario)
        {
            string sql = "select * from entradas;";
            DataTable tabla = new DataTable();
            MySqlDataReader resultado;
            try
            {   //Conectando y mandando query
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.CommandType = CommandType.Text;
                //Ejecutando comando
                resultado = comando.ExecuteReader();
                //Cargandolos
                tabla.Load(resultado);
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }//Cargando datos
            dgvInventario.DataSource = tabla;
        }
        public void modificarEntrada(string codigo, string nombre, int cantidad, string descripcion, string tipo, string fecha)
        {   //Query
            string sql = "update entradas set codigoArticulo_e='" + codigo + "', nombreArticulo_e='" + nombre + "', cantidad_e='" + cantidad + "', " +
                "descripcion_e='" + descripcion + "', fecha_e='" + fecha + "', tipo_e='" + tipo + "' where codigoArticulo_e='" + codigo +"'";
            try
            {
                conexionDB.Open();
                //Comandito
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Modificacion exitosa");
                conexionDB.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
        //Formulario de salida
        public void registroSalida(string codigo, string articulo, int cantidad, string fecha)
        {
            //Manejar errores
            try
            {   //Conectando
                conexionDB.Open();
                //Comando para insertar datos
                string sql = "insert into salidas (cantidad_s, fecha_s, entradas_codigoArticulo_e, entradas_nombreArticulo_e) " +
                    "values ('" + cantidad + "', '" + fecha + "', '" + codigo + "', '" + articulo + "')";

                //Conectando comandos con base de datos
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                //Ejecuntando comando en MySQL e ingresando la insercion
                comando.ExecuteNonQuery();
                MessageBox.Show("Devuelto con exito");
            }
            catch (MySqlException ex)
            {   //Mensaje de error
                MessageBox.Show("Error al devolver" + ex.Message);
            }
            finally
            {   //Finalizando conexion
                conexionDB.Close();
            }
        }
        public void modificarSalida(string codigo, string articulo, int cantidad, string fecha)
        {   //Query
            string sql = "update salidas set cantidad='" + cantidad + "', fecha_e='" + fecha + "', " +
                "entradas_codigoArticulo_e='" + codigo + "', entradas_nombreArticulo_e='"+ articulo +"', where nombreArticulo_e='" + articulo + "'";
            try
            {
                conexionDB.Open();
                //Comandito
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Modificacion exitosa");
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
        public void actualizarSalida(DataGridView dgvInventario)
        {
            string sql = "select * from salidas;";
            DataTable tabla = new DataTable();
            MySqlDataReader resultado;
            try
            {   //Conectando y mandando query
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.CommandType = CommandType.Text;
                //Ejecutando comando
                resultado = comando.ExecuteReader();
                //Cargandolos
                tabla.Load(resultado);
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }//Cargando datos
            dgvInventario.DataSource = tabla;
        }
        public void eliminarSalidas(string id)
        {   //Query
            string sql = "delete from salidas where codigoArticulo_e='" + id + "'";
            try
            {   //Ejecutando conexion y comando
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Borrado con exito");
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
        public void cargarCategorias(ComboBox cbx)
        {   //Limpiando combobox
            cbx.DataSource = null;
            cbx.Items.Clear();
            try
            {
                string sql = "select codigoArticulo_e, nombreArticulo_e from entradas order by codigoArticulo_e asc";
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                //Adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                //Cargando al objeto
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                //Cargarle los datos que queremos
                cbx.ValueMember = "codigoArticulo_e";
                cbx.DisplayMember = "nombreArticulo_e";
                //Cargarlo al combobox
                cbx.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
            finally
            {   //Cerrando
                conexionDB.Close();
            }
        }
        public void RellenarSalida(ComboBox cbx, MaterialTextBox codigo)
        {
            string sql = "select * from entradas where nombreArticulo_e='" + cbx + "'";
            try
            {
                conexionDB.Open();
                //Ejecutando comando
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                MySqlDataReader dr = comando.ExecuteReader();
                if (dr.Read() == true)
                {   //Agarrando variable de la base
                    codigo.Text = dr["codigoArticulo_e"].ToString();
                }
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }
    }
}

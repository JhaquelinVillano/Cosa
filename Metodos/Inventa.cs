using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Proyecto.Metodos
{
    internal class Inventa
    {
        //Clase Conexion
        MySqlConnection conexionDB = Conexion.conexion();

        public void ingresarEntrada(string codigo, string nombre, int cantidad, string descripcion, string tipo)
        {   //Manejar errores
            try
            {   //Conectando
                conexionDB.Open();
                //Comando para insertar datos
                string sql = "insert into entradas (codigoArticulo_e, nombreArticulo_e, cantidad_e, descripcion_e, fecha_e, " +
                               "tipo_e) values ('" + codigo + "', '" + nombre + "', '" + cantidad + "', '" + descripcion + "', now(), '" + tipo + "')";
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
            {   //Mensaje de confirmacion
                if(MessageBox.Show("Confirme, si desea eliminar esta entrada?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                //Ejecutando conexion y comando
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Borrado con exito");
                conexionDB.Close();
                }
                else
                {   //No se elimino la entrada
                    MessageBox.Show("No se elimino");
                }
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
            //Agregando nombres a columnas
            dgvInventario.Columns[0].HeaderText = "Codigo";
            dgvInventario.Columns[1].HeaderText = "Nombre del producto";
            dgvInventario.Columns[2].HeaderText = "Cantidad";
            dgvInventario.Columns[3].HeaderText = "Descripción";
            dgvInventario.Columns[4].HeaderText = "Fecha";
            dgvInventario.Columns[5].HeaderText = "Tipo";
        }
        public void modificarEntrada(string codigo, string nombre, int cantidad, string descripcion, string tipo)
        {   //Query
            string sql = "update entradas set codigoArticulo_e='" + codigo + "', nombreArticulo_e='" + nombre + "', cantidad_e='" + cantidad + "', " +
                "descripcion_e='" + descripcion + "', fecha_e= now(), tipo_e='" + tipo + "' where codigoArticulo_e='" + codigo +"'";
            try
            {   //Mensaje de confirmacion
                if (MessageBox.Show("Confirme, si desea modificar esta entrada?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {   //Conexion
                    conexionDB.Open();
                    //Comandito
                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Modificacion exitosa");
                    conexionDB.Close();
                }
                else
                {
                    MessageBox.Show("No se modifico la entrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        public void sumarEntrada(string id, int cantidad)
        {
            try
            {   //Conexion
                conexionDB.Open();
                //Para estar existencias
                string query = "update entradas set cantidad_e = cantidad_e + @cantidad where codigoArticulo_e= @ID";
                //Comando para restar existencias
                MySqlCommand coman = new MySqlCommand(query, conexionDB);
                //Parametros
                coman.Parameters.AddWithValue("@ID", id);
                coman.Parameters.AddWithValue("@cantidad", cantidad);
                //Ejecuntadolo
                coman.ExecuteNonQuery();
                MessageBox.Show("Se sumo con exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se sumo, error: " + ex.Message);
            }
            conexionDB.Close();
        }
        public DataTable busqueda(string sql)
        {   //Comandos para nuestra busqueda
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexionDB);
            DataTable tb = new DataTable();
            try
            {   //Abriendo conexion
                conexionDB.Open();
                //Pasando datos
                da.Fill(tb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {   //Cerrar conexion
                conexionDB.Close();
            }//Devolviendo datos
            return tb;
        }
        
        //Formulario de salida
        public void registroSalida(string id, string codigo, int cantidad, string fecha)
        {   //Errores
            try
            {   //Creando variable
                int existencias = 0;
                //Query para jalar el dato
                string consulta = "select existencias_p from productos where codigo_p = @id";
                conexionDB.Open();
                MySqlCommand comandito = new MySqlCommand(consulta, conexionDB);
                comandito.Parameters.AddWithValue("@id", codigo);
                //Guardand en dato tipo string y obteniendo valor de la base de datos
                string dato = comandito.ExecuteScalar().ToString();
                //Cerrando conexion
                conexionDB.Close();
                //Convirtiendo a entero
                existencias = Convert.ToInt32(dato);
                //Si lo que se encuentra en la base es mayor a la cantidad solicitada se ejecutara la salida
                if (existencias > cantidad)
                {   //Para asegurar si quiere devolver
                    if (MessageBox.Show("Confirme, si desea ue salga este recurso?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {   //Manejar errores
                        try
                        {   //Conectando
                            conexionDB.Open();
                            //Comando para insertar datos
                            string sql = "insert into salidas (id_salidas, nombreArticulo_s, cantidad_s, fecha_s) values " +
                                    "('" + codigo + "','" + id + "', '" + cantidad + "', '" + fecha + "')";
                            //Conectando comandos con base de datos
                            MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                            //Ejecuntando comando en MySQL e ingresando la insercion
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Devuelto con exito");
                            //Para estar existencias
                            string query = "update productos set existencias_p = existencias_p - @cantidad where codigo_p= @ID";
                            //Comando para restar existencias
                            MySqlCommand coman = new MySqlCommand(query, conexionDB);
                            //Parametros
                            coman.Parameters.AddWithValue("@ID", codigo);
                            coman.Parameters.AddWithValue("@cantidad", cantidad);
                            //Ejecuntadolo
                            coman.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {   //Mensaje de error
                            MessageBox.Show("Error al devolver: " + ex.Message);
                        }
                        finally
                        {   //Finalizando conexion
                            conexionDB.Close();
                        }
                    }
                    else
                    {   //No se elimino la salida
                        MessageBox.Show("No se devolvio");
                    }
                }//Cuando la persona pida el ultimo recurso se borrara automaticamente del inventario
                else if (existencias == cantidad)
                {   //Asegurando si realmente saldra el producto
                    if (MessageBox.Show("Confirme, si desea ue salga este recurso?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {   //Manejar errores
                        try
                        {   //Conectando
                            conexionDB.Open();
                            //Comando para insertar datos
                            string sql = "insert into salidas (id_salidas, nombreArticulo_s, cantidad_s, fecha_s) values " +
                                    "('" + codigo + "','" + id + "', '" + cantidad + "', '" + fecha + "')";
                            //Conectando comandos con base de datos
                            MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                            //Ejecuntando comando en MySQL e ingresando la insercion
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Devuelto con exito");
                            conexionDB.Close();
                            //Llamando metodo para eliminar
                            eliminarInventario(codigo);
                        }
                        catch (MySqlException ex)
                        {   //Mensaje de error
                            MessageBox.Show("Error al devolver: " + ex.Message);
                        }
                        finally
                        {   //Finalizando conexion
                            conexionDB.Close();
                        }
                    }
                    else
                    {   //No se elimino la salida
                        MessageBox.Show("No se delvolvio el producto");
                    }
                }
                else
                {
                   MessageBox.Show("No tiene el suficiente material para pedir mas");
                }
            }
            catch (Exception ix)
            {
                MessageBox.Show("Error: " + ix.Message);
            }
        }
        public void modificarSalida(string id, string articulo, int cantidad, string fecha)
        {   //Query
            string sql = "update salidas set id_salidas='"+ articulo + "' ,nombreArticulo_s='"+ id + "', cantidad_s='"+ cantidad +"', " +
                "fecha_s='" + fecha + "' where id_salidas='" + articulo + "'";
            try
            {
                conexionDB.Open();
                //Comandito
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Modificacion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
            conexionDB.Close();
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
            //Agregando nombres a columnas
            dgvInventario.Columns[0].HeaderText = "ID";
            dgvInventario.Columns[1].HeaderText = "Nombre del producto";
            dgvInventario.Columns[2].HeaderText = "Cantidad";
            dgvInventario.Columns[3].HeaderText = "Fecha";
        }
        public void eliminarSalidas(string id)
        {   //Query
            string sql = "delete from salidas where id_salidas='" + id + "'";
            try
            {   //Mensaje de confirmacion
                if (MessageBox.Show("Confirme, si desea eliminar esta recurso?", "Ventana de confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Ejecutando conexion y comando
                    conexionDB.Open();
                    MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Borrado con exito");
                }
                else
                {
                    MessageBox.Show("No se borro la salida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            conexionDB.Close();
        }
        public void cargarCategorias(ComboBox cbx, ComboBox txt)
        {   //Limpiando combobox
            cbx.DataSource = null;
            cbx.Items.Clear();
            try
            {
                string sql = "select codigo_p, nombreArticulo_p from productos order by codigo_p asc";
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                //Adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                //Cargando al objeto
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                //Cargarle los datos que queremos
                cbx.ValueMember = "nombreArticulo_p";
                cbx.DisplayMember = "codigo_p";

                txt.ValueMember = "codigo_p";
                txt.DisplayMember = "nombreArticulo_p";
                //Cargarlo al combobox
                cbx.DataSource = dt;
                txt.DataSource = dt;
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
        
        public void actualizarInventario(DataGridView dgvInventario)
        {
            string sql = "select * from productos;";
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
            //Agregando nombres a columnas
            dgvInventario.Columns[0].HeaderText = "ID del producto";
            dgvInventario.Columns[1].HeaderText = "Nombre del producto";
            dgvInventario.Columns[2].HeaderText = "Existencias";
        }
        //Inventario donde se encuentran las existencias
        public void ingresarInventario(string codigo, string nombre, int cantidad)
        {   //Manejar errores
            try
            {   //Conectando
                conexionDB.Open();
                //Comando para insertar datos
                string sql = "insert into productos (codigo_p, nombreArticulo_p, existencias_p) " +
                    "values ('" + codigo + "', '" + nombre + "', '" + cantidad + "')";

                //Conectando comandos con base de datos
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                //Ejecuntando comando en MySQL e ingresando la insercion
                comando.ExecuteNonQuery();
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
        public void modificarInventario(string codigo, string nombre, int cantidad)
        {   //Query
            string sql = "update productos set codigo_p='" + codigo + "', nombreArticulo_p='" + nombre + "', existencias_p='" + cantidad + "' " +
                "where codigo_p = '" + codigo + "'";
            try
            {
                conexionDB.Open();
                //Comandito
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        public void eliminarInventario(string id)
        {   //Query
            string sql = "delete from productos where codigo_p='" + id + "'";
            try
            {   //Ejecutando conexion y comando
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}


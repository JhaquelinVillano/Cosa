<<<<<<< HEAD
﻿using MaterialSkin.Controls;
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
        public void modificarEntrada(string codigo, string nombre, int cantidad, string descripcion, string tipo)
        {   //Query
            string sql = "update entradas set codigoArticulo_e='" + codigo + "', nombreArticulo_e='" + nombre + "', cantidad_e='" + cantidad + "', " +
                "descripcion_e='" + descripcion + "', fecha_e= now(), tipo_e='" + tipo + "' where codigoArticulo_e='" + codigo +"'";
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
        /*
        public void buscarEntrada(string dato, DataGridView dgvdEntradas)
        {   //Query para buscar
            string sql = "select * from entradas where codigoArticulo_e like '%" + dato + "%' or nombreArticulo_e" +
                "like '%" + dato + "'or cantidad_e like'%" + dato + "%'or descripcion_e like '%"+ dato +"%'" +
                "or fecha_e like '%"+ dato + "%'or tipo_e like '%"+ dato +"%'";
            //Generando variables
            string nombreArticulo, descripcion, fecha, tipo, codigoArticulo;
            int cantidad;
            //Controland errores
            try
            {   //Conectando e introduciendo codigo
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.CommandText = dato;
                //Lectura
                MySqlDataReader consultar;
                consultar = comando.ExecuteReader();
                //Ciclando todos los datos
                while (consultar.Read())
                {
                    codigoArticulo = consultar.GetString(0);
                    nombreArticulo = consultar.GetString(1);
                    cantidad = consultar.GetInt32(2);
                    descripcion = consultar.GetString(3);
                    fecha = consultar.GetString(4);
                    tipo = consultar.GetString(5);
                    dgvdEntradas.Rows.Add(codigoArticulo, nombreArticulo, Convert.ToInt32(cantidad), descripcion,
                        fecha, tipo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            conexionDB.Close();
        }*/

        //Formulario de salida
        public void registroSalida(string codigo, int cantidad, string fecha)
        {
            //Manejar errores
            try
            {   //Conectando
                conexionDB.Open();
                //Comando para insertar datos
                string sql = "insert into salidas (nombreArticulo_s, cantidad_s, fecha_s) values " +
                    "('" + codigo + "', '" + cantidad + "', '" + fecha + "')";

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
        public void modificarSalida(int id, string articulo, int cantidad, string fecha)
        {   //Query
            string sql = "update salidas set id_salidas='"+ id +"' ,nombreArticulo_s='"+ articulo + "', cantidad_s='"+ cantidad +"', " +
                "fecha_s='" + fecha + "' where id_salidas='" + id + "'";
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
        }
        public void eliminarSalidas(int id)
        {   //Query
            string sql = "delete from salidas where nombreArticulo_s='" + id + "'";
            try
            {   //Ejecutando conexion y comando
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                comando.ExecuteNonQuery();
                MessageBox.Show("Borrado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            conexionDB.Close();
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
        public void cargarID(ComboBox cbx)
        {   //Limpiando combobox
            cbx.DataSource = null;
            cbx.Items.Clear();
            try
            {
                string sql = "select id_salidas, nombreArticulo_s from salidas order by nombreArticulo_s asc";
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                //Adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                //Cargando al objeto
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                //Cargarle los datos que queremos
                cbx.ValueMember = "nombreArticulo_s";
                cbx.DisplayMember = "id_salidas";
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
            string sql = "update productos set codigo_p='" + codigo + "', nombreArticulo_p='" + nombre + "', existencias_p='" + cantidad + "' where codigo_p = '" + codigo + "'";
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
=======
﻿using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Metodos
{
    internal class Inventa
    {
        //Clase Conexion
        MySqlConnection conexionDB = Conexion.conexion();
        /*public void Ingresar(string codigo, string nombre, int cantidad, string descripcion, string tipo, string fecha)
        {   //Manejar errores
            try
            {   //Conectando
                conexionDB.Open();
                //Comando para insertar datos
                string sql = "insert into entradas (codigoArticulo_e, nombreArticulo_e, cantidad_e, descripcion_e, fecha_e, " +
                               "tipo_e, idUsuario_e) values('" + codigo + "', '" + nombre + "', '" + cantidad + "', '" + descripcion + "', " + fecha + "," +
                               "'" + tipo + "','" + cantidad + "')";

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
        }*/
    }
}
>>>>>>> d2a9c49edaa43156dfe7c04ab6b944356ea33311

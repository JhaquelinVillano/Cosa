using MaterialSkin.Controls;
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

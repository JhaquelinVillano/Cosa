using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Metodos
{
    internal class Respaldo
    {
        SaveFileDialog escoge = new SaveFileDialog();
        MySqlConnection conexion = new MySqlConnection();
        public void restaurar()
        {
            //Conectando con la base de datos
            string cadenaConexion = "server = localhost; port=3306; user id = root; password=root; database=credu;";
            //Especificar el tipo de base con la que se cuenta
            cadenaConexion += "charset=utf8; convertzerodatetime=true";
            //Extencionas que solo se pueden seleccionar
            escoge.Filter = "Archivo SQL (*.sql)|* .sql";
            //Directorio con el que va a iniciar
            escoge.InitialDirectory = "C:\\Users\\Windows\\Documents\\BACKUP";
            //Agregando un titulo
            escoge.Title = "Selecciona archivo de respaldo";
            //Validando cuando selecciona
            if (escoge.ShowDialog() == DialogResult.OK)
            {
                string ruta = escoge.FileName;
                try
                {
                    MySqlConnection conex = new MySqlConnection(cadenaConexion);
                    MySqlCommand comando = new MySqlCommand();
                    MySqlBackup backup = new MySqlBackup(comando);
                    try
                    {
                        MySqlCommand comandito = new MySqlCommand();
                        MySqlBackup bk = new MySqlBackup(comando);
                        comando.Connection = conex;
                        conex.Open();
                        bk.ExportToFile(ruta);
                        conex.Close();
                        MessageBox.Show("Respaldo generado con exito");
                    }
                    catch (Exception ix)
                    {
                        MessageBox.Show(ix.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void respaldar(string direccion)
        {
            string ubicacion = "";
            //Abriendo gestor de archivos
            OpenFileDialog selecciona = new OpenFileDialog();
            //Haciendo filtros
            selecciona.Filter = "Archivos SQL(*.sql)|*.sql";
            //Agregando titulo
            selecciona.Title = "Seleccionar respaldo";
            //Ubicacion inicial
            selecciona.InitialDirectory = "C:\\Users\\Windows\\Documents\\BACKUP";
            //Validando cuando selecciona
            try
            {
                if (selecciona.ShowDialog() == DialogResult.OK)
                {   //Pasando a variable
                    ubicacion = selecciona.FileName;
                    //Declarandolo en la variable
                    direccion = ubicacion;
                    try
                    {   //Haciendo conexiones
                        MySqlCommand comando = new MySqlCommand();
                        MySqlBackup respaldo = new MySqlBackup(comando);
                        comando.Connection = conexion;
                        conexion.Open();
                        //Importando la ruta
                        respaldo.ImportFromFile(ubicacion);
                        conexion.Close();
                        MessageBox.Show("Se importo completamente la base de datos");
                    }
                    catch (Exception ux)
                    {
                        MessageBox.Show(ux.Message);
                    }                    
                }
            }
            catch (Exception ox)
            {
                MessageBox.Show(ox.Message);
            }
        }
    }
}

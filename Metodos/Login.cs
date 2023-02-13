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
    internal class Login
    {
        public string Rol = "";
        public string biblioteca = "";
        public string inventario = "";
        public string id_tipo = "";
        public int verificar = 0;
        internal void iniciarSesion(string usuario, string contraseña)
        {
            try
            {
                string usuarioBD = "";
                string contrasenaBD = "";
                MySqlConnection conexionDB = Conexion.conexion();
                DataTable dataTable = new DataTable();
                MySqlDataReader resultado;
                //Tomando el nombre de usuario
                MySqlCommand command = new MySqlCommand("select id_usuario from usuarios where id_usuario='" + usuario + "';", conexionDB);
                command.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = command.ExecuteReader();
                dataTable.Load(resultado);
                usuarioBD = (Convert.ToString(command.ExecuteScalar()));
                conexionDB.Close();
                //Tomando la contraseña de usuario
                DataTable dataTable2 = new DataTable();
                MySqlDataReader resultado2;
                MySqlCommand command2 = new MySqlCommand("select contraseña from usuarios where contraseña='" + contraseña + "';", conexionDB);
                command2.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado2 = command2.ExecuteReader();
                dataTable2.Load(resultado2);
                contrasenaBD = (Convert.ToString(command2.ExecuteScalar()));
                conexionDB.Close();
                //Verificacion de usuario y contraseña
                if (usuario == "" || contraseña == "")
                {
                    MessageBox.Show("Introduzca el usuario y/o la contraseña");
                    return;
                }
                if (usuario == usuarioBD && contraseña == contrasenaBD) {
                    MessageBox.Show("Bienvenido " + usuario, "Ventana de bienvenida");
                    Menu.frmMenu menu = new Menu.frmMenu();
                    menu.Usuario = usuario;
                    Permisos(usuario);
                    menu.id_tipo = id_tipo;
                    menu.biblioteca = biblioteca;
                    menu.inventario = inventario;
                    verificar = 1;
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal");
            }
        }
        internal void Permisos(string Usuario)
        {
            //Metodo para saber a que puede acceder el usuario que inicio sesion
            //Biblioteca
            MySqlConnection consultaDB = Metodos.Conexion.conexion();
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;
            //instruccion para saber si el usuario tiene permiso de acceder a la biblioteca
            MySqlCommand command = new MySqlCommand("select biblioteca from usuarios where id_usuario='" + Usuario + "';", consultaDB);
            command.CommandType = CommandType.Text;
            consultaDB.Open();
            resultado = command.ExecuteReader();
            dataTable.Load(resultado);
            biblioteca = (Convert.ToString(command.ExecuteScalar()));
            consultaDB.Close();
            //Inventario
            MySqlConnection consultaDB2 = Metodos.Conexion.conexion();
            DataTable dataTable2 = new DataTable();
            MySqlDataReader resultado2;
            //instruccion para saber si el usuario tiene permiso de acceder al inventario
            MySqlCommand command2 = new MySqlCommand("select inventario from usuarios where id_usuario='" + Usuario + "';", consultaDB2);
            command2.CommandType = CommandType.Text;
            consultaDB2.Open();
            resultado2 = command2.ExecuteReader();
            dataTable2.Load(resultado2);
            inventario = (Convert.ToString(command2.ExecuteScalar()));
            consultaDB2.Close();
            //Administrador
            MySqlConnection consultaDB3 = Metodos.Conexion.conexion();
            DataTable dataTable3 = new DataTable();
            MySqlDataReader resultado3;
            //instruccion para saber si el usuario tiene permiso de acceder a todos los apartados (ADMIN)
            MySqlCommand command3 = new MySqlCommand("select id_tipo from usuarios where id_usuario='" + Usuario + "';", consultaDB3);
            command3.CommandType = CommandType.Text;
            consultaDB3.Open();
            resultado3 = command3.ExecuteReader();
            dataTable3.Load(resultado3);
            id_tipo = (Convert.ToString(command3.ExecuteScalar()));
            consultaDB3.Close();
        }
    }
}

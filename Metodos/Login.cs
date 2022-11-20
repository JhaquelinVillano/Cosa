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
        public int verificar = 0;
        internal void iniciarSesion(string usuario,string contraseña)
        {
            try
            {
                string usuarioBD = "";
                string contrasenaBD = "";
                string Rol="";
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
                if (usuario==usuarioBD && contraseña==contrasenaBD){
                    //Proceso de verificacion para saber si es admin o no
                    DataTable dataTable3 = new DataTable();
                    MySqlDataReader resultado3;
                    MySqlCommand command3 = new MySqlCommand("select id_tipo from usuarios where id_usuario='"+usuario+"';", conexionDB);
                    command3.CommandType = CommandType.Text;
                    conexionDB.Open();
                    resultado3 = command3.ExecuteReader();
                    dataTable3.Load(resultado3);
                    Rol = (Convert.ToString(command3.ExecuteScalar()));
                    conexionDB.Close();
                    //Admin | Trabajador | Invitado
                    if (Rol== "Administrador")
                    {
                        MessageBox.Show("Bienvenido "+usuario);
                        Menu.frmMenu admin = new Menu.frmMenu();
                        admin.Usuario = usuario;
                        verificar = 1;
                        admin.Show();
                    }
                    if (Rol == "Encargado")
                    {
                        MessageBox.Show("Bienvenido " + usuario);
                        Menu.frmMenuTrabajadores trabajadores = new Menu.frmMenuTrabajadores();
                        trabajadores.Usuario = usuario;
                        trabajadores.Show();
                    }
                    if (Rol == "Invitado")
                    {
                        MessageBox.Show("Bienvenido " + usuario);
                        Menu.frmMenuTrabajadores trabajadores = new Menu.frmMenuTrabajadores();
                        trabajadores.Usuario= usuario;
                        trabajadores.Show();
                    }
                }
                if (usuario != usuarioBD || contraseña != contrasenaBD)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups... algo ha salido mal");
            }
        }
    }
}

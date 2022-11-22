using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Metodos
{
    class Validaciones
    {   //Metodo para verificar que sean solo letras
        public void soloLetras(KeyPressEventArgs v)
        {
            if (char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo letras");
            }
        }
        //Metodo para verificar que tengan puro numeros
        public static bool soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        //Verificar si esta vacio
        public static bool vacios(MaterialTextBox texto)
        {   //Validar si estan vacios
            if (texto.Text == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

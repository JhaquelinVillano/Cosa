using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Metodos
{
    internal class Propiedades
    {
        private string codigoArticulo;
        private string nombreArticulo;
        private int cantidad;
        //Encapsulamiento
        public string CodigoArticulo { get => codigoArticulo; set => codigoArticulo = value; }
        public string NombreArticulo { get => nombreArticulo; set => nombreArticulo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}

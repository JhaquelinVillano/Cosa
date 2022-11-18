using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Metodos
{
    public class Excel
    {//Indices
        int indiceColumna = 0;
        int indiceFila = 0;
        public void exportar(DataGridView datalistado)
        {   //Instanciando objeto excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            //Exportando
            exportarExcel.Application.Workbooks.Add(true);
            //Para que recorra las columnas
            foreach (DataGridViewColumn columna in datalistado.Columns)
            {   //Vaya aumentando en uno en uno
                indiceColumna++;
                //Guardarlo en las celdas
                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }
            //Recorra las filas
            foreach (DataGridViewRow fila in datalistado.Rows)
            {   //Conforme lea ira sumando en uno en uno
                indiceFila++;
                indiceColumna = 0;
                //Para que recorra la columna con las filas
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {   //Vaya aumentando
                    indiceColumna++;
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            //Mostrando archivo excel
            exportarExcel.Visible = true;
        }
    }
}

using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CN_Unidades_Medidas
    {
        public static DataTable Listar_um(string cTexto)
        {
            CD_Unidades_Medidas Datos = new CD_Unidades_Medidas();
            return Datos.Listar_um(cTexto);
        }

        public static string Guardar_um(int Opcion, E_Unidades_Medidas Nueva_Unidad_Medida)
        {
            CD_Unidades_Medidas Datos = new CD_Unidades_Medidas();
            return Datos.Guardar_um(Opcion, Nueva_Unidad_Medida);
        }

        public static string Eliminar_um(int Codigo_um)
        {
            CD_Unidades_Medidas Datos = new CD_Unidades_Medidas();
            return Datos.Eliminar_um(Codigo_um);
        }
    }
}

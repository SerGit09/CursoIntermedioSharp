using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class CN_Caterogias
    {
        public static DataTable Listar_ca(string cTexto)
        {
            CD_Categorias Datos =  new CD_Categorias();
            return Datos.Listar_ca(cTexto);
        }
    }
}

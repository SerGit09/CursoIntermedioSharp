﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class CN_Caterogias
    {
        public static DataTable Listar_ca(string cTexto)
        {
            CD_Categorias Datos =  new CD_Categorias();
            return Datos.Listar_ca(cTexto);
        }

        public static string Guardar_ca(int Opcion, E_Categorias NuevaCategoria)
        {
            CD_Categorias Datos = new CD_Categorias();
            return Datos.Guardar_ca(Opcion, NuevaCategoria);
        }

        public static string Eliminar_ca(int Codigo_ca)
        {
            CD_Categorias Datos = new CD_Categorias();
            return Datos.Eliminar_ca(Codigo_ca);
        }
    }
}

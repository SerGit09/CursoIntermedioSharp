using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CD_Conexion
    {
        private string Bd;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static CD_Conexion con = null;
        
        private CD_Conexion()
        {
            this.Bd = "MiBaseDeDatos";
            this.Servidor = "DESKTOP-7KHO1J8";
            this.Usuario = "";
            this.Clave = "";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Conexion =  new SqlConnection();
            try
            {
                Conexion.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Bd + "; User Id=" + this.Usuario + "; Password" + this.Clave;
            }
            catch (Exception ex)
            {
                Conexion = null;
                throw ex;
            }
            return Conexion;
        }

        public static CD_Conexion GetInsancia()
        {
            if(con == null)
            {
                con = new CD_Conexion();
            }
            return con;
        }
    }
}

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
        private static CD_Conexion Con = null;
        
        private CD_Conexion()
        {
            this.Bd = "MiBaseDeDatos";
            //this.Servidor = "DESKTOP-7KHO1J8";
            this.Servidor = "DESKTOP-MD2LO89";
            this.Usuario = "";
            this.Clave = "";
        }

        public  SqlConnection CrearConexion()
        {
            SqlConnection Conexion =  new SqlConnection();
            try
            {
                Conexion.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Bd + "; User Id=" + this.Usuario + "; Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                Conexion = null;
                throw ex;
            }
            return Conexion;
        }

        public static CD_Conexion getInstancia()
        {
            if(Con == null)
            {
                Con = new CD_Conexion();
            }
            return Con;
        }

        //private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-MD2LO89;DataBase= MiBaseDatos;Integrated Security=true");
        ////private SqlConnection Conexion = new SqlConnection("data source=192.168.0.17,1433;initial catalog=CobranzaSP; user id=user1;password=1234;");


        ////private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-QFUKV11;DataBase= SpeedToner;Integrated Security=true");

        //public SqlConnection AbrirConexion()
        //{
        //    if (Conexion.State == ConnectionState.Closed)
        //    {
        //        Conexion.Open();
        //    }
        //    return Conexion;
        //}

        //public SqlConnection CerrarConexion()
        //{
        //    if (Conexion.State == ConnectionState.Open)
        //    {
        //        Conexion.Close();
        //    }
        //    return Conexion;
        //}
    }
}

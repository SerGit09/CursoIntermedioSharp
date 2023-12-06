using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class CD_Categorias
    {
        public DataTable Listar_ca(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable MiTabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = CD_Conexion.getInstancia().CrearConexion();
                SqlCommand Comando =  new SqlCommand("USP_Listado_Ca", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                MiTabla.Load(Resultado);
                return MiTabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Guardar_ca(int Opcion,E_Categorias NuevaCategoria)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = CD_Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_ca", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Opcion",SqlDbType.Int).Value = Opcion;
                Comando.Parameters.Add("@Codigo_ca",SqlDbType.Int).Value = NuevaCategoria.Codigo_ca;
                Comando.Parameters.Add("@Descripcion_ca",SqlDbType.VarChar).Value = NuevaCategoria.Descripcion_ca;
                sqlConnection.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK":"No se pudo registrar el proceso";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                //Cerrar la conexión
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Respuesta;
        }

        public string Eliminar_ca(int Codigo_ca)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = CD_Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_ca", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Codigo_ca", SqlDbType.Int).Value = Codigo_ca;
                sqlConnection.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el proceso";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                //Cerrar la conexión
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return Respuesta;
        }
    }
}

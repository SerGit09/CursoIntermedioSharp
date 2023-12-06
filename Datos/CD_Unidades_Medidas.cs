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
    public class CD_Unidades_Medidas
    {
        public DataTable Listar_um(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable MiTabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = CD_Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_um", SqlCon);
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
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Guardar_um(int Opcion, E_Unidades_Medidas Nueva_Unidad_Medida)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = CD_Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_um", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion;
                Comando.Parameters.Add("@Codigo_um", SqlDbType.Int).Value = Nueva_Unidad_Medida.Codigo_um;
                Comando.Parameters.Add("@Descripcion_um", SqlDbType.VarChar).Value = Nueva_Unidad_Medida.Descripcion_um;
                sqlConnection.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar el proceso";
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

        public string Eliminar_um(int Codigo_um)
        {
            string Respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = CD_Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_um", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Codigo_um", SqlDbType.Int).Value = Codigo_um;
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

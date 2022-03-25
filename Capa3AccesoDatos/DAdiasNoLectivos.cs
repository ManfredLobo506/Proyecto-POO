using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Capa3AccesoDatos
{
    public class DAdiasNoLectivos
    {
        private string _cadenaConexion;
        private string _mensaje;

        public DAdiasNoLectivos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }

        public int Insertar(EntidadDiasNoLectivos diasNoLectivos)
        {
            int id = 0;

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //realizamos la sentencia para el insert de los dias no lectivos
            string sentencia = "INSERT INTO DIAS_NO_LECTIVOS(IDENTIFICACION_P,FECHA,MOTIVO)VALUES(@IDENTIFICACION_P,@FECHA,@MOTIVO) SELECT @@IDENTITY";
            //asignamos valores a las variables
            comando.Parameters.AddWithValue("@IDENTIFICACION_P", diasNoLectivos.Id_profesor);
            comando.Parameters.AddWithValue("@FECHA", diasNoLectivos.Fecha);
            comando.Parameters.AddWithValue("@MOTIVO", diasNoLectivos.Motivo);
            
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }


            return id;

        }//fin de insertar

        public int EliminarRegistroConSP(EntidadDiasNoLectivos diasNoLectivos)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_DIAS_NO_LECTIVOS";//Nombre del proceso almacenado para realizar la eliminacion 
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", diasNoLectivos.Cod);
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);
                _mensaje = comando.Parameters["@msj"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;


        }

        public DataSet Listardias(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //Realizamos un select extraer la informacion requerida de dias no lectivos
            string sentencia = "select COD,IDENTIFICACION_P,MOTIVO,FECHA from DIAS_NO_LECTIVOS";


            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} order by {1}", sentencia, orden);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "DIAS_NO_LECTIVOS");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }
    }
}

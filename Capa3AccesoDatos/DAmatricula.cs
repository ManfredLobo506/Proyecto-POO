using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using System.Data.SqlClient;
using System.Data;


namespace Capa3AccesoDatos
{
    public class DAmatricula
    {

        private string _cadenaConexion;
        private string _mensaje;

        public DAmatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }
        public int Insertar(EntidadMatricula matricula)
        {
            int id = 0;

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //REALIZAMOS LA SENTENCIA PARA REALIZAR EL INSERT
            string sentencia = "INSERT INTO MATRICULAS(ID_ESTUDIANTE,FECHA,ENCARGADO) VALUES(@ID,@FECHA,@ENCARGADO) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@ID", matricula.Id_estudiante);//ASIGNAMOS VALORES A LAS VARIABLES
            comando.Parameters.AddWithValue("@FECHA", matricula.Fecha);
            comando.Parameters.AddWithValue("@ENCARGADO",matricula.Encargado);
      

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

        public int EliminarRegistroConSP(EntidadMatricula matricula)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_MATRICULA";//NOMBRE DEL PROCESO ALMACENADO QUE SE UTILZARA
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", matricula.Id_matricula);
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

        public DataSet ListarMatriculas(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //ESCRIBIMOS LAS SENTENCIA PARA EL SELECT
            string sentencia = "select ID_MATRICULA,ID_ESTUDIANTE,FECHA,ENCARGADO from MATRICULAS";


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
                adapter.Fill(datos, "MATRICULAS");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }



        public int ActualizarRegistroConSP(EntidadMatricula matricula)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ACTUALIZAR_MATRICULAS";//NOMBRE DEL PROCESO ALMACENADO QUE UTILIZAREMOS
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_MATRICULA", matricula.Id_matricula);//ASIGANACION A LAS VARIABLES QUE UTILIZAREMOS
            comando.Parameters.AddWithValue("@ID_ESTUDIANTE", matricula.Id_estudiante);
            comando.Parameters.AddWithValue("@ENCARGADO",matricula.Encargado);
            
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



        public int CorroborarEstadoRegistroConSP(EntidadMatricula matricula)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "CORROBORAR_ESTADO";//NOMBRE DEL PROCESO ALMACENADO QUE UTILIZAREMOS
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Id", matricula.Id_estudiante);//ASIGANACION A LAS VARIABLES QUE UTILIZAREMOS
         
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
    }
}

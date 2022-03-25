using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Capa3AccesoDatos
{
   public class DAprogramarClase
    {

        private string _cadenaConexion;
        private string _mensaje;

        public DAprogramarClase(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }

        public int Insertar(EntidadProgramarClase programarClase)
        {
            int id = 0;

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //REALIZAMOS LA SENTENCIA PARA EL INSERT
            string sentencia = "INSERT INTO PROGRAMAR_CLASE(ID_ESTUDIANTE, COD_MATERIA_ABIERTA, DIA, HORA) VALUES(@ID_ESTUDIANTE, @COD_MATERIA_ABIERTA, @DIA, @HORA) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@ID_ESTUDIANTE", programarClase.Id_estudiante);
            comando.Parameters.AddWithValue("@COD_MATERIA_ABIERTA", programarClase.Cod_materia_a);
            comando.Parameters.AddWithValue("@DIA", programarClase.Dia);
            comando.Parameters.AddWithValue("@HORA", programarClase.Hora);
   

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


        public int REVISAR_DISPONIBILIDAD(EntidadProgramarClase programarClase)
        {
            string dia = programarClase.Dia.ToString("dddd");
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "REVISAR_DISPONIBILIDAD";//NOMBRE DEL PROCESO ALMACENADO QUE UTLILIZAREMOS
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id",programarClase.Cod_materia_a);//VARIABLES QUE UTILIZAREMOS
            comando.Parameters.AddWithValue("@dia", dia);
            comando.Parameters.AddWithValue("@fecha", programarClase.Dia);
            comando.Parameters.AddWithValue("@hora", programarClase.Hora);
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


        public DataSet ListarClases(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //SENTENCIA QUE UTIZAREMOS PARA REALIZAR EL SELECT
            string sentencia = "select ID_CLASE,ID_ESTUDIANTE,COD_MATERIA_ABIERTA,DIA,HORA from PROGRAMAR_CLASE";


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
                adapter.Fill(datos, "CLASES");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }

    }
}

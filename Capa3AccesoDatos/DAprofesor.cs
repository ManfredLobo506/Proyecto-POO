using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Capa4Entidades;

namespace Capa3AccesoDatos
{
   public class DAprofesor
    {
        //Atributos 
        private string _cadenaConexion;
        private string _mensaje;

        public DAprofesor(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }

        public string Insertar(EntidadesProfesor profesor )
        {
            string id = "";

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //REALIZAMOS LA SENTENCIA PARA REALIZAR EL INSERT
            string sentencia = " INSERT INTO PROFESORES(IDENTIFICACION_P,NOMBRE_P,APELLIDO1_P,APELLIDO2_P,CORREO_ELECTRONICO_P,NUMERO_TELEFONICO_P) VALUES(@ID,@NOMBRE,@APELLIDO1,@APELLIDO2,@CORREO,@TELEFONO) SELECT IDENTIFICACION_P FROM PROFESORES WHERE IDENTIFICACION_P=@ID ";
            comando.Parameters.AddWithValue("@ID", profesor.Identificacion);//ASIGNAMOS VALORES A LAS VARIABLES
            comando.Parameters.AddWithValue("@NOMBRE", profesor.Nombre);
            comando.Parameters.AddWithValue("@APELLIDO1", profesor.Apellido1);
            comando.Parameters.AddWithValue("@APELLIDO2", profesor.Apellido2);
            comando.Parameters.AddWithValue("@CORREO", profesor.CorreoElectronico);
            comando.Parameters.AddWithValue("@TELEFONO", profesor.NumeroTelefonico);

            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                id = (comando.ExecuteScalar()).ToString();
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

        }//fin insertar


        public int EliminarRegistroConSP(EntidadesProfesor profesor)
        {
           int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_PROFESOR";//NOMBRE DEL PROCESO
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", profesor.Identificacion);//ASIGNAMOS VALORES A LAS VARIABLES
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

        public DataSet ListarProfesor(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //CREAMOS LA SENTENCIA PARA REALIZAR EL SELECT
            string sentencia = "select IDENTIFICACION_P,NOMBRE_P,APELLIDO1_P,APELLIDO2_P,CORREO_ELECTRONICO_P,NUMERO_TELEFONICO_P from PROFESORES";


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
                adapter.Fill(datos, "PROFESORES");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }


        public int ActualizarRegistroConSP(EntidadesProfesor profesor)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ACTUALIZAR_PROFESORES";//NOMBRE DEL PROCESO ALMACENADO QUE UTLIZAREMOS
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID", profesor.Identificacion);//ASIGNO VALOR A LAS VARIABLES QUE UTILIZAREMOS
            comando.Parameters.AddWithValue("@NOMBRE_P", profesor.Nombre);
            comando.Parameters.AddWithValue("@APELLIDO1_P", profesor.Apellido1);
            comando.Parameters.AddWithValue("@APELLIDO2_P", profesor.Apellido2);
            comando.Parameters.AddWithValue("@CORREO_ELECTRONICO_P", profesor.CorreoElectronico);
            comando.Parameters.AddWithValue("@NUMERO_TELEFONICO_P", profesor.NumeroTelefonico);
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

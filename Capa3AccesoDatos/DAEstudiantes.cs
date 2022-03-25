using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using System.Data.SqlClient;
using System.Data;


namespace Capa3AccesoDatos
{
    public class DAEstudiantes
    {
       
        //Atributos 
        private string _cadenaConexion;
        private string _mensaje;

        public DAEstudiantes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }

        public int Insertar(EntidadEstudiantes estudiante)
        {
            int id = 0;

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //Realizamos la sentencia
            string sentencia = "INSERT INTO ESTUDIANTES(IDENTIFICACION_E, NOMBRE_E, APELLIDO1_E, APELLIDO2_E,CORREO_ELECTRONICO_E,NUMERO_TELEFONICO) VALUES(@ID,@NOMBRE,@APELLIDO1,@APELLIDO2,@CORREO,@TELEFONO) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@ID", estudiante.Identificacion);
            comando.Parameters.AddWithValue("@NOMBRE", estudiante.Nombre);
            comando.Parameters.AddWithValue("@APELLIDO1", estudiante.Apellido1);
            comando.Parameters.AddWithValue("@APELLIDO2", estudiante.Apellido2);
            comando.Parameters.AddWithValue("@CORREO", estudiante.CorreoElectronico);
            comando.Parameters.AddWithValue("@TELEFONO", estudiante.NumeroTelefonico);

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

        public int EliminarRegistroConSP(EntidadEstudiantes estudiante)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR";//EL NOMBRE DEL PROCESO ALMACENADO QUE LLAMAREMOS
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", estudiante.Identificacion);//ASIGNAMOS VALOR A LA VARIABLE QUE SE RECIBE EN EL PROCESO ALMACENADO
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

        public DataSet ListarEstudiantes(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //REALIZAMOS LA SENTENCIA PARA CARGAR LOS DATOS QUE QUERAMOS
            string sentencia = "select IDENTIFICACION_E,NOMBRE_E,APELLIDO1_E,APELLIDO2_E,CORREO_ELECTRONICO_E,NUMERO_TELEFONICO from estudiantes";


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
                adapter.Fill(datos, "ESTUDIANTES");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }



        public int ActualizarRegistroConSP(EntidadEstudiantes estudiante)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ACTUALIZAR_ESTUDIANTES";//NOMBRE DEL PROCESO ALMACENADO QUE LLAMAREMOS
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID", estudiante.Identificacion);//LE ASIGNAMOS VALORES A LA VARIABLES QUE SERAN ENVIADAS
            comando.Parameters.AddWithValue("@NOMBRE_E", estudiante.Nombre);
            comando.Parameters.AddWithValue("@APELLIDO1_E", estudiante.Apellido1);
            comando.Parameters.AddWithValue("@APELLIDO2_E", estudiante.Apellido2);
            comando.Parameters.AddWithValue("@CORREO_ELECTRONICO_E", estudiante.CorreoElectronico);
            comando.Parameters.AddWithValue("@NUMERO_TELEFONICO", estudiante.NumeroTelefonico);
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

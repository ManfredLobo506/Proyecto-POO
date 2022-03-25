using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Capa3AccesoDatos
{
   public class DAhorarioProfesor
    {
        private string _cadenaConexion;
        private string _mensaje;

        public DAhorarioProfesor(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }
        public int Insertar(EntidadHorarioP horarioP)
        {
            int id = 0;

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //CREAMOS LA SENTENCIA PARA REALIZAR EL INSERT
            string sentencia = "INSERT INTO HORARIO_P(IDENTIFICACION_P,DIA,HORA_ENTRADA,HORA_SALIDA) VALUES(@IDENTIFICACION_P,@DIA,@HORA_E,@HORA_S) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@IDENTIFICACION_P", horarioP.Id_profesor);//ASIGNAMOS VALORES LAS VARIABLES
            comando.Parameters.AddWithValue("@DIA", horarioP.Dia);
            comando.Parameters.AddWithValue("@HORA_E", horarioP.HoraEntrada);
            comando.Parameters.AddWithValue("@HORA_S", horarioP.Horasalida);


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

        public int EliminarRegistroConSP(EntidadMateriaAbierta materiaAbierta)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_MATERIA_ABIERTA";//NOMBRE DEL PROCESO ALMACENADO QUE SE UTILIZARA
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", materiaAbierta.Cod_MateriaA);//ASIGNAMOS VALOR A LA VARIABLE QUE SE UTILIZARA
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


        public DataSet ListarHorarios(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //REALIZAMOS LA SENTENCIA PARA REALIZAR EL SELECT 
            string sentencia = "SELECT ID_HORARIO, IDENTIFICACION_P, DIA, HORA_ENTRADA, HORA_SALIDA FROM HORARIO_P";


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
                adapter.Fill(datos, "HORARIO_P");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }

        public int EliminarRegistroConSP(EntidadHorarioP horarioP)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_HORARIO";//NOMBRE DEL PROCESO ALMACENADO QUE SE UTILIZARA
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", horarioP.Id_horario);//ASIGNAMOS VALOR A LA VARIABLE QUE SE ENVIARA AL PROCESO ALMACENADO
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
        public int ComprobarRegistroConSP(EntidadHorarioP horarioP)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "HORARIO_PROFESOR_VERFICACIONES";//NOMBRE DEL PROCESO ALMACENADO QUE SE UTILIZARA
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", horarioP.Id_profesor);//ASIGNAMOS VALOR A LAS VARIABLES QUE SE ENVIARAN AL PROCESO ALMACENADO
            comando.Parameters.AddWithValue("@HORA_ENTRADA", horarioP.HoraEntrada);
            comando.Parameters.AddWithValue("@HORA_SALIDA", horarioP.Horasalida);
            comando.Parameters.AddWithValue("@DIA", horarioP.Dia);
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

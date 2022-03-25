using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Capa4Entidades;

namespace Capa3AccesoDatos
{
    public class DAmateria
    {
        private string _cadenaConexion;
        private string _mensaje;

        public DAmateria(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }
        public string Insertar(EntidadMateria materia)
        {
            string id = "";

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //REALIZAMOS LA SENTENCIA PARA REALIZAR EL INSERT
            string sentencia = " INSERT INTO MATERIAS(COD_MATERIA,NOMBRE_MATERIA,TOTAL_HORAS_MATERIA)VALUES(@COD_MATERIA,@NOMBRE,@TOTALHORAS) SELECT COD_MATERIA FROM MATERIAS";
            comando.Parameters.AddWithValue("@COD_MATERIA", materia.Cod_materia);//ASIGANAMOS VALORES A LAS VARIABLES
            comando.Parameters.AddWithValue("@NOMBRE", materia.Nombre_materia);
            comando.Parameters.AddWithValue("@TOTALHORAS", materia.Total_horas);
      

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

        }//fin de insertar


        public int EliminarRegistroConSP(EntidadMateria materia)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_MATERIA";//NOMBRE DEL PROCESO ALMACENADO QUE SE UTILIZARA
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", materia.Cod_materia);//ASIGNAMOS VALORES A LAS VARIABLES QUE SE UTILIZARAN
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


        public DataSet ListarMaterias(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //REALIZAMOS LA SENTENCIA PARA REALIZAR EL SELECT
            string sentencia = "select COD_MATERIA, NOMBRE_MATERIA, TOTAL_HORAS_MATERIA from MATERIAS";


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
                adapter.Fill(datos, "MATERIAS");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }



        public int ActualizarRegistroConSP(EntidadMateria materia)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ACTUALIZAR_MATERIAS";//NOMBRE DEL PROCESO ALMACENADO QUE SE UTILIZARA
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@COD_MATERIA", materia.Cod_materia);//ASIGNAMOS VALORES A LAS VARIABLES
            comando.Parameters.AddWithValue("@NOMBRE_MATERIA", materia.Nombre_materia);
            comando.Parameters.AddWithValue("@TOTAL_HORAS_MATERIA", materia.Total_horas);

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

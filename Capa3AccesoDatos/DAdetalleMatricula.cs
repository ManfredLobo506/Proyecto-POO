using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Capa3AccesoDatos
{
   public class DAdetalleMatricula
    {
        private string _cadenaConexion;
        private string _mensaje;

        public DAdetalleMatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }

        public int Insertar(EntidadDetalleMatricula detalle)
        {
            int id = 0;

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //creamos la sentencia de insert para ingresar los valores
            string sentencia = "INSERT INTO DETALLE_MATRICULA(ID_MATRICULA, COD_MATERIA_ABIERTA, NOTA, CANCELADO) VALUES(@ID_MATRICULA,@COD_MATERIA_ABIERTA,@NOTA,@CANCELADO) SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@ID_MATRICULA", detalle.Id_matricula);
            comando.Parameters.AddWithValue("@COD_MATERIA_ABIERTA", detalle.Cod_materiaA);
            comando.Parameters.AddWithValue("@NOTA", detalle.Nota);
            comando.Parameters.AddWithValue("@CANCELADO", detalle.Cancelado);


            comando.CommandText = sentencia;

            try
            {
                conexion.Open();//abrimos la conexion
                id = Convert.ToInt32(comando.ExecuteScalar());//El valor que nos retorne el comando.ExecuteScalar() lo asignamos
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();//cerramos la conexion
                comando.Dispose();
            }


            return id;

        }//fin de insertar

        public int EliminarRegistroConSP(EntidadDetalleMatricula detalleMatricula)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_DETALLE";//nombre del proceso almacenado creado 
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", detalleMatricula.Id_detalle_matricula);//Asiganamos nombres a las variables6
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//Asignamos el valor del return a retorno

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

        public DataSet ListarDetalle(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //creamos la sentencia de select
            string sentencia = "select ID_DETALLEMATRICULA,ID_MATRICULA,COD_MATERIA_ABIERTA,NOTA,CANCELADO from DETALLE_MATRICULA";


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
                adapter.Fill(datos, "DETALLE_MATRICULA");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }

        public int ActualizarRegistroConSP(EntidadDetalleMatricula detalleMatricula)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ACTUALIZAR_DETALLE_MATRICULAS";//nombre del proceso almacenado para actualizar
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_DETALLEMATRICULA", detalleMatricula.Id_detalle_matricula);//Asignamos valores a las variables
            comando.Parameters.AddWithValue("@ID_MATRICULA", detalleMatricula.Id_matricula);
            comando.Parameters.AddWithValue("@COD_MATERIA_ABIERTA", detalleMatricula.Cod_materiaA);
            comando.Parameters.AddWithValue("@NOTA", detalleMatricula.Nota);
            comando.Parameters.AddWithValue("@CANCELADO", detalleMatricula.Cancelado);
            
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


        public int CorroborarCupoConSP(EntidadDetalleMatricula detalleMatricula)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Corroborar_cupo";//nombre del proceso almacenado para actualizar
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", detalleMatricula.Cod_materiaA);//Asignamos valores a las variables
          

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


        public DataSet ListarNotas(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //listamos las notas de los estudiantes
            string sentencia = "  SELECT IDENTIFICACION_E, NOMBRE_MATERIA,NOTA FROM ESTUDIANTES INNER JOIN MATRICULAS ON"+
              " ESTUDIANTES.IDENTIFICACION_E = MATRICULAS.ID_ESTUDIANTE INNER JOIN DETALLE_MATRICULA"+
                " ON MATRICULAS.ID_MATRICULA = DETALLE_MATRICULA.ID_MATRICULA INNER JOIN MATERIAS_ABIERTAS"+
                 " ON DETALLE_MATRICULA.COD_MATERIA_ABIERTA = MATERIAS_ABIERTAS.COD_MATERIA_ABIERTA INNER JOIN"+
                       " MATERIAS ON MATERIAS_ABIERTAS.COD_MATERIA = MATERIAS.COD_MATERIA";
            

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
                adapter.Fill(datos, "NOTAS");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }
    }
}

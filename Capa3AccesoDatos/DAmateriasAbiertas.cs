using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Capa4Entidades;

namespace Capa3AccesoDatos
{
   public class DAmateriasAbiertas
    {
        private string _cadenaConexion;
        private string _mensaje;

        public DAmateriasAbiertas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }
        public string Insertar(EntidadMateriaAbierta materiaA)
        {
            string id = "";

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //REALIZAMOS LA SENTENCIA PARA REALIZAR EL INSERT EN LA TABLA DE MATERIAS ABIERTAS
            string sentencia = "INSERT INTO MATERIAS_ABIERTAS(COD_MATERIA_ABIERTA,COD_MATERIA,IDENTIFICACION_P,CUPO,COSTO) VALUES(@COD_MATERIA_ABIERTA,@COD_MATERIA,@ID_P,@CUPO,@COSTO)  SELECT COD_MATERIA_ABIERTA FROM MATERIAS_ABIERTAS WHERE COD_MATERIA_ABIERTA=@COD_MATERIA_ABIERTA";
            comando.Parameters.AddWithValue("@COD_MATERIA_ABIERTA",materiaA.Cod_MateriaA);//ASIGNAMOS VALORES A LAS VARIABLES 
            comando.Parameters.AddWithValue("@COD_MATERIA", materiaA.Cod_materia);
            comando.Parameters.AddWithValue("@ID_P", materiaA.IdentificacionP);
            comando.Parameters.AddWithValue("@COSTO", materiaA.Costo);
            comando.Parameters.AddWithValue("@CUPO", materiaA.Cupo);


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

        public int EliminarRegistroConSP(EntidadMateriaAbierta materiaAbierta)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_MATERIA_ABIERTA";//NOMBRE DEL PROCESO ALMACENADO QUE SE UTILIZARA
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", materiaAbierta.Cod_MateriaA);//ASIGNAMOS LAS VARIALBES QUE UTILIZAREMOS
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

        public DataSet ListarMateriasAbiertas(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //REALIZAMOS LA SENTENCIA PARA EJECUTAR EL SELECT
            string sentencia = "select COD_MATERIA_ABIERTA, COD_MATERIA, COSTO, CUPO, IDENTIFICACION_P from MATERIAS_ABIERTAS";


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
                adapter.Fill(datos, "MATERIAS_ABIERTAS");
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }


        public int ActualizarRegistroConSP(EntidadMateriaAbierta materiaAbierta)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ACTUALIZAR_MATERIA_ABIERTA";//NOMBRE DEL PROCESO ALMACENADO
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@COD_MATERIA_ABIERTA", materiaAbierta.Cod_MateriaA);//ASIGNAMOS VALORES A LAS VARIABLES
            comando.Parameters.AddWithValue("@COD_MATERIA", materiaAbierta.Cod_materia);
            comando.Parameters.AddWithValue("@IDENTIFICACION_P",materiaAbierta.IdentificacionP);
            comando.Parameters.AddWithValue("@CUPO", materiaAbierta.Cupo);
            comando.Parameters.AddWithValue("@COSTO", materiaAbierta.Costo);
     

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


        public DataSet ListarMateriasAbiertasNombre(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            //REALIZAMOS LA SENTENCIA PARA EJECUTAR EL SELECT
            string sentencia = "select COD_MATERIA_ABIERTA,NOMBRE_MATERIA, COSTO, CUPO, IDENTIFICACION_P from MATERIAS_ABIERTAS INNER JOIN MATERIAS ON MATERIAS_ABIERTAS.COD_MATERIA=MATERIAS.COD_MATERIA";


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

    }
}

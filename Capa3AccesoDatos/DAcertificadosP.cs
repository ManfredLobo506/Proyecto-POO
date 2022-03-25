using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using System.Data.SqlClient;
using System.Data;


namespace Capa3AccesoDatos
{
    public class DAcertificadosP
    {
        private string _cadenaConexion;
        private string _mensaje;

        public DAcertificadosP(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }

        public string Insertar(EntidadCertificadosP certificado)
        {
            string id = "";

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //Realizamos la sentencia para insertar los datos de los profesores
            string sentencia = "insert into CERTIFICADOS_PROFESORES(COD_CERTIFICADO,NOMBRE_CERTIFICADO,IDENTIFICACION_P)VALUES(@COD_CERTIFICADO,@NOMBRE_CERTIFICADO,@IDENTIFICACION_P) SELECT COD_CERTIFICADO FROM CERTIFICADOS_PROFESORES WHERE COD_CERTIFICADO=@COD_CERTIFICADO";
            comando.Parameters.AddWithValue("@COD_CERTIFICADO", certificado.Cod_certificado);//le asignamos valores a la variables que enviaremos
            comando.Parameters.AddWithValue("@NOMBRE_CERTIFICADO", certificado.Nombre_certificado);
            comando.Parameters.AddWithValue("@IDENTIFICACION_P", certificado.Id_profesor);



            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                id = comando.ExecuteScalar().ToString();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally//cerramos conexiones
            {
                conexion.Dispose();
                comando.Dispose();
            }


            return id;
        }

        public int EliminarRegistroConSP(EntidadCertificadosP certificado )
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "ELIMINAR_CERTIFICADO";//Nombre del proceso almacenado
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@id", certificado.Cod_certificado);//Enviamos el id del centificados
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

        public DataSet ListarCertificado(string condicion = "", string orden = "")
        {
            DataSet datos = new DataSet();//declaramos una variable datos de tipo dataset
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;

            string sentencia = "select COD_CERTIFICADO,NOMBRE_CERTIFICADO,IDENTIFICACION_P from CERTIFICADOS_PROFESORES";
            //Escribos la sentencia

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);//la codicion que queramos ponerle
            }
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} order by {1}", sentencia, orden);//el orden que queramos ponerle
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "CERTIFICADOS_PROFESORES");//Le asignamos un nombre 
            }
            catch (Exception)
            {

                throw;
            }


            return datos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Capa3AccesoDatos
{
    public class DAusuarios
    {

        private string _cadenaConexion;
        private string _mensaje;

        public DAusuarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje { get => _mensaje; }


        public int Insertar(EntidadUsuarios usuarios)
        {
            int id = 0;

            //Establecer conexion

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            //SENTENCIA PARA REALIZAR EL INSERT
            string sentencia = " INSERT INTO USUARIOS (NOMBRE_USER,CONTRA,PERMISO) VALUES(@NOMBRE_USER,@CONTRA,@PERMISO) select @@identity";
            comando.Parameters.AddWithValue("@NOMBRE_USER", usuarios.Nombre);//ASIGNANDO VALOR A LAS VARIABLES
            comando.Parameters.AddWithValue("@CONTRA", usuarios.Contra);
            comando.Parameters.AddWithValue("@PERMINO", usuarios.Permiso);
          
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

        }//fin insertar

        public int COMPROBARUSERS(EntidadUsuarios usuarios)
        {
            int resultado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "CORROBORAR_USUARIOS";//NOMBRE DEL PROCESO ALMACENADO PARA CORROBOR LOS USUARIOS
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@NOMBRE_USER", usuarios.Nombre);//ASIGNANDO VALORES A LAS VARIABLES
            comando.Parameters.AddWithValue("@CONTRA", usuarios.Contra);
            comando.Parameters.Add("PERMISO", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);
                _mensaje = comando.Parameters["PERMISO"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;


        }
    }
}

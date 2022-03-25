using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;


namespace Capa2Logica
{
    public class BLusuarios
    {


        //atributos

        private string _cadenaConexion;
        private string _mensaje;

        public BLusuarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }


        public int Insertar(EntidadUsuarios usuarios)
        {
            int id_estudiante = 0;

           DAusuarios accesoDatos = new DAusuarios(_cadenaConexion);

            try
            {
                id_estudiante = accesoDatos.Insertar(usuarios);
            }
            catch (Exception)
            {

                throw;
            }

            return id_estudiante;
        }//fin insertar

        public int ComprobarConSP(EntidadUsuarios usuarios)
        {
            int resultado;
            DAusuarios accesodatos = new DAusuarios(_cadenaConexion);
            try
            {
                resultado = accesodatos.COMPROBARUSERS(usuarios);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

    }
}

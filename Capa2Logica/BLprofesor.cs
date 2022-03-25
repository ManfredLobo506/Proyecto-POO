using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;
namespace Capa2Logica
{
    public class BLprofesor
    {
        //atributos

        private string _cadenaConexion;
        private string _mensaje;

        public BLprofesor(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }


        //funcional

        public string Insertar(EntidadesProfesor profesor)
        {
           string id_profesor = "";

            DAprofesor accesoDatos = new DAprofesor(_cadenaConexion);

            try
            {
                id_profesor = accesoDatos.Insertar(profesor);
            }
            catch (Exception)
            {

                throw;
            }

            return id_profesor;
        }//fin insertar

        public int ElminarConSP(EntidadesProfesor profesor)
        {
            int resultado;
           DAprofesor accesodatos = new DAprofesor(_cadenaConexion);
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(profesor);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public DataSet ListarProfesores(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAprofesor accesoDatos = new DAprofesor(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarProfesor(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public int ActualizarConSP(EntidadesProfesor profesor)
        {
            int resultado;
            DAprofesor accesodatos = new DAprofesor(_cadenaConexion);
            try
            {
                resultado = accesodatos.ActualizarRegistroConSP(profesor);
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

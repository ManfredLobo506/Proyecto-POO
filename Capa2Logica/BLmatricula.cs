using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace Capa2Logica
{
    public class BLmatricula
    {
        //atributos

        private string _cadenaConexion;
        private string _mensaje;

        public BLmatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }


        //funcional

        public int Insertar(EntidadMatricula matricula)
        {
            int id_matricula=0;

           DAmatricula accesoDatos = new DAmatricula(_cadenaConexion);

            try
            {
                id_matricula = accesoDatos.Insertar(matricula);
            }
            catch (Exception)
            {

                throw;
            }

            return id_matricula;
        }//fin insertar

        public int ElminarConSP(EntidadMatricula matricula)
        {
            int resultado;
            DAmatricula accesodatos = new DAmatricula(_cadenaConexion);
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(matricula);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public DataSet ListarMatricula(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAmatricula accesoDatos = new DAmatricula(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarMatriculas(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }


        public int ActualizarConSP(EntidadMatricula matricula)
        {
            int resultado;
            DAmatricula accesodatos = new DAmatricula(_cadenaConexion);
            try
            {
                resultado = accesodatos.ActualizarRegistroConSP(matricula);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }


        public int CorroborarEstadoConSP(EntidadMatricula matricula)
        {
            int resultado;
            DAmatricula accesodatos = new DAmatricula(_cadenaConexion);
            try
            {
                resultado = accesodatos.CorroborarEstadoRegistroConSP(matricula);
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

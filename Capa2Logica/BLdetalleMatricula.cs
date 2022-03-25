using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;


namespace Capa2Logica
{
    public class BLdetalleMatricula
    {
        private string _cadenaConexion;
        private string _mensaje;

        public BLdetalleMatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }


        //funcional

        public int Insertar(EntidadDetalleMatricula detalle)
        {
            int id = 0;

            DAdetalleMatricula accesoDatos = new DAdetalleMatricula(_cadenaConexion);

            try
            {
                id = accesoDatos.Insertar(detalle);
            }
            catch (Exception)
            {

                throw;
            }

            return id;
        }//fin insertar

        public int ElminarConSP(EntidadDetalleMatricula detalleMatricula)
        {
            int resultado;
            DAdetalleMatricula accesodatos = new DAdetalleMatricula(_cadenaConexion);
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(detalleMatricula);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public DataSet ListarDetalle(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAdetalleMatricula accesoDatos = new DAdetalleMatricula(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarDetalle(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public int ActualizarConSP(EntidadDetalleMatricula detalleMatricula)
        {
            int resultado;
            DAdetalleMatricula accesodatos = new DAdetalleMatricula(_cadenaConexion);
            try
            {
                resultado = accesodatos.ActualizarRegistroConSP(detalleMatricula);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }


        public int ActualizarConSP(EntidadMateria materia)
        {
            int resultado;
            DAmateria accesodatos = new DAmateria(_cadenaConexion);
            try
            {
                resultado = accesodatos.ActualizarRegistroConSP(materia);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public int CorroborarCupoConSP(EntidadDetalleMatricula detalleMatricula)
        {
            int resultado;
           DAdetalleMatricula accesodatos = new DAdetalleMatricula(_cadenaConexion);
            try
            {
                resultado = accesodatos.CorroborarCupoConSP(detalleMatricula);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }


        public DataSet ListarNotas(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAdetalleMatricula accesoDatos = new DAdetalleMatricula(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarNotas(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }
    }
}

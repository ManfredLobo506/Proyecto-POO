using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace Capa2Logica
{
   public class BLmateriaAbierta
    {
        //atributos

        private string _cadenaConexion;
        private string _mensaje;

        public BLmateriaAbierta(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }


        //funcional

        public string Insertar(EntidadMateriaAbierta materiaAbierta)
        {
            string cod_materia="";

            DAmateriasAbiertas accesoDatos = new DAmateriasAbiertas(_cadenaConexion);

            try
            {
                cod_materia = accesoDatos.Insertar(materiaAbierta);
            }
            catch (Exception)
            {

                throw;
            }

            return cod_materia;
        }//fin insertar

        public int ElminarConSP(EntidadMateriaAbierta materiaAbierta)
        {
            int resultado;
            DAmateriasAbiertas accesodatos = new DAmateriasAbiertas(_cadenaConexion);
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(materiaAbierta);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }


        public DataSet ListarMateriasAbiertas(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAmateriasAbiertas accesoDatos = new DAmateriasAbiertas(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarMateriasAbiertas(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }


        public DataSet ListarMateriasAbiertasNombres(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAmateriasAbiertas accesoDatos = new DAmateriasAbiertas(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarMateriasAbiertasNombre(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }


        public int ActualizarConSP(EntidadMateriaAbierta materiaAbierta)
        {
            int resultado;
           DAmateriasAbiertas accesodatos = new DAmateriasAbiertas(_cadenaConexion);
            try
            {
                resultado = accesodatos.ActualizarRegistroConSP(materiaAbierta);
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

using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;



namespace Capa2Logica
{
    public class BLestudiante
    {
        //atributos

        private string _cadenaConexion;
        private string _mensaje;

        public BLestudiante(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }


        //funcional

        public int Insertar(EntidadEstudiantes estudiante)
        {
            int id_estudiante = 0;

            DAEstudiantes accesoDatos = new DAEstudiantes(_cadenaConexion);

            try
            {
                id_estudiante = accesoDatos.Insertar(estudiante);
            }
            catch (Exception)
            {

                throw;
            }

            return id_estudiante;
        }//fin insertar

        public int ElminarConSP(EntidadEstudiantes estudiante)
        {
            int resultado;
            DAEstudiantes accesodatos = new DAEstudiantes(_cadenaConexion);
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(estudiante);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public int ActualizarConSP(EntidadEstudiantes estudiante)
        {
            int resultado;
            DAEstudiantes accesodatos = new DAEstudiantes(_cadenaConexion);
            try
            {
                resultado = accesodatos.ActualizarRegistroConSP(estudiante);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public DataSet ListarEstudiante(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAEstudiantes accesoDatos = new DAEstudiantes(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarEstudiantes(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }
    }
}

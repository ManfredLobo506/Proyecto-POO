using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;


namespace Capa2Logica
{
    public class BLdiasNoLectivos
    {
        //atributos

        private string _cadenaConexion;
        private string _mensaje;

        public BLdiasNoLectivos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }


        //funcional

        public int Insertar(EntidadDiasNoLectivos diasNoLectivos)
        {
            int id = 0;

            DAdiasNoLectivos accesoDatos = new DAdiasNoLectivos(_cadenaConexion);

            try
            {
                id = accesoDatos.Insertar(diasNoLectivos);
            }
            catch (Exception)
            {

                throw;
            }

            return id;
        }//fin insertar

        public int ElminarConSP(EntidadDiasNoLectivos diasNoLectivos)
        {
            int resultado;
            DAdiasNoLectivos accesodatos = new DAdiasNoLectivos(_cadenaConexion);
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(diasNoLectivos);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public DataSet Listardias(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAdiasNoLectivos accesoDatos = new DAdiasNoLectivos(_cadenaConexion);
            try
            {
                DS = accesoDatos.Listardias(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }
    }
}

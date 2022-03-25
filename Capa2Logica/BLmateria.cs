using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
namespace Capa2Logica
{
    public class BLmateria
    {

        private string _cadenaConexion;
        private string _mensaje;

        public BLmateria(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }
        public string Insertar(EntidadMateria materia)
        {
            string id_materia = "";

            DAmateria accesoDatos = new DAmateria(_cadenaConexion);

            try
            {
                id_materia = accesoDatos.Insertar(materia);
            }
            catch (Exception)
            {

                throw;
            }

            return id_materia;
        }//fin insertar
        public int ElminarConSP(EntidadMateria materia)
        {
            int resultado;
           DAmateria accesodatos = new DAmateria(_cadenaConexion);
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(materia);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public DataSet ListarMaterias(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAmateria accesoDatos = new DAmateria(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarMaterias(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
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
    }
}

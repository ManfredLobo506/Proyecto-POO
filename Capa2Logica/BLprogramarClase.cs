using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;



namespace Capa2Logica
{
    public class BLprogramarClase
    {
        //atributos

        private string _cadenaConexion;
        private string _mensaje;

        public BLprogramarClase(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }

        public int Insertar(EntidadProgramarClase programarClase)
        {
            int id=-1;

           DAprogramarClase accesoDatos = new DAprogramarClase(_cadenaConexion);

            try
            {
                id = accesoDatos.Insertar(programarClase);
            }
            catch (Exception)
            {

                throw;
            }

            return id;
        }//fin insertar




        public int REVISAR_DISPONIBILIDAD(EntidadProgramarClase programarClase)
        {
            int resultado;
           DAprogramarClase accesodatos = new DAprogramarClase(_cadenaConexion);
            try
            {
                resultado = accesodatos.REVISAR_DISPONIBILIDAD(programarClase);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public DataSet ListarClases(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAprogramarClase accesoDatos = new DAprogramarClase(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarClases(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

    }
}

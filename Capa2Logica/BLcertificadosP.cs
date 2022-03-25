using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;


namespace Capa2Logica
{
    public class BLcertificadosP
    {
        private string _cadenaConexion;
        private string _mensaje;

        public BLcertificadosP(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }


      

        public string Insertar(EntidadCertificadosP certificadosP)
        {
            string id = "";

            DAcertificadosP accesoDatos = new DAcertificadosP(_cadenaConexion);

            try
            {
                id = accesoDatos.Insertar(certificadosP);
            }
            catch (Exception)
            {

                throw;
            }

            return id;
        }//fin insertar


        public int ElminarConSP(EntidadCertificadosP certificadosP)
        {
            int resultado;
            DAcertificadosP accesodatos = new DAcertificadosP(_cadenaConexion);
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(certificadosP);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }



        public DataSet ListarCertificados(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAcertificadosP accesoDatos = new DAcertificadosP(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarCertificado(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }


    }
}

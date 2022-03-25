using System;
using System.Collections.Generic;
using System.Text;
using Capa4Entidades;
using Capa3AccesoDatos;
using System.Data;
using System.Data.SqlClient;



namespace Capa2Logica
{
   public class BLhorarioP
    {
        private string _cadenaConexion;
        private string _mensaje;

        public BLhorarioP(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedades

        public string Mensaje { get => _mensaje; }
        public int Insertar(EntidadHorarioP HorarioP)
        {
            int id = 0;

           DAhorarioProfesor accesoDatos = new DAhorarioProfesor(_cadenaConexion);

            try
            {
                id = accesoDatos.Insertar(HorarioP);
            }
            catch (Exception)
            {

                throw;
            }

            return id;
        }//fin insertar

        public DataSet ListarHorario(string condicion = "", string orden = "")
        {
            DataSet DS;
            DAhorarioProfesor accesoDatos = new DAhorarioProfesor(_cadenaConexion);
            try
            {
                DS = accesoDatos.ListarHorarios(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }

            return DS;
        }

        public int ElminarConSP(EntidadHorarioP horario)
        {
            int resultado;
            DAhorarioProfesor accesodatos = new DAhorarioProfesor(_cadenaConexion);

           
            try
            {
                resultado = accesodatos.EliminarRegistroConSP(horario);
                _mensaje = accesodatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        public int ComprobarConSP(EntidadHorarioP horario)
        {
            int resultado;
            DAhorarioProfesor accesodatos = new DAhorarioProfesor(_cadenaConexion);


            try
            {
                resultado = accesodatos.ComprobarRegistroConSP(horario);
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
   public class EntidadMatricula
    {
        //atributos
        int id_matricula;
        string id_estudiante;
        string encargado;
        DateTime fecha;
        //contructores
        public EntidadMatricula()
        {
          
        }

        public EntidadMatricula(int id_matricula, string id_estudiante, string encargado, DateTime fecha)
        {
            this.id_matricula = id_matricula;
            this.id_estudiante = id_estudiante;
            this.encargado = encargado;
            this.fecha = fecha;
        }

        //metodos
        public int Id_matricula { get => id_matricula; set => id_matricula = value; }
        public string Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
        public string Encargado { get => encargado; set => encargado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}

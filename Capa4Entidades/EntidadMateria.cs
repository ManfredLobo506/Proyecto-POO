using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    public class EntidadMateria
    {   
        //entidades
        string cod_materia;
        string nombre_materia;
        string total_horas;
        //metodo constructor
        public EntidadMateria()
        {
            
        }

        public EntidadMateria(string cod_materia, string nombre_materia, string total_horas)
        {
            this.cod_materia = cod_materia;
            this.nombre_materia = nombre_materia;
            this.total_horas = total_horas;
        }

        //metodos set get
        public string Cod_materia { get => cod_materia; set => cod_materia = value; }
        public string Nombre_materia { get => nombre_materia; set => nombre_materia = value; }
        public string Total_horas { get => total_horas; set => total_horas = value; }
    }
}

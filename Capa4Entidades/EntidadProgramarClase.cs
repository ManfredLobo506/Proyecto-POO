using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    public class EntidadProgramarClase
    {
        //atributos
        int id;
        string id_estudiante;
        string cod_materia_a;
        DateTime dia;
        DateTime hora;
        //metodo constructor
        public EntidadProgramarClase()
        {
            
        }

        //metodos set get

        public string Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
        public string Cod_materia_a { get => cod_materia_a; set => cod_materia_a = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public int Id { get => id; set => id = value; }
    }
}

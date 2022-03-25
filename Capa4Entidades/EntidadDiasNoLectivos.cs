using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    public class EntidadDiasNoLectivos
    {
        //entidades
        int cod;
        string id_profesor;
        string motivo;
        DateTime fecha;
        //metodo constructor
        public EntidadDiasNoLectivos()
        {
           
        }

        public EntidadDiasNoLectivos(int cod, string id_profesor, string motivo, DateTime fecha)
        {
            this.cod = cod;
            this.id_profesor = id_profesor;
            this.motivo = motivo;
            this.fecha = fecha;
        }

        //metodos get set
        public string Id_profesor { get => id_profesor; set => id_profesor = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Cod { get => cod; set => cod = value; }
    }
}

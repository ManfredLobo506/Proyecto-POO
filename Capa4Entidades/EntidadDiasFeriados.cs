using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    class EntidadDiasFeriados
    {
        //atributos
        string motivo;
        DateTime fecha;
        //metodo constructor
        public EntidadDiasFeriados()
        {
           
        }

        public EntidadDiasFeriados(string motivo, DateTime fecha)
        {
            this.motivo = motivo;
            this.fecha = fecha;
        }

        //metodos get set
        public string Motivo { get => motivo; set => motivo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}

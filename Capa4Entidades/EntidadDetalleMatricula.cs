using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    public class EntidadDetalleMatricula
    {
        //atributos
        int id_detalle_matricula;
        int id_matricula;
        string cod_materiaA;
        int nota;
        string cancelado;
        //metodo constructor
        public EntidadDetalleMatricula()
        {
           
        }

        public EntidadDetalleMatricula(int id_detalle_matricula, int id_matricula, string cod_materiaA, int nota, string cancelado)
        {
            this.id_detalle_matricula = id_detalle_matricula;
            this.id_matricula = id_matricula;
            this.cod_materiaA = cod_materiaA;
            this.nota = nota;
            this.cancelado = cancelado;
        }

        //metodos
        public int Id_detalle_matricula { get => id_detalle_matricula; set => id_detalle_matricula = value; }
        public int Id_matricula { get => id_matricula; set => id_matricula = value; }
        public string Cod_materiaA { get => cod_materiaA; set => cod_materiaA = value; }
        public int Nota { get => nota; set => nota = value; }
        public string Cancelado { get => cancelado; set => cancelado = value; }
    }
}

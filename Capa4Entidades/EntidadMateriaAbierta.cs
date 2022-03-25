using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
   public class EntidadMateriaAbierta
    {
        //entidades
        string cod_MateriaA;
        string cod_materia;
        string identificacionP;
        int cupo;
        int costo;
        //metodo constructor
        public EntidadMateriaAbierta()
        {
          
        }

        public EntidadMateriaAbierta(string cod_MateriaA, string cod_materia, string identificacionP, int cupo, int costo)
        {
            this.cod_MateriaA = cod_MateriaA;
            this.cod_materia = cod_materia;
            this.identificacionP = identificacionP;
            this.cupo = cupo;
            this.costo = costo;
        }

        //Metods get set
        public string Cod_MateriaA { get => cod_MateriaA; set => cod_MateriaA = value; }
        public string Cod_materia { get => cod_materia; set => cod_materia = value; }
        public string IdentificacionP { get => identificacionP; set => identificacionP = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public int Costo { get => costo; set => costo = value; }
    }
}

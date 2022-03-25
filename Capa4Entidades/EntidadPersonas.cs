using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    public class EntidadPersonas
    {
        //Atributos
        string identificacion;
        string nombre;
        string apellido1;
        string apellido2;
        string correoElectronico;
        string numeroTelefonico;
        //Metodos getter setter
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string NumeroTelefonico { get => numeroTelefonico; set => numeroTelefonico = value; }
        //Metodos constructores
        public EntidadPersonas(string identificacion, string nombre, string apellido1, string apellido2, string correoElectronico, string numeroTelefonico)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.correoElectronico = correoElectronico;
            this.numeroTelefonico = numeroTelefonico;
        }
        public EntidadPersonas()
        {
           
        }
    }
}

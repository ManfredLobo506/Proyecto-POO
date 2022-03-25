using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    public class EntidadUsuarios
    {
        //Entidades
        string nombre;
        string contra;
        string permiso;
        int id;
        //Metodos Constructores
        public EntidadUsuarios()
        {
           
        }

        public EntidadUsuarios(string nombre, string contra, string permiso, int id)
        {
            this.nombre = nombre;
            this.contra = contra;
            this.permiso = permiso;
            this.id = id;
        }
        //Metodos getter Setter
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Permiso { get => permiso; set => permiso = value; }
        public int Id { get => id; set => id = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Capa4Entidades
{
    public class EntidadCertificadosP
    {
        //atributos

        string cod_certificado;
        string id_profesor;
        string nombre_certificado;
        //metodo constructor

        public EntidadCertificadosP()
        {
            
        }

        public EntidadCertificadosP(string cod_certificado, string id_profesor, string nombre_certificado)
        {
            this.cod_certificado = cod_certificado;
            this.id_profesor = id_profesor;
            this.nombre_certificado = nombre_certificado;
        }

        //metodos get set

        public string Cod_certificado { get => cod_certificado; set => cod_certificado = value; }
        public string Id_profesor { get => id_profesor; set => id_profesor = value; }
        public string Nombre_certificado { get => nombre_certificado; set => nombre_certificado = value; }
    }
}

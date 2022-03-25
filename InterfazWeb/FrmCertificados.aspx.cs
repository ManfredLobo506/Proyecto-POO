using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa4Entidades;
using Capa2Logica;

namespace InterfazWeb
{
    public partial class FrmCertificados : System.Web.UI.Page
    {
        string mensajeScript = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public EntidadCertificadosP GeneraraEntidadCertificado()//Generamos la entidad de certificado con los datos de los txt
        {
            EntidadCertificadosP certificadosP = new EntidadCertificadosP();

            certificadosP.Cod_certificado = TxtIdCertificado.Text;
            certificadosP.Nombre_certificado = TxtNombre.Text;
            certificadosP.Id_profesor = TxtId.Text;


            return certificadosP;
        }

       

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmProfesores.aspx");//Al precionar el cancelar nos enviara de regreso a profesores.aspx
        }

        

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            EntidadCertificadosP certificadosP = new EntidadCertificadosP();
            BLcertificadosP logica = new BLcertificadosP(clsConfiguracion.getConnectionString);

            string resultado;

            try
            {
                certificadosP = GeneraraEntidadCertificado();
                resultado = logica.Insertar(certificadosP);//Insertamos los datos enviando la entidad al metodo de insertar
                mensajeScript = string.Format("javascript:mostrarMensaje('Operacion realizada con exito')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                Response.Redirect("FrmProfesores.aspx");//Al completar la operacion hacemos un redirect a FrmProfesores.aspx
            }
            catch (Exception EX)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",EX);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }
    }
}
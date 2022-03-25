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
    public partial class FrmAbrirMateria : System.Web.UI.Page
    {
        string mensajeScript = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtCodMateria.Enabled = false;
            if (Convert.ToInt32(Session["NUM"])==1)//Verificamo desde donde se cargo la pagina mediante la variable num
            {
                TxtCodMateria.Text = Session["COD_MATERIA"].ToString();
            }
            (Session["NUM"]) = 0;//El valor se retorna a 0 para que no vuelva al cargar el valor

        }
        public EntidadMateriaAbierta GeneraraEntidadMateriaA()//Generamos la entidad de la materia que vamos a abrir
        {
            EntidadMateriaAbierta detalle = new EntidadMateriaAbierta();

            detalle.Cod_materia = TxtCodMateria.Text;
            detalle.Cod_MateriaA = TxtMateriaA.Text;
            detalle.IdentificacionP = TxtIdP.Text;
            detalle.Costo = int.Parse(TxtCosto.Text);
            detalle.Cupo = int.Parse(TxtCupo.Text);


            return detalle;
        }

       

        protected void BtnBuscar2_Click(object sender, EventArgs e)//Este boton es para redirigir a el catalogo de programas y elegir la materia que se desea abrir
        {
            Response.Redirect("FrmCatalogoProgramas.aspx");
        }



        protected void BtnGuardar_Click(object sender, EventArgs e)//Este boton es para ingresar el dato 
        {
            EntidadMateriaAbierta materiaA = new EntidadMateriaAbierta();
            BLmateriaAbierta logica = new BLmateriaAbierta(clsConfiguracion.getConnectionString);

            string resultado;

            try
            {   
                    materiaA = GeneraraEntidadMateriaA();
                    resultado = logica.Insertar(materiaA);//Llamamos al el metodo llamado Insertar de la capa de logica
                    mensajeScript = string.Format("javascript:mostrarMensaje('Operacion realizada con exito')");//Enviamos el mensaje de que el proceso se completo exitosamente
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }

            catch (Exception EX)
            {

                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",EX);//Mostramos el mensaje de error
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);


            }
        }
    }
}
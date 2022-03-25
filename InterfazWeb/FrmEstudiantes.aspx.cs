using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa4Entidades;
using Capa2Logica;
using System.Data;

namespace InterfazWeb
{
    public partial class FrmClientes : System.Web.UI.Page
    {
        string mensajeScript = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarListaDataSet();//Llamamos a el metodo de cargar los datos
        }


        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
           //Cargamos los datos de los estudiantes al el gried
            BLestudiante logica = new BLestudiante(clsConfiguracion.getConnectionString);
            DataSet DSestudiantes;
            try
            {
                DSestudiantes = logica.ListarEstudiante(condicion, orden);
                GrdEstudiante.DataSource = DSestudiantes;
                GrdEstudiante.DataMember = DSestudiantes.Tables[0].TableName;
                GrdEstudiante.DataBind();
              
            }
            catch (Exception)
            {
                throw;
            }
        }

        


 
  

        protected void LnkEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());//Sacamos los datos del CommandArgument anteriormente configurado
            BLestudiante logica = new BLestudiante(clsConfiguracion.getConnectionString);
            EntidadEstudiantes estudiante = new EntidadEstudiantes();

            try
            {
                estudiante.Identificacion = id.ToString();

                if (logica.ElminarConSP(estudiante) > 0)
                {
                    mensajeScript = string.Format("javascript:mostrarMensaje('Estudiante eliminado Correctamente')");//Enviamos un mensaje si la operacion se realizo exitosamente
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

                    CargarListaDataSet();

                }
                else
                {
                    mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", logica.Mensaje);//Mostramos el mensaje enviado
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }

            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);//En caso de un error sera mostrado en pantalla
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, false);
            }
        }






        protected void LnkModificar_Command(object sender, CommandEventArgs e)
        {
            Session["id_estudiante"] = e.CommandArgument.ToString();//Sacamos el id estudiante del commandArgument
            Session["NUM"] = 1;//Para saber de donde es enviado el dato

            Response.Redirect("FrmMantenimientoEstudiantes.aspx");//Hacemos el redirect a el FrmMantenimientoEstudiantes.aspx
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["id_estudiante"] = null;//Para inicializar el valor en  null
            Response.Redirect("FrmMantenimientoEstudiantes.aspx");//Hacemos el redirect a el FrmMantenimientoEstudiantes.aspx
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("NOMBRE_E LIKE '%{0}%'", TxtBuscar.Text);//Filtramos la informacion
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }
    }
}
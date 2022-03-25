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
    public partial class FrmProductos : System.Web.UI.Page
    {
        string mensajeScript = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            //carga el datagridview con el dataset
            BLprofesor logica = new BLprofesor(clsConfiguracion.getConnectionString);
            DataSet DsProfesor;
            try
            {
                DsProfesor = logica.ListarProfesores(condicion, orden);
                GrdProfesores.DataSource =DsProfesor;
                GrdProfesores.DataMember = DsProfesor.Tables[0].TableName;
                GrdProfesores.DataBind();
                //en la tabla con nombre Clientes del dataset
            }
            catch (Exception)
            {
                throw;
            }
        }// fin CargarListaDataSet

        protected void LnkEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            BLprofesor logica = new BLprofesor(clsConfiguracion.getConnectionString);
            EntidadesProfesor profesor = new EntidadesProfesor();

            try
            {
                profesor.Identificacion = id.ToString();

                if (logica.ElminarConSP(profesor) > 0)
                {
                    mensajeScript = string.Format("javascript:mostrarMensaje('Profesor eliminado Correctamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

                    CargarListaDataSet();

                }
                else
                {
                    mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", logica.Mensaje);
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }

            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, false);
            }
        }

        protected void LnkModificar_Command(object sender, CommandEventArgs e)
        {
            Session["id_profesor"] = e.CommandArgument.ToString();//Asignamos valor a la variable de sesion
            Session["NUM"] = 1;//Para saber de donde se redirige el formulario

            Response.Redirect("FrmMantenimientoProfesores.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["id_profesor"] = null;
            Response.Redirect("FrmMantenimientoProfesores.aspx");
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("NOMBRE_P LIKE '%{0}%'", Txtbuscar.Text);//Filtramos la informacion
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
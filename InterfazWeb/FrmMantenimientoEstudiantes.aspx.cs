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
    public partial class FrmEstudiantes : System.Web.UI.Page
    {
        string mensajeScript = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["NUM"]) == 1)
            {
                Bd_POODataContext dataContext = new Bd_POODataContext();

                var consulta2 = from est in dataContext.ESTUDIANTES
                                where est.IDENTIFICACION_E == Session["id_estudiante"].ToString()
                                select est;
                foreach (var item in consulta2)
                {
                    TxtId.Text = item.IDENTIFICACION_E;
                    TxtNombre.Text = item.NOMBRE_E;
                    TxtApellido1.Text = item.APELLIDO1_E;
                    TxtApellido2.Text = item.APELLIDO2_E;
                    TxtEmail.Text = item.CORREO_ELECTRONICO_E;
                    TxtTelefono.Text = item.NUMERO_TELEFONICO;
                }

            }
            Session["NUM"] = 0;
        }
        public EntidadEstudiantes generarEstudiante()//Generamos la entidad estudiantes
        {
            EntidadEstudiantes estudiante = new EntidadEstudiantes();
            estudiante.Identificacion = TxtId.Text;//Asiganamos los valores del objeto con sus respectivos valores
            estudiante.Apellido1 = TxtApellido1.Text;
            estudiante.Apellido2 = TxtApellido2.Text;
            estudiante.NumeroTelefonico = TxtTelefono.Text;
            estudiante.CorreoElectronico = TxtEmail.Text;
            estudiante.Nombre = TxtNombre.Text;

            return estudiante;
        }
        void limpiar()
        {
            TxtId.Text = null;
            TxtNombre.Text = null;
            TxtTelefono.Text = null;
            TxtApellido1.Text = null;
            TxtApellido2.Text = null;
            TxtEmail.Text = null; 
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Bd_POODataContext dataContext = new Bd_POODataContext();
            var consulta = (from est in dataContext.ESTUDIANTES
                            where est.IDENTIFICACION_E == TxtId.Text
                            select est).Count();

            EntidadEstudiantes estudiantes = new EntidadEstudiantes();
            BLestudiante logica = new BLestudiante(clsConfiguracion.getConnectionString);//Realizamos la modificacion o insertamos valores

            estudiantes = generarEstudiante();//Generamos la entidad de estudiantes

            string resultado;

            try
            {               
                if (Convert.ToInt32(consulta) == 0)
                {                  
                    resultado = logica.Insertar(estudiantes).ToString();
                    mensajeScript = string.Format("javascript:mostrarMensaje('Operacion Realizada con exito')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    Response.Redirect("FrmEstudiantes.aspx");
                }
                else
                {
                    
                    resultado = logica.ActualizarConSP(estudiantes).ToString();
                    mensajeScript = string.Format("javascript:mostrarMensaje('Actualizacion Realizada con exito')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    Response.Redirect("FrmEstudiantes.aspx");
                }
            }


            catch (Exception EX)
            {

                mensajeScript = string.Format("javascript:mostrarMensaje('Ha ocurrido un error en la ejecucion')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                Response.Redirect("FrmEstudiantes.aspx");

            }
        }




        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmEstudiantes.aspx");//Hacemos el redirect a FrmEstudiantes.aspx

        }
    }
}
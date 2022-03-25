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
    public partial class FrmProfesores : System.Web.UI.Page
    {
        string mensajeScript = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["NUM"]) == 1)
            {
                Bd_POODataContext dataContext = new Bd_POODataContext();

                var consulta2 = from profe in dataContext.PROFESORES
                                where profe.IDENTIFICACION_P == Session["id_profesor"].ToString()
                                select profe;
                foreach (var item in consulta2)
                {
                    TxtId.Text = item.IDENTIFICACION_P;
                    TxtNombre.Text = item.NOMBRE_P;
                    TxtApellido1.Text = item.APELLIDO1_P;
                    TxtApellido2.Text = item.APELLIDO2_P;
                    TxtEmail.Text = item.CORREO_ELECTRONICO_P;
                    TxtTelefono.Text = item.NUMERO_TELEFONICO_P;
                }

            }
            Session["NUM"] = 0;



        }
        public EntidadesProfesor generarProfesor()//Generamos la entidad estudiantes
        {
            EntidadesProfesor Profesor = new EntidadesProfesor();
            Profesor.Identificacion = TxtId.Text;//Asiganamos los valores del objeto con sus respectivos valores
            Profesor.Apellido1 = TxtApellido1.Text;
            Profesor.Apellido2 = TxtApellido2.Text;
            Profesor.NumeroTelefonico = TxtTelefono.Text;
            Profesor.CorreoElectronico = TxtEmail.Text;
            Profesor.Nombre = TxtNombre.Text;

            return Profesor;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Bd_POODataContext dataContext = new Bd_POODataContext();
            var consulta = (from profe in dataContext.PROFESORES
                            where profe.IDENTIFICACION_P == TxtId.Text
                            select profe).Count();

            EntidadesProfesor profesor = new EntidadesProfesor();
            BLprofesor logica = new BLprofesor(clsConfiguracion.getConnectionString);
            
            string resultado;

            try//Realizamos la modificacion o insertamos los valores
            {
                
                
                if (Convert.ToInt32(consulta)==0)
                {
                    profesor = generarProfesor();
                    resultado = logica.Insertar(profesor);
                    mensajeScript = string.Format("javascript:mostrarMensaje('Operacion Realizada con exito')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    Response.Redirect("FrmProfesores.aspx");

                }
                else
                {
                    profesor = generarProfesor();
                    resultado = logica.ActualizarConSP(profesor).ToString();
                    mensajeScript = string.Format("javascript:mostrarMensaje('Actualizacion Realizada con exito')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    Response.Redirect("FrmProfesores.aspx");
                }
               
            }

            
            catch (Exception EX)
            {

                mensajeScript = string.Format("javascript:mostrarMensaje('Ha ocurrido un error en la ejecucion')");//Si ocurre un error es mostrado
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                Response.Redirect("FrmProfesores.aspx");

            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmProfesores.aspx");
        }
    }
}
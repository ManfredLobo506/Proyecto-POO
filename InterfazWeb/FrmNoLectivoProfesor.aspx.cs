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
    public partial class FrmNoLectivoProfesor : System.Web.UI.Page
    {
        string mensajeScript = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public EntidadDiasNoLectivos GeneraraEntidadDiasNoLectivos()
        {
            EntidadDiasNoLectivos diasNoLectivos = new EntidadDiasNoLectivos();//Generamos la entidad dias no lectivos

            diasNoLectivos.Id_profesor = TxtId.Text;
            diasNoLectivos.Motivo = TxtMotivo.Text;
            diasNoLectivos.Fecha = Calendar1.SelectedDate;


            return diasNoLectivos;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            EntidadDiasNoLectivos diasNoLectivos = new EntidadDiasNoLectivos();
            BLdiasNoLectivos logica = new BLdiasNoLectivos(clsConfiguracion.getConnectionString);

            int resultado;

            try
            {               
                    diasNoLectivos = GeneraraEntidadDiasNoLectivos();
                    resultado = logica.Insertar(diasNoLectivos);//Insertamos los dias no lectivos
                    mensajeScript = string.Format("javascript:mostrarMensaje('Operacion realizada con exito')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }

            catch (Exception EX)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",EX);//Si hay un error los mosrtamos
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

            }
        }
    }
}
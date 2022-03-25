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
    public partial class FrmProgramarClase : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridClasesSincronicas();
        }
        EntidadProgramarClase cargarEntidad()
        {
            EntidadProgramarClase programarClase = new EntidadProgramarClase();
            programarClase.Id_estudiante = TxtId.Text;
            programarClase.Cod_materia_a = TxtCod.Text;
            programarClase.Dia = Convert.ToDateTime(Calendar1.SelectedDate);
            programarClase.Hora = Convert.ToDateTime(LstEntrada.Text);
            return programarClase;
        }

        private void cargarGridClasesSincronicas()
        {

            Bd_POODataContext dataContext = new Bd_POODataContext();
            var consulta = from clases in dataContext.PROGRAMAR_CLASE//Cargamos los datos de la consulta en el gried
                           select clases;
        
            GrdClases.DataSource = consulta;
            GrdClases.DataBind();
        }

        private void buscar()
        {
            string id = TxtBuscar.Text;
            Bd_POODataContext dataContext = new Bd_POODataContext();//Cargamos los datos de la consulta con el gried pero con un contains
            var consulta = from clases in dataContext.PROGRAMAR_CLASE
                           where clases.COD_MATERIA_ABIERTA.Contains(id)
                           orderby clases.HORA                      
                           select clases;
            GrdClases.DataSource = consulta;
            GrdClases.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        string mensajeScript = "";
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            EntidadProgramarClase programarClase = new EntidadProgramarClase();
            BLprogramarClase logica = new BLprogramarClase(clsConfiguracion.getConnectionString);

            int resultado;

            try
            {
                

               
                    programarClase = cargarEntidad();
                    resultado = logica.REVISAR_DISPONIBILIDAD(programarClase);
                    if (programarClase.Dia.ToString("dddd") == "domingo" || programarClase.Dia.ToString("dddd") == "sábado")//verificamos que no ingresen una fecha invalida
                    {
                    mensajeScript = string.Format("javascript:mostrarMensaje('No se trabajan los fines de semana')");//Realizamos las respectivas validaciones
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }
                    else if (resultado == 1)
                    {
                    mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",logica.Mensaje);
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }
                    else
                    {
                    resultado = logica.Insertar(programarClase);
                    cargarGridClasesSincronicas();
                    mensajeScript = string.Format("javascript:mostrarMensaje('Operacion realizada con exito')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

                }
                   
                
            }

            catch (Exception EX)
            {

                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",EX);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);


            }
        }
    }
}
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
    public partial class FrmMatricula : System.Web.UI.Page
    {
        string mensajeScript = "";

        public EntidadMatricula GeneraraEntidadMatricula()//Generamos la entidad
        {
            EntidadMatricula matricula = new EntidadMatricula();
            matricula.Id_estudiante = TxtId.Text;
            matricula.Encargado = TxtEncargado.Text;
            matricula.Fecha = DateTime.Now;

            return matricula;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (Convert.ToInt32(Session["NUM"])== 1)//Revisamos si la pagina fue abierta por otra pagina
            {
                TxtCodMateria.Text= Session["COD_MATERIA_ABIERTA"].ToString();
            }
            (Session["NUM"]) = 0;
        }

     
       

        protected void BtnBuscar2_Click(object sender, EventArgs e)
        {
                Response.Redirect("FrmCatalogoElementos.aspx");//Redirigimos al catalogo de elementos           
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EntidadMatricula matricula = new EntidadMatricula();
                BLmatricula logica = new BLmatricula(clsConfiguracion.getConnectionString);

                int resultado;

                try
                {
                        matricula = GeneraraEntidadMatricula();
                        resultado = logica.CorroborarEstadoConSP(matricula);
                   if (resultado == 0)
                        {
                        mensajeScript = string.Format("javascript:mostrarMensaje('El estudiante esta moroso')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);

                        }
                    else
                        {
                            resultado = logica.Insertar(matricula);
                            mensajeScript = string.Format("javascript:mostrarMensaje('Operacion Realizada Con Exito')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }

                catch (Exception EX)
                {

                    mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",EX);
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);


                }

                Bd_POODataContext dataContext = new Bd_POODataContext();

                var consulta = (from matricula2 in dataContext.MATRICULAS
                                orderby matricula2.ID_MATRICULA descending
                                select matricula2).First();//Tomamos el ultimo dato ingresado en matriculas

                int id = consulta.ID_MATRICULA;//Asignamos el valor de la consulta a el id

                EntidadDetalleMatricula Detalle = new EntidadDetalleMatricula();
                BLdetalleMatricula logicaDM = new BLdetalleMatricula(clsConfiguracion.getConnectionString);

                int resultado1;

                try
                {

                    Detalle.Id_matricula = id;
                    Detalle.Nota = 100;
                    Detalle.Cod_materiaA = TxtCodMateria.Text;
                    Detalle.Cancelado = DropDownList1.Text;
                    
                   resultado1 = logicaDM.CorroborarCupoConSP(Detalle);//Corroboramos el cupo
                    if (resultado1 == 0)
                        {
                            mensajeScript = string.Format("javascript:mostrarMensaje('No hay cupos para la materia')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        }
                    else
                        {
                        resultado1 = logicaDM.Insertar(Detalle);
                        mensajeScript = string.Format("javascript:mostrarMensaje('Operacion Realizada Con Exito')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }

                
                catch (Exception EX)//Si hay error mostramos el mensaje
                {
                    mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",EX);
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }    
            }
            catch (Exception)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('Ha ocurrido un error en la ejecucion')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }  
        }
    }
}

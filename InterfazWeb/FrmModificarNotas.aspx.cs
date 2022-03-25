using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterfazWeb
{
    public partial class FrmModificarNotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        string mensajeScript = "";


        private void cargarGrid()
        {
           
            Bd_POODataContext dataContext = new Bd_POODataContext();
            var consulta = from DETALLE in dataContext.DETALLE_MATRICULA//Realizamos una consulta con join para sacar datos de distintas tablas
                           join MATRICULA in dataContext.MATRICULAS
                           on DETALLE.ID_MATRICULA equals MATRICULA.ID_MATRICULA
                           join MATERIAA in dataContext.MATERIAS_ABIERTAS
                           on DETALLE.COD_MATERIA_ABIERTA equals MATERIAA.COD_MATERIA_ABIERTA
                           join MATERIA in dataContext.MATERIAS
                           on MATERIAA.COD_MATERIA equals MATERIA.COD_MATERIA
                           select new {DETALLE.ID_DETALLEMATRICULA,MATRICULA.ID_ESTUDIANTE,MATERIA.NOMBRE_MATERIA,DETALLE.NOTA };
            GridCatalogo.DataSource = consulta;
            GridCatalogo.DataBind();
        }

        protected void LnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            TxtDetalle.Text = e.CommandArgument.ToString();//Sacamos el dato de CommandArgument
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtNota.Text)>100 || Convert.ToInt32(TxtNota.Text) < 1)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('Debe Ingresar una nota valida')");//Realizamos las verificaciones 
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
            else
            {
              
                try
                {
                    Bd_POODataContext dataContext = new Bd_POODataContext();
                    var consulta = (from detalle in dataContext.DETALLE_MATRICULA
                                    where detalle.ID_DETALLEMATRICULA == Convert.ToInt32(TxtDetalle.Text)
                                    select detalle).FirstOrDefault();
                    consulta.NOTA = Convert.ToInt32(TxtNota.Text);
                    dataContext.SubmitChanges();
                    mensajeScript = string.Format("javascript:mostrarMensaje('Modificacion realizada con exito')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    cargarGrid();
                }
                catch (Exception)
                {

                    mensajeScript = string.Format("javascript:mostrarMensaje('Error durante le ejecucion')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                }
            }
            
            
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            Bd_POODataContext dataContext = new Bd_POODataContext();
            var consulta = from DETALLE in dataContext.DETALLE_MATRICULA//Realizamos una consulta con join para sacar datos de distintas tablas pero ahora con un where.contains
                           join MATRICULA in dataContext.MATRICULAS
                           on DETALLE.ID_MATRICULA equals MATRICULA.ID_MATRICULA
                           join MATERIAA in dataContext.MATERIAS_ABIERTAS
                           on DETALLE.COD_MATERIA_ABIERTA equals MATERIAA.COD_MATERIA_ABIERTA
                           join MATERIA in dataContext.MATERIAS
                           on MATERIAA.COD_MATERIA equals MATERIA.COD_MATERIA
                           where MATRICULA.ID_ESTUDIANTE.Contains(txtBuscar.Text) 

                           select new { DETALLE.ID_DETALLEMATRICULA, MATRICULA.ID_ESTUDIANTE, MATERIA.NOMBRE_MATERIA, DETALLE.NOTA };

            GridCatalogo.DataSource = consulta;
            GridCatalogo.DataBind();
        }
    }
}
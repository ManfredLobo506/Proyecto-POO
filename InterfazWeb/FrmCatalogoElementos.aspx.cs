using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterfazWeb
{
    public partial class FrmCatalogoElementos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridCatalogo();
        }
        private void cargarGridCatalogo()
        {
         
            Bd_POODataContext dataContext = new Bd_POODataContext();
            var consulta = from materia in dataContext.MATERIAS//creamos la consulta con join para sacar datos especificos de distintas tablas
                           join materiaAbierta in dataContext.MATERIAS_ABIERTAS
                           on materia.COD_MATERIA equals materiaAbierta.COD_MATERIA
                           orderby materiaAbierta.COD_MATERIA_ABIERTA
                           select new {materiaAbierta.COD_MATERIA_ABIERTA, materia.NOMBRE_MATERIA,materiaAbierta.COSTO,materiaAbierta.CUPO };
            GridCatalogo.DataSource = consulta;//Cargamos los datos de la consulta a el gried
            GridCatalogo.DataBind();
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            Bd_POODataContext dataContext = new Bd_POODataContext();//Creamos la misma consulta de cargarGridCatalogo() pero ahora utilizando un where para filtrar la informacion
            var consulta = from materia in dataContext.MATERIAS
                           join materiaAbierta in dataContext.MATERIAS_ABIERTAS
                           on materia.COD_MATERIA equals materiaAbierta.COD_MATERIA
                           where materia.NOMBRE_MATERIA==txtBuscar.Text
                           orderby materiaAbierta.COD_MATERIA_ABIERTA
                           select new { materiaAbierta.COD_MATERIA_ABIERTA, materia.NOMBRE_MATERIA, materiaAbierta.COSTO, materiaAbierta.CUPO };
            GridCatalogo.DataSource = consulta;//Cargamos los datos de la consulta a el gried
            GridCatalogo.DataBind();
        }

        protected void LnkSelect_Command(object sender, CommandEventArgs e)
        {
            Session["COD_MATERIA_ABIERTA"] = e.CommandArgument.ToString();
            Session["NUM"] = 1;//Este numero lo utilizamos para saber de donde viene el llamado del formulario

            Response.Redirect("FrmMatricula.aspx");//Hacemos un redirect a el formulario de matricula
        }
    }
}